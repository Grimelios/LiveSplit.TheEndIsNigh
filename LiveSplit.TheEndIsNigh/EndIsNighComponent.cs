using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.TheEndIsNigh.Controls;
using LiveSplit.TheEndIsNigh.Data;
using LiveSplit.TheEndIsNigh.Memory;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.TheEndIsNigh
{
	/// <summary>
	/// LiveSplit component implementing autosplitter functionality for The End Is Nigh.
	/// </summary>
	public class EndIsNighComponent : IComponent
	{
		private TimerModel timer;
		private EndIsNighControl settingsControl;
		private EndIsNighMemory memory;
		private EndIsNighSettings settings;
		private AutosplitDataClass[] dataClasses;
		private SplitCollection splitCollection;

		private InfoTextComponent textComponent;

		private bool fileSelected;
		private bool runStarted;
		private bool processHooked;

		private int deathCount;

		/// <summary>
		/// Constructs the component.
		/// </summary>
		public EndIsNighComponent()
		{
			memory = new EndIsNighMemory();

			dataClasses = new AutosplitDataClass[]
			{
				new MapGrid(memory),
				new TumorCollection(memory),
				new BodyPartCollection(memory),
				new CartridgeCollection(memory),
				new WorldEventCollection(memory),   
			};

			splitCollection = new SplitCollection(this, dataClasses);
			settingsControl = new EndIsNighControl();
			settingsControl.CollectionControl.SplitCollection = splitCollection;
			settings = new EndIsNighSettings(splitCollection, settingsControl.CollectionControl, settingsControl.SettingsControl);

			textComponent = new InfoTextComponent("Death Count", "0")
			{
				LongestString = int.MaxValue.ToString()
			};
		}

		/// <summary>
		/// Component name.
		/// </summary>
		public string ComponentName => "The End Is Nigh Autosplitter";

		/// <summary>
		/// Horizontal width of the component.
		/// </summary>
		public float HorizontalWidth => settings.DisplayEnabled ? textComponent.HorizontalWidth : 0;

		/// <summary>
		/// Minimum height of the component.
		/// </summary>
		public float MinimumHeight => settings.DisplayEnabled ? textComponent.MinimumHeight : 0;

		/// <summary>
		/// Vertical height of the component.
		/// </summary>
		public float VerticalHeight => settings.DisplayEnabled ? textComponent.VerticalHeight : 0;

		/// <summary>
		/// Minimum width of the component.
		/// </summary>
		public float MinimumWidth => settings.DisplayEnabled ? textComponent.MinimumWidth : 0;

		/// <summary>
		/// Top padding of the component.
		/// </summary>
		public float PaddingTop => settings.DisplayEnabled ? textComponent.PaddingTop : 0;

		/// <summary>
		/// Bottom padding of the component.
		/// </summary>
		public float PaddingBottom => settings.DisplayEnabled ? textComponent.PaddingBottom : 0;

		/// <summary>
		/// Left padding of the component.
		/// </summary>
		public float PaddingLeft => settings.DisplayEnabled ? textComponent.PaddingLeft : 0;

		/// <summary>
		/// Right padding of the component.
		/// </summary>
		public float PaddingRight => settings.DisplayEnabled ? textComponent.PaddingRight : 0;

		/// <summary>
		/// Content menu controls for the component.
		/// </summary>
		public IDictionary<string, Action> ContextMenuControls => null;

		/// <summary>
		/// Draws the component horizontally within the LiveSplit window.
		/// </summary>
		public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
		{
			if (settings.DisplayEnabled)
			{
				FillBackground(g, state, HorizontalWidth, height);
				PrepareDraw(state);

				textComponent.DrawHorizontal(g, state, height, clipRegion);
			}
		}

		/// <summary>
		/// Draws the component vertically within the LiveSplit window.
		/// </summary>
		public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
		{
			if (settings.DisplayEnabled)
			{
				FillBackground(g, state, width, VerticalHeight);
				PrepareDraw(state);

				textComponent.DrawVertical(g, state, width, clipRegion);
			}
		}

		/// <summary>
		/// Fills the background for the LiveSplit display.
		/// </summary>
		private void FillBackground(Graphics g, LiveSplitState state, float width, float height)
		{
			Color backgroundColor = state.LayoutSettings.BackgroundColor;

			if (backgroundColor.ToArgb() != Color.Transparent.ToArgb())
			{
				g.FillRectangle(new SolidBrush(backgroundColor), 0, 0, width, height);
			}
		}

		/// <summary>
		/// Prepares for drawing.
		/// </summary>
		private void PrepareDraw(LiveSplitState state)
		{
			Options.LayoutSettings layoutSettings = state.LayoutSettings;

			textComponent.NameLabel.HasShadow = layoutSettings.DropShadows;
			textComponent.ValueLabel.HasShadow = layoutSettings.DropShadows;
			textComponent.NameLabel.HorizontalAlignment = StringAlignment.Near;
			textComponent.ValueLabel.HorizontalAlignment = StringAlignment.Far;
			textComponent.NameLabel.VerticalAlignment = StringAlignment.Near;
			textComponent.ValueLabel.VerticalAlignment = StringAlignment.Near;
			textComponent.NameLabel.ForeColor = layoutSettings.TextColor;
			textComponent.ValueLabel.ForeColor = layoutSettings.TextColor;
		}

		/// <summary>
		/// Returns the settings control for the component.
		/// </summary>
		public Control GetSettingsControl(LayoutMode mode)
		{
			return settingsControl;
		}
		
		/// <summary>
		/// Triggers the timer to split.
		/// </summary>
		public void Split()
		{
			timer.Split();
		}

		/// <summary>
		/// Updates the component. This is where most of the actual autosplitting work is done.
		/// </summary>
		public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
		{
			if (timer == null)
			{
				timer = new TimerModel
				{
					CurrentState = state
				};

				state.OnSplit += OnSplit;
				state.OnUndoSplit += OnUndoSplit;
				state.OnSkipSplit += OnSkipSplit;
				state.OnReset += OnReset;
			}

			bool processPreviouslyHooked = processHooked;

			Autosplit();

			if (processHooked)
			{
				// If someone keeps the timer running after exiting to the menu, it's probably also useful to keep display death count for
				// that run until the timer is reset.
				deathCount = memory.CheckInGame() || timer.CurrentState.CurrentPhase == TimerPhase.Running
					? Math.Max(deathCount, memory.GetDeathCount())
					: 0;
			}

			// The death count should reset to zero when the game exits.
			if (!processHooked && processPreviouslyHooked)
			{
				deathCount = 0;
			}

			if (processHooked || processPreviouslyHooked)
			{
				textComponent.InformationValue = deathCount.ToString();
				textComponent.Update(invalidator, state, width, height, mode);

				invalidator?.Invalidate(0, 0, width, height);
			}
		}

		/// <summary>
		/// Secondary update function used to do most of the actual autosplitting work. Also useful for testing.
		/// </summary>
		public void Autosplit()
		{
			if (!memory.HookProcess())
			{
				processHooked = false;

				return;
			}

			processHooked = true;

			if (!runStarted)
			{
				if (!fileSelected && memory.CheckFileSelect())
				{
					// Checking for null allows this function to be used in testing (where no timer exists).
					timer?.Start();
					runStarted = true;
					fileSelected = true;
				}
				else
				{
					return;
				}
			}

			if (fileSelected)
			{
				fileSelected = memory.CheckFileSelect();

				if (!fileSelected)
				{
					runStarted = false;
				}
			}

			splitCollection.Update();
		}

		/// <summary>
		/// Called when the timer splits.
		/// </summary>
		private void OnSplit(object sender, EventArgs e)
		{
			splitCollection.OnSplit();
		}

		/// <summary>
		/// Called when a split is undone.
		/// </summary>
		private void OnUndoSplit(object sender, EventArgs e)
		{
			splitCollection.OnUndoSplit();
		}

		/// <summary>
		/// Called when a split is skipped.
		/// </summary>
		private void OnSkipSplit(object sender, EventArgs e)
		{
			splitCollection.OnSkipSplit();
		}

		/// <summary>
		/// Called when the timer is reset.
		/// </summary>
		private void OnReset(object sender, TimerPhase e)
		{
			splitCollection.OnReset();

			foreach (AutosplitDataClass dataClass in dataClasses)
			{
				dataClass.Reset();
			}

			// This check prevents the timer from resetting and immediately restarting when you reset the timer in-game.
			if (!fileSelected)
			{
				runStarted = false;
			}
		}

		/// <summary>
		/// Sets component settings from the given XML node.
		/// </summary>
		public void SetSettings(XmlNode settings)
		{
			this.settings.LoadSettings(settings);
		}

		/// <summary>
		/// Returns an XML settings node for the component.
		/// </summary>
		public XmlNode GetSettings(XmlDocument document)
		{
			return settings.SaveSettings(document);
		}

		/// <summary>
		/// Disposes the component.
		/// </summary>
		public void Dispose()
		{
		}
	}
}
