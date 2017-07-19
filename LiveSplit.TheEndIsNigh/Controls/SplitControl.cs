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
			bodyPartItems = new []
			{
				"Head",
				"Heart",
				"Body"
			};

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
				"Nevermore"
			};
		}

		private SplitCollectionControl parent;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitControl(SplitCollectionControl parent, int index)
		{
			this.parent = parent;

			InitializeComponent();
			Index = index;
		}

		/// <summary>
		/// Constructs the class with split type and data given directly.
		/// </summary>
		public SplitControl(SplitCollectionControl parent, int index, SplitTypes splitType, object splitData) :
			this(parent, index)
		{
			SplitType = splitType;
			SplitData = splitData;
		}

		/// <summary>
		/// Updates the index label for the control.
		/// </summary>
		public int Index
		{
			set { indexLabel.Text = value + "."; }
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

			private set { splitTypeComboBox.SelectedIndex = (int)value; }
		}

		/// <summary>
		/// Split data for the control (parsed based on split type).
		/// </summary>
		public object SplitData
		{
			get
			{
				return ParseData(SplitType);
			}

			private set
			{
				SplitTypes splitType = SplitType;

				int selectedIndex = IsEnumeratedType(splitType) ? (int)value : -1;

				switch (splitType)
				{
					case SplitTypes.BodyPart:
						RepopulateData(bodyPartItems, selectedIndex);
						break;

					case SplitTypes.CartridgeCount:
					case SplitTypes.TumorCount:
						dataCountTextbox.Visible = true;
						dataCountTextbox.Text = value.ToString();

						break;

					case SplitTypes.Level:
						ToggleLevelItems(true);

						Point data = (Point)value;

						xTextbox.Text = data.X.ToString();
						yTextbox.Text = data.Y.ToString();

						break;

					case SplitTypes.WorldEvent:
						RepopulateData(worldEventItems, selectedIndex);
						break;

					case SplitTypes.Zone:
						RepopulateData(zoneItems, selectedIndex);
						break;
				}
			}
		}

		/// <summary>
		/// Parses split data based on the given data.
		/// </summary>
		private object ParseData(SplitTypes splitType)
		{
			int dataIndex = splitDataComboBox.SelectedIndex;

			if (IsEnumeratedType(splitType) && dataIndex == -1)
			{
				return null;
			}

			switch (splitType)
			{
				case SplitTypes.BodyPart:
					return (BodyParts)dataIndex;

				case SplitTypes.CartridgeCount:
				case SplitTypes.TumorCount:
					int result;

					if (int.TryParse(dataCountTextbox.Text, out result))
					{
						return result;
					}

					return null;

				case SplitTypes.Level:
					int x;
					int y;

					if (int.TryParse(xTextbox.Text, out x) && int.TryParse(yTextbox.Text, out y))
					{
						return new Point(x, y);
					}

					return null;

				case SplitTypes.WorldEvent:
					return Enum.Parse(typeof(WorldEvents), RemoveSpaces(splitDataComboBox.Text));

				case SplitTypes.Zone:
					// Wall of Sorrow is the only string that won't correctly convert to an enumeration value when spaces are removed (due
					// to the lower-case o).
					return dataIndex == 4 ? Zones.WallOfSorrow : Enum.Parse(typeof(Zones), RemoveSpaces(splitDataComboBox.Text));
			}

			return null;
		}

		/// <summary>
		/// Checks whether the given split type is an enumerated type.
		/// </summary>
		private bool IsEnumeratedType(SplitTypes type)
		{
			return type == SplitTypes.BodyPart || type == SplitTypes.WorldEvent || type == SplitTypes.Zone;
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
					HideDataDropdown();
					ToggleLevelItems(false);

					// The count textbox will already be clear at this point.
					dataCountTextbox.Visible = true;

					break;

				case SplitTypes.Level:
					HideDataDropdown();
					ToggleCountTextbox(false);
					ToggleLevelItems(true);

					break;

				case SplitTypes.WorldEvent:
					RepopulateData(worldEventItems);
					break;

				case SplitTypes.Zone:
					RepopulateData(zoneItems);
					break;
			}

			parent.SaveSplits(false);
		}

		/// <summary>
		/// Called when the selected index changes on the data combo box.
		/// </summary>
		private void splitDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			parent.SaveSplits(false);
		}

		/// <summary>
		/// Called when the data textbox's value changes.
		/// </summary>
		private void dataCountTextbox_TextChanged(object sender, EventArgs e)
		{
			parent.SaveSplits(false);
		}

		/// <summary>
		/// Called when the X textbox's value changes.
		/// </summary>
		private void xTextbox_TextChanged(object sender, EventArgs e)
		{
			parent.SaveSplits(false);
		}

		/// <summary>
		/// Called when the Y textbox's value changes.
		/// </summary>
		private void yTextbox_TextChanged(object sender, EventArgs e)
		{
			parent.SaveSplits(false);
		}

		/// <summary>
		/// Clears and hides the data dropdown.
		/// </summary>
		private void HideDataDropdown()
		{
			splitDataComboBox.Items.Clear();
			splitDataComboBox.Visible = false;
		}

		/// <summary>
		/// Repopulates items in the split data combo box.
		/// </summary>
		private void RepopulateData(string[] items, int selectedIndex = -1)
		{
			// The data dropdown will have already been cleared by this point.
			splitDataComboBox.Items.AddRange(items);
			splitDataComboBox.Visible = true;

			if (selectedIndex != -1)
			{
				splitDataComboBox.SelectedIndex = selectedIndex;
			}

			ToggleCountTextbox(false);
			ToggleLevelItems(false);
		}

		/// <summary>
		/// Toggles visibility of the count textbox. Also clears the textbox's value if invisible.
		/// </summary>
		private void ToggleCountTextbox(bool visible)
		{
			dataCountTextbox.Visible = visible;

			if (!visible)
			{
				dataCountTextbox.Text = "";
			}
		}

		/// <summary>
		/// Toggles visibility of the level controls (X and Y labels and textboxes).
		/// </summary>
		private void ToggleLevelItems(bool visible)
		{
			xLabel.Visible = visible;
			yLabel.Visible = visible;
			xTextbox.Visible = visible;
			yTextbox.Visible = visible;

			if (!visible)
			{
				xTextbox.Text = "";
				yTextbox.Text = "";
			}
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

		/// <summary>
		/// Toggles the Up button.
		/// </summary>
		public void ToggleUp(bool enabled)
		{
			upButton.Enabled = enabled;
		}

		/// <summary>
		/// Toggles the Down button.
		/// </summary>
		public void ToggleDown(bool enabled)
		{
			downButton.Enabled = enabled;
		}
	}
}
