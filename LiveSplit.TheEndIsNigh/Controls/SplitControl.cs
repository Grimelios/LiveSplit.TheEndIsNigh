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
		private static string[] worldEventItems;
		private static string[] zoneItems;

		/// <summary>
		/// Static initializer for the class.
		/// </summary>
		static SplitControl()
		{
			bodyPartItems = Enum.GetNames(typeof(BodyParts));

			worldEventItems = new []
			{
				"Friend",
				"Escape",
				"End 1",
				"End 2"
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

		private SplitCollectionControl parent;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitControl(SplitCollectionControl parent)
		{
			this.parent = parent;

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

				case SplitTypes.CartridgeCount:
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

		/// <summary>
		/// Called when the Delete button is pressed.
		/// </summary>
		private void deleteButton_Click(object sender, EventArgs e)
		{
			parent.Remove(this);
		}
	}
}
