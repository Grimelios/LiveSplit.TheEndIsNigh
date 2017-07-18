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
	/// Partial class for the split collection control.
	/// </summary>
	public partial class SplitCollectionControl : UserControl
	{
		private const int SplitSpacing = 30;
		private const int StatusLifetime = 3000;

		private Point spacing;
		private Timer statusTimer;
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
				SplitControl control = (SplitControl)splitControls.Last();

				newSplit.Location = control.Location.Add(spacing);
				control.ToggleDown(true);
			}

			newSplit.ToggleUp(splitControls.Count > 0);
			newSplit.ToggleDown(false);
			splitControls.Add(newSplit);

			UpdateCountLabel();
		}

		/// <summary>
		/// Called when the Save Splits button is pressed.
		/// </summary>
		private void saveSplitsButton_Click(object sender, EventArgs e)
		{
			SaveSplits(true);
		}

		/// <summary>
		/// Saves the current collection of splits (if valid).
		/// </summary>
		public void SaveSplits(bool updateStatus)
		{
			// This check prevents accidentialy wiping all splits on load.
			if (splitControls.Count == 0)
			{
				return;
			}

			Split[] splits = new Split[splitControls.Count];

			for (int i = 0; i < splits.Length; i++)
			{
				SplitControl control = (SplitControl)splitControls[i];
				splits[i] = new Split(control.SplitType, control.SplitData);
			}

			int invalidIndex;

			if (ValidateSplits(splits, out invalidIndex))
			{
				SplitCollection.Splits = splits;

				if (updateStatus)
				{
					UpdateStatusLabel("Splits saved.", Color.Green);
				}
			}
			else if (updateStatus)
			{
				UpdateStatusLabel($"Invalid split (line {invalidIndex + 1}).", Color.Red);
			}
		}

		/// <summary>
		/// Sets splits based on the given array.
		/// </summary>
		public void SetSplits(Split[] splits)
		{
			// A zero-length array indicates loading settings where the user had previously not set up any splits.
			if (splits.Length == 0)
			{
				return;
			}

			splitControls.Clear();

			for (int i = 0; i < splits.Length; i++)
			{
				Split split = splits[i];

				splitControls.Add(new SplitControl(this, split.Type, split.Data)
				{
					Location = new Point(0, SplitSpacing * i)
				});
			}

			((SplitControl)splitControls[0]).ToggleUp(false);
			((SplitControl)splitControls.Last()).ToggleDown(false);

			SplitCollection.Splits = splits;
			UpdateCountLabel();
		}

		/// <summary>
		/// Removes the given split control from the panel's collection.
		/// </summary>
		public void Remove(SplitControl control)
		{
			int index = splitControls.IndexOf(control);

			splitControls.RemoveAt(index);

			if (splitControls.Count > 0)
			{
				for (int i = index; i < splitControls.Count; i++)
				{
					Control toMove = splitControls[i];
					toMove.Location = toMove.Location.Subtract(spacing);
				}

				if (index == 0)
				{
					((SplitControl)splitControls[index]).ToggleUp(false);
				}

				if (index == splitControls.Count)
				{
					((SplitControl)splitControls.Last()).ToggleDown(false);
				}
			}

			UpdateCountLabel();
			SaveSplits(false);
		}

		/// <summary>
		/// Moves the given control up.
		/// </summary>
		public void MoveUp(SplitControl control)
		{
			int index = splitControls.IndexOf(control);

			Swap(index, index - 1);
			SaveSplits(false);
		}

		/// <summary>
		/// Moves the given control down.
		/// </summary>
		public void MoveDown(SplitControl control)
		{
			int index = splitControls.IndexOf(control);

			Swap(index, index + 1);
			SaveSplits(false);
		}

		/// <summary>
		/// Swaps the two split controls with the given indices.
		/// </summary>
		private void Swap(int index1, int index2)
		{
			SplitControl control1 = (SplitControl)splitControls[index1];
			SplitControl control2 = (SplitControl)splitControls[index2];

			Point temporaryLocation = control1.Location;
			control1.Location = control2.Location;
			control2.Location = temporaryLocation;

			splitControls.SetChildIndex(control1, index2);
			splitControls.SetChildIndex(control2, index1);

			ToggleButtons(control1, index2);
			ToggleButtons(control2, index1);
		}

		/// <summary>
		/// Toggles up/down buttons on the given split control based on the given index.
		/// </summary>
		private void ToggleButtons(SplitControl control, int index)
		{
			control.ToggleUp(index > 0);
			control.ToggleDown(index < splitControls.Count - 1);
		}

		/// <summary>
		/// Validates whether the current list of splits is valid.
		/// </summary>
		private bool ValidateSplits(Split[] splits, out int invalidIndex)
		{
			for (int i = 0; i < splits.Length; i++)
			{
				Split split = splits[i];

				if (split.Type == SplitTypes.Unassigned || split.Data == null)
				{
					invalidIndex = i;

					return false;
				}
			}

			invalidIndex = -1;

			return true;
		}

		/// <summary>
		/// Updates the text in the split count label.
		/// </summary>
		private void UpdateCountLabel()
		{
			splitCountLabel.Text = splitControls.Count + " " + (splitControls.Count == 1 ? "split" : "splits");
		}

		/// <summary>
		/// Updates the status label with the given text and color.
		/// </summary>
		private void UpdateStatusLabel(string text, Color color)
		{
			statusLabel.Text = text;
			statusLabel.ForeColor = color;
			statusLabel.Visible = true;

			statusTimer?.Stop();
			statusTimer = new Timer
			{
				Interval = StatusLifetime
			};

			statusTimer.Tick += (sender, e) =>
			{
				statusLabel.Visible = false;
				statusTimer.Stop();
			};

			statusTimer.Start();
		}
	}
}
