namespace LiveSplit.TheEndIsNigh.Controls
{
	partial class SplitControl
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
			this.splitTypeComboBox = new System.Windows.Forms.ComboBox();
			this.upButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.splitDataComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// splitTypeComboBox
			// 
			this.splitTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.splitTypeComboBox.FormattingEnabled = true;
			this.splitTypeComboBox.Items.AddRange(new object[] {
            "Body Part",
            "Cartridge",
            "Tumor Count",
            "World Event",
            "Zone"});
			this.splitTypeComboBox.Location = new System.Drawing.Point(4, 4);
			this.splitTypeComboBox.Name = "splitTypeComboBox";
			this.splitTypeComboBox.Size = new System.Drawing.Size(121, 21);
			this.splitTypeComboBox.TabIndex = 0;
			this.splitTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.splitTypeComboBox_SelectedIndexChanged);
			// 
			// upButton
			// 
			this.upButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Up;
			this.upButton.Location = new System.Drawing.Point(262, 4);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(36, 23);
			this.upButton.TabIndex = 1;
			this.upButton.UseVisualStyleBackColor = true;
			// 
			// downButton
			// 
			this.downButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Down;
			this.downButton.Location = new System.Drawing.Point(304, 4);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(36, 23);
			this.downButton.TabIndex = 2;
			this.downButton.UseVisualStyleBackColor = true;
			// 
			// deleteButton
			// 
			this.deleteButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Delete;
			this.deleteButton.Location = new System.Drawing.Point(346, 4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(36, 23);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// splitDataComboBox
			// 
			this.splitDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.splitDataComboBox.FormattingEnabled = true;
			this.splitDataComboBox.Location = new System.Drawing.Point(132, 4);
			this.splitDataComboBox.Name = "splitDataComboBox";
			this.splitDataComboBox.Size = new System.Drawing.Size(121, 21);
			this.splitDataComboBox.TabIndex = 4;
			this.splitDataComboBox.Visible = false;
			// 
			// SplitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitDataComboBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.downButton);
			this.Controls.Add(this.upButton);
			this.Controls.Add(this.splitTypeComboBox);
			this.Name = "SplitControl";
			this.Size = new System.Drawing.Size(526, 127);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox splitTypeComboBox;
		private System.Windows.Forms.Button upButton;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ComboBox splitDataComboBox;
	}
}
