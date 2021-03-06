﻿using System;
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
	/// Partial class for the default category control.
	/// </summary>
	public partial class DefaultCategoryControl : UserControl
	{
		private DefaultSplits defaultSplits;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public DefaultCategoryControl()
		{
			defaultSplits = new DefaultSplits();

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
			CollectionControl.SetSplits(defaultSplits.FriendPercent);
		}

		/// <summary>
		/// Called when the Any% button is pressed.
		/// </summary>
		private void anyPercentButton_Click(object sender, EventArgs e)
		{
			CollectionControl.SetSplits(defaultSplits.AnyPercent);
		}
	}
}
