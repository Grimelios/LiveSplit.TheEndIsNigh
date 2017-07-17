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
using LiveSplit.TheEndIsNigh.Json;

namespace LiveSplit.TheEndIsNigh.Controls
{
	/// <summary>
	/// Partial class for the split collection control.
	/// </summary>
	public partial class SplitCollectionControl : UserControl
	{
		private const int SplitSpacing = 30;

		private Point spacing;
		private ControlCollection splitControls;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitCollectionControl()
		{
			InitializeComponent();

			spacing = new Point(0, SplitSpacing);
			splitControls = splitPanel.Controls;
		}

		/// <summary>
		/// Reference to the split collection. The collection's splits are updated directly from this control.
		/// </summary>
		public SplitCollection SplitCollection { get; set; }

		/// <summary>
		/// Called when the Add Split button is pressed.
		/// </summary>
		private void addSplitButton_Click(object sender, EventArgs e)
		{
			SplitControl newSplit = new SplitControl(this);

			if (splitControls.Count > 0)
			{
				newSplit.Location = splitControls[splitControls.Count - 1].Location.Add(spacing);
			}

			splitControls.Add(newSplit);
			splitPanel.Height += SplitSpacing;
		}

		/// <summary>
		/// Called when the Save Splits button is pressed.
		/// </summary>
		private void saveSplitsButton_Click(object sender, EventArgs e)
		{
			Split[] splits = new Split[splitControls.Count];

			for (int i = 0; i < splits.Length; i++)
			{
				SplitControl control = (SplitControl)splitControls[i];
				splits[i] = new Split(control.SplitType, control.SplitData);
			}

			//SplitCollection.Splits = splits;

			JsonUtilities.Serialize(splits, "UserSplits.json");
		}

		/// <summary>
		/// Removes the given split control from the panel's collection.
		/// </summary>
		public void Remove(SplitControl control)
		{
			int index = splitControls.IndexOf(control);

			splitControls.RemoveAt(index);

			for (int i = index; i < splitControls.Count; i++)
			{
				Control toMove = splitControls[i];
				toMove.Location = toMove.Location.Subtract(spacing);
			}
		}
	}
}
