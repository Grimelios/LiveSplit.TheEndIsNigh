using System;
using System.Collections.Generic;
using System.Drawing;
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

		private bool runStarted;

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
			settings = new EndIsNighSettings(splitCollection, settingsControl.CollectionControl);
		}

		/// <summary>
		/// Component name.
		/// </summary>
		public string ComponentName => "The End Is Nigh Autosplitter";

		/// <summary>
		/// Horizontal width of the component.
		/// </summary>
		public float HorizontalWidth => 0;

		/// <summary>
		/// Minimum height of the component.
		/// </summary>
		public float MinimumHeight => 0;

		/// <summary>
		/// Vertical height of the component.
		/// </summary>
		public float VerticalHeight => 0;

		/// <summary>
		/// Minimum width of the component.
		/// </summary>
		public float MinimumWidth => 0;

		/// <summary>
		/// Top padding of the component.
		/// </summary>
		public float PaddingTop => 0;

		/// <summary>
		/// Bottom padding of the component.
		/// </summary>
		public float PaddingBottom => 0;

		/// <summary>
		/// Left padding of the component.
		/// </summary>
		public float PaddingLeft => 0;

		/// <summary>
		/// Right padding of the component.
		/// </summary>
		public float PaddingRight => 0;

		/// <summary>
		/// Content menu controls for the component.
		/// </summary>
		public IDictionary<string, Action> ContextMenuControls => null;

		/// <summary>
		/// Draws the component horizontally within the LiveSplit window.
		/// </summary>
		public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
		{
		}

		/// <summary>
		/// Draws the component vertically within the LiveSplit window.
		/// </summary>
		public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
		{
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

				timer.OnSplit += OnSplit;
				timer.OnUndoSplit += OnUndoSplit;
				timer.OnSkipSplit += OnSkipSplit;
				timer.OnReset += OnReset;
			}

			Autosplit();
		}

		/// <summary>
		/// Secondary update function used to do most of the actual autosplitting work. Also useful for testing.
		/// </summary>
		public void Autosplit()
		{
			if (!memory.HookProcess())
			{
				return;
			}

			if (!runStarted)
			{
				if (((MapGrid)dataClasses[0]).QueryStart())
				{
					timer?.Start();
					runStarted = true;
				}
				else
				{
					return;
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

			runStarted = false;
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
