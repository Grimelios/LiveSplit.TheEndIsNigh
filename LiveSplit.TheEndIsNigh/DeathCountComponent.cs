using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.TheEndIsNigh
{
	/// <summary>
	/// Represents the drawable death count component for The End Is Nigh.
	/// </summary>
	public class DeathCountComponent : IComponent
	{
		private InfoTextComponent textComponent;

		private int previousDeathCount;

		/// <summary>
		/// Constructs the component.
		/// </summary>
		public DeathCountComponent()
		{
			textComponent = new InfoTextComponent("Death Count", "0")
			{
				LongestString = int.MaxValue.ToString()
			};
		}

		/// <summary>
		/// Current death count.
		/// </summary>
		public int DeathCount { get; set; }

		/// <summary>
		/// Component name.
		/// </summary>
		public string ComponentName => "Death Count";

		/// <summary>
		/// Horizontal width of the component.
		/// </summary>
		public float HorizontalWidth => textComponent.HorizontalWidth;

		/// <summary>
		/// Minimum height of the component.
		/// </summary>
		public float MinimumHeight => textComponent.MinimumHeight;

		/// <summary>
		/// Vertical height of the component.
		/// </summary>
		public float VerticalHeight => textComponent.VerticalHeight;

		/// <summary>
		/// Minimum width of the component.
		/// </summary>
		public float MinimumWidth => textComponent.MinimumWidth;

		/// <summary>
		/// Top padding of the component.
		/// </summary>
		public float PaddingTop => textComponent.PaddingTop;

		/// <summary>
		/// Bottom padding of the component.
		/// </summary>
		public float PaddingBottom => textComponent.PaddingBottom;

		/// <summary>
		/// Left padding of the component.
		/// </summary>
		public float PaddingLeft => textComponent.PaddingLeft;

		/// <summary>
		/// Right padding of the component.
		/// </summary>
		public float PaddingRight => textComponent.PaddingRight;

		/// <summary>
		/// Content menu controls for the component.
		/// </summary>
		public IDictionary<string, Action> ContextMenuControls => null;

		/// <summary>
		/// Draws the component horizontally within the LiveSplit window.
		/// </summary>
		public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
		{
			FillBackground(g, state, HorizontalWidth, height);
			PrepareDraw(state);

			textComponent.DrawHorizontal(g, state, height, clipRegion);
		}

		/// <summary>
		/// Draws the component vertically within the LiveSplit window.
		/// </summary>
		public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
		{
			FillBackground(g, state, width, VerticalHeight);
			PrepareDraw(state);

			textComponent.DrawVertical(g, state, width, clipRegion);
		}

		/// <summary>
		/// Updates the component.
		/// </summary>
		public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
		{
			if (DeathCount != previousDeathCount)
			{
				textComponent.InformationValue = DeathCount.ToString();
				textComponent.Update(invalidator, state, width, height, mode);

				invalidator?.Invalidate(0, 0, width, height);

				previousDeathCount = DeathCount;
			}
		}

		/// <summary>
		/// Gets the settings control for the component.
		/// </summary>
		public Control GetSettingsControl(LayoutMode mode)
		{
			return null;
		}

		/// <summary>
		/// Saves settings in the given XML document.
		/// </summary>
		public XmlNode GetSettings(XmlDocument document)
		{
			return null;
		}

		/// <summary>
		/// Loads settings from the given XML node.
		/// </summary>
		public void SetSettings(XmlNode settings)
		{
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
		/// Prepares the text component for drawing.
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
		/// Disposes the component.
		/// </summary>
		public void Dispose()
		{
		}
	}
}
