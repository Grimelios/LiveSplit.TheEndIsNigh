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
	/// Partial class for the default category control.
	/// </summary>
	public partial class DefaultCategoryControl : UserControl
	{
		/// <summary>
		/// Constructs the class.
		/// </summary>
		public DefaultCategoryControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Reference to the split collection control. Used to load default splits.
		/// </summary>
		public SplitCollectionControl CollectionControl { get; set; }

		/// <summary>
		/// Called when the Friend% button is pressed.
		/// </summary>
		private void friendPercentButton_Click(object sender, EventArgs e)
		{
			LoadDefaultSplits("FriendPercent.json");
		}

		/// <summary>
		/// Called when the Any% button is pressed.
		/// </summary>
		private void anyPercentButton_Click(object sender, EventArgs e)
		{
			LoadDefaultSplits("AnyPercent.json");
		}

		/// <summary>
		/// Loads default splits from the given Json file.
		/// </summary>
		private void LoadDefaultSplits(string filename)
		{
			CollectionControl.SetDefaultSplits(JsonUtilities.Deserialize<Split[]>(filename));
		}
	}
}
