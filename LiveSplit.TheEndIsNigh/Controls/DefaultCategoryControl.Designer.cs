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
			this.anyPercentButton = new System.Windows.Forms.Button();
			this.defaultsBox = new System.Windows.Forms.GroupBox();
			this.defaultsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// friendPercentButton
			// 
			this.friendPercentButton.Location = new System.Drawing.Point(6, 19);
			this.friendPercentButton.Name = "friendPercentButton";
			this.friendPercentButton.Size = new System.Drawing.Size(75, 23);
			this.friendPercentButton.TabIndex = 0;
			this.friendPercentButton.Text = "Friend%";
			this.friendPercentButton.UseVisualStyleBackColor = true;
			this.friendPercentButton.Click += new System.EventHandler(this.friendPercentButton_Click);
			// 
			// anyPercentButton
			// 
			this.anyPercentButton.Location = new System.Drawing.Point(87, 19);
			this.anyPercentButton.Name = "anyPercentButton";
			this.anyPercentButton.Size = new System.Drawing.Size(75, 23);
			this.anyPercentButton.TabIndex = 2;
			this.anyPercentButton.Text = "Any%";
			this.anyPercentButton.UseVisualStyleBackColor = true;
			this.anyPercentButton.Click += new System.EventHandler(this.anyPercentButton_Click);
			// 
			// defaultsBox
			// 
			this.defaultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.defaultsBox.Controls.Add(this.friendPercentButton);
			this.defaultsBox.Controls.Add(this.anyPercentButton);
			this.defaultsBox.Location = new System.Drawing.Point(3, 3);
			this.defaultsBox.Name = "defaultsBox";
			this.defaultsBox.Size = new System.Drawing.Size(471, 49);
			this.defaultsBox.TabIndex = 3;
			this.defaultsBox.TabStop = false;
			this.defaultsBox.Text = "Defaults";
			// 
			// DefaultCategoryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.defaultsBox);
			this.Name = "DefaultCategoryControl";
			this.Size = new System.Drawing.Size(477, 55);
			this.defaultsBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button friendPercentButton;
		private System.Windows.Forms.Button anyPercentButton;
		private System.Windows.Forms.GroupBox defaultsBox;
	}
}
