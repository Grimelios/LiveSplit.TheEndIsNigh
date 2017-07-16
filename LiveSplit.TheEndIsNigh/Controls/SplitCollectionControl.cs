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
		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitCollectionControl()
		{
			InitializeComponent();

			Controls.Add(new SplitControl()
			{
				Location = new Point(0, 100)
			});
		}
	}
}
