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
	/// Partial class for the settings control.
	/// </summary>
	public partial class SettingsControl : UserControl
	{
		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SettingsControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Reference to the settings object for the component.
		/// </summary>
		public EndIsNighSettings Settings { get; set; }

		/// <summary>
		/// Sets the value of the death count checkbox.
		/// </summary>
		public bool DeathCheckbox
		{
			set => deathCountCheckbox.Checked = value;
		}

		public bool FileTimeCheckbox
		{
			set => fileTimeCheckbox.Checked = value;
		}

		/// <summary>
		/// Called when the death count checkbox changes.
		/// </summary>
		private void deathCountCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			Settings.DisplayEnabled = deathCountCheckbox.Checked;
		}

		/// <summary>
		/// Called when the file time checkbox changes.
		/// </summary>
		private void fileTimeCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			Settings.MatchFileTime = fileTimeCheckbox.Checked;
		}
	}
}
