﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.TheEndIsNigh.Data;
using LiveSplit.TheEndIsNigh.Properties;

namespace LiveSplit.TheEndIsNigh.Controls
{
	/// <summary>
	/// Partial class for the main End Is Nigh control.
	/// </summary>
	public partial class EndIsNighControl : UserControl
	{
		private const int FontSize = 14;

		// Taken from http://stackoverflow.com/questions/556147/how-to-quickly-and-easily-embed-fonts-in-winforms-app-in-c-sharp.
		[DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

		private HelpForm helpForm;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public EndIsNighControl()
		{
			InitializeComponent();
			LoadFont();

			this.GetControl<DefaultCategoryControl>().CollectionControl = CollectionControl;
		}

		/// <summary>
		/// Reference to the split collection control. Used by several classes to update splits.
		/// </summary>
		public SplitCollectionControl CollectionControl => this.GetControl<SplitCollectionControl>();

		/// <summary>
		/// Reference to the settings control. Used to set the display checkbox on load.
		/// </summary>
		public SettingsControl SettingsControl => this.GetControl<SettingsControl>();

		/// <summary>
		/// Loads the The End font and applies it to the autosplitter label.
		/// </summary>
		private void LoadFont()
		{
			byte[] fontData = Resources.TheEnd;

			IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
			Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			PrivateFontCollection fontCollection = new PrivateFontCollection();

			uint dummy = 0;

			fontCollection.AddMemoryFont(fontPtr, fontData.Length);
			AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);

			Marshal.FreeCoTaskMem(fontPtr);

			autosplitterLabel.Font = new Font(fontCollection.Families[0], FontSize);
		}

		/// <summary>
		/// Called when the Help button is pressed.
		/// </summary>
		private void helpButton_Click(object sender, EventArgs e)
		{
			if (helpForm == null)
			{
				helpForm = new HelpForm();
				helpForm.Disposed += (o, args) =>
				{
					helpForm = null;
				};

				helpForm.Show();
			}
			else if (helpForm.Visible)
			{
				helpForm.Hide();
			}
			else
			{
				helpForm.Show();
			}
		}
	}
}
