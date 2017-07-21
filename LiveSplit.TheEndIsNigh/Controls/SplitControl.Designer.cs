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
			this.dataCountTextbox = new System.Windows.Forms.TextBox();
			this.xTextbox = new System.Windows.Forms.TextBox();
			this.xLabel = new System.Windows.Forms.Label();
			this.yLabel = new System.Windows.Forms.Label();
			this.yTextbox = new System.Windows.Forms.TextBox();
			this.indexLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// splitTypeComboBox
			// 
			this.splitTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.splitTypeComboBox.FormattingEnabled = true;
			this.splitTypeComboBox.Items.AddRange(new object[] {
            "Body Part",
            "Cartridge Count",
            "Future Completion",
            "Level",
            "Tumor Count",
            "World Event",
            "Zone"});
			this.splitTypeComboBox.Location = new System.Drawing.Point(25, 4);
			this.splitTypeComboBox.Name = "splitTypeComboBox";
			this.splitTypeComboBox.Size = new System.Drawing.Size(121, 21);
			this.splitTypeComboBox.TabIndex = 0;
			this.splitTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.splitTypeComboBox_SelectedIndexChanged);
			// 
			// upButton
			// 
			this.upButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Up;
			this.upButton.Location = new System.Drawing.Point(280, 2);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(36, 23);
			this.upButton.TabIndex = 1;
			this.upButton.UseVisualStyleBackColor = true;
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// downButton
			// 
			this.downButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Down;
			this.downButton.Location = new System.Drawing.Point(322, 2);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(36, 23);
			this.downButton.TabIndex = 2;
			this.downButton.UseVisualStyleBackColor = true;
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Delete;
			this.deleteButton.Location = new System.Drawing.Point(364, 2);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(36, 23);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// splitDataComboBox
			// 
			this.splitDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.splitDataComboBox.FormattingEnabled = true;
			this.splitDataComboBox.Location = new System.Drawing.Point(153, 4);
			this.splitDataComboBox.Name = "splitDataComboBox";
			this.splitDataComboBox.Size = new System.Drawing.Size(121, 21);
			this.splitDataComboBox.TabIndex = 4;
			this.splitDataComboBox.Visible = false;
			this.splitDataComboBox.SelectedIndexChanged += new System.EventHandler(this.splitDataComboBox_SelectedIndexChanged);
			// 
			// dataCountTextbox
			// 
			this.dataCountTextbox.Location = new System.Drawing.Point(153, 4);
			this.dataCountTextbox.MaxLength = 3;
			this.dataCountTextbox.Name = "dataCountTextbox";
			this.dataCountTextbox.Size = new System.Drawing.Size(120, 20);
			this.dataCountTextbox.TabIndex = 5;
			this.dataCountTextbox.Visible = false;
			this.dataCountTextbox.TextChanged += new System.EventHandler(this.dataCountTextbox_TextChanged);
			// 
			// xTextbox
			// 
			this.xTextbox.Location = new System.Drawing.Point(170, 4);
			this.xTextbox.MaxLength = 3;
			this.xTextbox.Name = "xTextbox";
			this.xTextbox.Size = new System.Drawing.Size(40, 20);
			this.xTextbox.TabIndex = 6;
			this.xTextbox.Visible = false;
			this.xTextbox.TextChanged += new System.EventHandler(this.xTextbox_TextChanged);
			// 
			// xLabel
			// 
			this.xLabel.AutoSize = true;
			this.xLabel.Location = new System.Drawing.Point(153, 7);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(17, 13);
			this.xLabel.TabIndex = 7;
			this.xLabel.Text = "X:";
			this.xLabel.Visible = false;
			// 
			// yLabel
			// 
			this.yLabel.AutoSize = true;
			this.yLabel.Location = new System.Drawing.Point(216, 7);
			this.yLabel.Name = "yLabel";
			this.yLabel.Size = new System.Drawing.Size(17, 13);
			this.yLabel.TabIndex = 8;
			this.yLabel.Text = "Y:";
			this.yLabel.Visible = false;
			// 
			// yTextbox
			// 
			this.yTextbox.Location = new System.Drawing.Point(233, 4);
			this.yTextbox.MaxLength = 2;
			this.yTextbox.Name = "yTextbox";
			this.yTextbox.Size = new System.Drawing.Size(40, 20);
			this.yTextbox.TabIndex = 9;
			this.yTextbox.Visible = false;
			this.yTextbox.TextChanged += new System.EventHandler(this.yTextbox_TextChanged);
			// 
			// indexLabel
			// 
			this.indexLabel.AutoSize = true;
			this.indexLabel.Location = new System.Drawing.Point(3, 8);
			this.indexLabel.Name = "indexLabel";
			this.indexLabel.Size = new System.Drawing.Size(22, 13);
			this.indexLabel.TabIndex = 10;
			this.indexLabel.Text = "10.";
			// 
			// SplitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.indexLabel);
			this.Controls.Add(this.yTextbox);
			this.Controls.Add(this.yLabel);
			this.Controls.Add(this.xLabel);
			this.Controls.Add(this.xTextbox);
			this.Controls.Add(this.dataCountTextbox);
			this.Controls.Add(this.splitDataComboBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.downButton);
			this.Controls.Add(this.upButton);
			this.Controls.Add(this.splitTypeComboBox);
			this.Name = "SplitControl";
			this.Size = new System.Drawing.Size(403, 29);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox splitTypeComboBox;
		private System.Windows.Forms.Button upButton;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ComboBox splitDataComboBox;
		private System.Windows.Forms.TextBox dataCountTextbox;
		private System.Windows.Forms.TextBox xTextbox;
		private System.Windows.Forms.Label xLabel;
		private System.Windows.Forms.Label yLabel;
		private System.Windows.Forms.TextBox yTextbox;
		private System.Windows.Forms.Label indexLabel;
	}
}
