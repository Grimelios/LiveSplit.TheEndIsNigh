using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.TheEndIsNigh.Controls
{
	/// <summary>
	/// Partial class for the split collection control.
	/// </summary>
	public partial class SplitCollectionControl : UserControl
	{
		private const int SplitSpacing = 40;

		private ControlCollection splitControls;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitCollectionControl()
		{
			InitializeComponent();

			splitControls = splitPanel.Controls;
		}

		/// <summary>
		/// Called when the Add Split button is pressed.
		/// </summary>
		private void addSplitButton_Click(object sender, EventArgs e)
		{
			foreach (Control splitControl in splitControls)
			{
				splitControl.Location = splitControl.Location.Add(new Point(0, SplitSpacing));
			}

			splitControls.Add(new SplitControl());
			splitPanel.Height += SplitSpacing;
			addSplitButton.Location = new Point(addSplitButton.Location.X, splitPanel.Bottom);
		}
	}
}
