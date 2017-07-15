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

		/// <summary>
		/// Constructs the component.
		/// </summary>
		public EndIsNighComponent()
		{
			settingsControl = new EndIsNighControl();
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
			}
		}

		/// <summary>
		/// Sets component settings from the given XML node.
		/// </summary>
		public void SetSettings(XmlNode settings)
		{
		}

		/// <summary>
		/// Returns an XML settings node for the component.
		/// </summary>
		public XmlNode GetSettings(XmlDocument document)
		{
			return null;
		}

		/// <summary>
		/// Disposes the component.
		/// </summary>
		public void Dispose()
		{
		}
	}
}
