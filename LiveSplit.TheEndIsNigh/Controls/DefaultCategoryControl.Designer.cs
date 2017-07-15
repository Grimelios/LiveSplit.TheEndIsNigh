namespace LiveSplit.TheEndIsNigh.Controls
{
	partial class DefaultCategoryControl
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
			this.friendPercentButton = new System.Windows.Forms.Button();
			this.defaultCategoryLabel = new System.Windows.Forms.Label();
			this.anyPercentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// friendPercentButton
			// 
			this.friendPercentButton.Location = new System.Drawing.Point(3, 20);
			this.friendPercentButton.Name = "friendPercentButton";
			this.friendPercentButton.Size = new System.Drawing.Size(75, 23);
			this.friendPercentButton.TabIndex = 0;
			this.friendPercentButton.Text = "Friend%";
			this.friendPercentButton.UseVisualStyleBackColor = true;
			// 
			// defaultCategoryLabel
			// 
			this.defaultCategoryLabel.AutoSize = true;
			this.defaultCategoryLabel.Location = new System.Drawing.Point(4, 4);
			this.defaultCategoryLabel.Name = "defaultCategoryLabel";
			this.defaultCategoryLabel.Size = new System.Drawing.Size(46, 13);
			this.defaultCategoryLabel.TabIndex = 1;
			this.defaultCategoryLabel.Text = "Defaults";
			// 
			// anyPercentButton
			// 
			this.anyPercentButton.Location = new System.Drawing.Point(85, 20);
			this.anyPercentButton.Name = "anyPercentButton";
			this.anyPercentButton.Size = new System.Drawing.Size(75, 23);
			this.anyPercentButton.TabIndex = 2;
			this.anyPercentButton.Text = "Any%";
			this.anyPercentButton.UseVisualStyleBackColor = true;
			// 
			// DefaultCategoryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.anyPercentButton);
			this.Controls.Add(this.defaultCategoryLabel);
			this.Controls.Add(this.friendPercentButton);
			this.Name = "DefaultCategoryControl";
			this.Size = new System.Drawing.Size(207, 47);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button friendPercentButton;
		private System.Windows.Forms.Label defaultCategoryLabel;
		private System.Windows.Forms.Button anyPercentButton;
	}
}
