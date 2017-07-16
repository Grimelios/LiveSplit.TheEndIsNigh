namespace LiveSplit.TheEndIsNigh.Controls
{
	partial class TestingForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.endIsNighControl1 = new LiveSplit.TheEndIsNigh.Controls.EndIsNighControl();
			this.SuspendLayout();
			// 
			// endIsNighControl1
			// 
			this.endIsNighControl1.Location = new System.Drawing.Point(13, 13);
			this.endIsNighControl1.Name = "endIsNighControl1";
			this.endIsNighControl1.Size = new System.Drawing.Size(535, 408);
			this.endIsNighControl1.TabIndex = 0;
			// 
			// TestingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 504);
			this.Controls.Add(this.endIsNighControl1);
			this.Name = "TestingForm";
			this.Text = "The End Is Nigh Autosplitter [Testing Form]";
			this.ResumeLayout(false);

		}

		#endregion

		private EndIsNighControl endIsNighControl1;
	}
}