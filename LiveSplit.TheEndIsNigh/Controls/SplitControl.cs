using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.TheEndIsNigh.Data;

namespace LiveSplit.TheEndIsNigh.Controls
{
	/// <summary>
	/// Partial class for the split control.
	/// </summary>
	public partial class SplitControl : UserControl
	{
		private static string[] bodyPartItems;
		private static string[] cartridgeItems;
		private static string[] worldEventItems;
		private static string[] zoneItems;

		/// <summary>
		/// Static initializer for the class.
		/// </summary>
		static SplitControl()
		{
			bodyPartItems = Enum.GetNames(typeof(BodyParts));

			cartridgeItems = new []
			{
				""
			};

			worldEventItems = new []
			{
				"Friend",
				"Escape"
			};

			zoneItems = new []
			{
				// The past.
				"The End",
				"Arid Flats",
				"Overflow",
				"The Split",
				"Wall of Sorrow",
				"SS Exodus",
				"Retrograde",
				"The Machine",
				"The Hollows",
				"Golgotha",

				// The future.
				"Anguish",
				"Gloom",
				"Blight",
				"Ruin",
				"Acceptance",
				"Nevermore"
			};
		}

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Called when the selected index changes for the split type dropdown.
		/// </summary>
		private void splitTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((SplitTypes)splitTypeComboBox.SelectedIndex)
			{
				case SplitTypes.BodyPart:
					RepopulateData(bodyPartItems);
					break;

				case SplitTypes.Cartridge:
					RepopulateData(cartridgeItems);
					break;

				case SplitTypes.TumorCount:
					splitDataComboBox.Items.Clear();
					splitDataComboBox.Visible = false;
					tumorCountTextbox.Visible = true;

					break;

				case SplitTypes.WorldEvent:
					RepopulateData(worldEventItems);
					break;

				case SplitTypes.Zone:
					RepopulateData(zoneItems);
					break;
			}
		}

		/// <summary>
		/// Repopulates items in the split data combo box.
		/// </summary>
		private void RepopulateData(string[] items)
		{
			splitDataComboBox.Items.Clear();
			splitDataComboBox.Items.AddRange(items);
			splitDataComboBox.Visible = true;

			tumorCountTextbox.Visible = false;
		}
	}
}
