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
		/// Split type for the control.
		/// </summary>
		public SplitTypes SplitType
		{
			get
			{
				int typeIndex = splitTypeComboBox.SelectedIndex;

				return typeIndex != -1 ? (SplitTypes)typeIndex : SplitTypes.Unassigned;
			}
		}

		/// <summary>
		/// Split data for the control (parsed based on split type).
		/// </summary>
		public object SplitData
		{
			get
			{
				SplitTypes splitType = SplitType;

				string data = splitType == SplitTypes.CartridgeCount || splitType == SplitTypes.TumorCount
					? dataCountTextbox.Text
					: splitDataComboBox.Text;

				return ParseData(splitType, splitDataComboBox.SelectedIndex, data);
			}
		}

		/// <summary>
		/// Parses split data based on the given type and raw string.
		/// </summary>
		private object ParseData(SplitTypes splitType, int dataIndex, string data)
		{
			switch (splitType)
			{
				case SplitTypes.BodyPart:
					return (BodyParts)dataIndex;

				case SplitTypes.CartridgeCount:
				case SplitTypes.TumorCount:
					return int.Parse(data);

				case SplitTypes.WorldEvent:
					return Enum.Parse(typeof(WorldEvents), RemoveSpaces(data));

				case SplitTypes.Zone:
					// Wall of Sorrow is the only string that won't correctly convert to an enumeration value when spaces are removed (due
					// to the lower-case o).
					return dataIndex == 4 ? Zones.WallOfSorrow : Enum.Parse(typeof(Zones), RemoveSpaces(data));
			}

			return null;
		}

		/// <summary>
		/// Removes spaces from the given string. Used to more easily parse enumeration values from human-readable strings.
		/// </summary>
		private string RemoveSpaces(string value)
		{
			return value.Replace(" ", "");
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
					splitDataComboBox.SelectedIndex = -1;
					splitDataComboBox.Visible = false;
					dataCountTextbox.Visible = true;

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

			dataCountTextbox.Visible = false;
		}

		/// <summary>
		/// Called when the Delete button is pressed.
		/// </summary>
		private void deleteButton_Click(object sender, EventArgs e)
		{
			parent.Remove(this);
		}

		/// <summary>
		/// Called when the Up button is pressed.
		/// </summary>
		private void upButton_Click(object sender, EventArgs e)
		{
			parent.MoveUp(this);
		}

		/// <summary>
		/// Called when the Down button is pressed.
		/// </summary>
		private void downButton_Click(object sender, EventArgs e)
		{
			parent.MoveDown(this);
		}
	}
}
