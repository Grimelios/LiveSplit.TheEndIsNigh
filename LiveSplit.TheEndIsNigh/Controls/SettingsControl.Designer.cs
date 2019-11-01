namespace LiveSplit.TheEndIsNigh.Controls
{
	partial class SettingsControl
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
			this.settingsBox = new System.Windows.Forms.GroupBox();
			this.deathCountCheckbox = new System.Windows.Forms.CheckBox();
			this.fileTimeCheckbox = new System.Windows.Forms.CheckBox();
			this.settingsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingsBox
			// 
			this.settingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsBox.Controls.Add(this.fileTimeCheckbox);
			this.settingsBox.Controls.Add(this.deathCountCheckbox);
			this.settingsBox.Location = new System.Drawing.Point(4, 4);
			this.settingsBox.Name = "settingsBox";
			this.settingsBox.Size = new System.Drawing.Size(355, 43);
			this.settingsBox.TabIndex = 0;
			this.settingsBox.TabStop = false;
			this.settingsBox.Text = "Settings";
			// 
			// deathCountCheckbox
			// 
			this.deathCountCheckbox.AutoSize = true;
			this.deathCountCheckbox.Location = new System.Drawing.Point(7, 20);
			this.deathCountCheckbox.Name = "deathCountCheckbox";
			this.deathCountCheckbox.Size = new System.Drawing.Size(120, 17);
			this.deathCountCheckbox.TabIndex = 0;
			this.deathCountCheckbox.Text = "Display death count";
			this.deathCountCheckbox.UseVisualStyleBackColor = true;
			this.deathCountCheckbox.CheckedChanged += new System.EventHandler(this.deathCountCheckbox_CheckedChanged);
			// 
			// fileTimeCheckbox
			// 
			this.fileTimeCheckbox.AutoSize = true;
			this.fileTimeCheckbox.Location = new System.Drawing.Point(133, 20);
			this.fileTimeCheckbox.Name = "fileTimeCheckbox";
			this.fileTimeCheckbox.Size = new System.Drawing.Size(94, 17);
			this.fileTimeCheckbox.TabIndex = 1;
			this.fileTimeCheckbox.Text = "Match file time";
			this.fileTimeCheckbox.UseVisualStyleBackColor = true;
			this.fileTimeCheckbox.CheckedChanged += new System.EventHandler(this.fileTimeCheckbox_CheckedChanged);
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.settingsBox);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(362, 50);
			this.settingsBox.ResumeLayout(false);
			this.settingsBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox settingsBox;
		private System.Windows.Forms.CheckBox deathCountCheckbox;
		private System.Windows.Forms.CheckBox fileTimeCheckbox;
	}
}
