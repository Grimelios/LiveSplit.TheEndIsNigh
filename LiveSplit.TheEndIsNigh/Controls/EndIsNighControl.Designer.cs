namespace LiveSplit.TheEndIsNigh.Controls
{
	partial class EndIsNighControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.defaultCategoryControl1 = new LiveSplit.TheEndIsNigh.Controls.DefaultCategoryControl();
			this.splitCollectionControl1 = new LiveSplit.TheEndIsNigh.Controls.SplitCollectionControl();
			this.SuspendLayout();
			// 
			// defaultCategoryControl1
			// 
			this.defaultCategoryControl1.Location = new System.Drawing.Point(4, 4);
			this.defaultCategoryControl1.Name = "defaultCategoryControl1";
			this.defaultCategoryControl1.Size = new System.Drawing.Size(207, 47);
			this.defaultCategoryControl1.TabIndex = 0;
			// 
			// splitCollectionControl1
			// 
			this.splitCollectionControl1.Location = new System.Drawing.Point(4, 58);
			this.splitCollectionControl1.Name = "splitCollectionControl1";
			this.splitCollectionControl1.Size = new System.Drawing.Size(370, 258);
			this.splitCollectionControl1.TabIndex = 1;
			// 
			// EndIsNighControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitCollectionControl1);
			this.Controls.Add(this.defaultCategoryControl1);
			this.Name = "EndIsNighControl";
			this.Size = new System.Drawing.Size(535, 408);
			this.ResumeLayout(false);

		}

		#endregion

		private DefaultCategoryControl defaultCategoryControl1;
		private SplitCollectionControl splitCollectionControl1;
	}
}
