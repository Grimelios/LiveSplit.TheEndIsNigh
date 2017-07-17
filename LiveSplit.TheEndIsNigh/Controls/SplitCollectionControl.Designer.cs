namespace LiveSplit.TheEndIsNigh.Controls
{
	partial class SplitCollectionControl
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
			this.splitTypeLabel = new System.Windows.Forms.Label();
			this.splitDataLabel = new System.Windows.Forms.Label();
			this.addSplitButton = new System.Windows.Forms.Button();
			this.splitPanel = new System.Windows.Forms.Panel();
			this.saveSplitsButton = new System.Windows.Forms.Button();
			this.splitsBox = new System.Windows.Forms.GroupBox();
			this.splitsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitTypeLabel
			// 
			this.splitTypeLabel.AutoSize = true;
			this.splitTypeLabel.Location = new System.Drawing.Point(10, 54);
			this.splitTypeLabel.Name = "splitTypeLabel";
			this.splitTypeLabel.Size = new System.Drawing.Size(54, 13);
			this.splitTypeLabel.TabIndex = 0;
			this.splitTypeLabel.Text = "Split Type";
			// 
			// splitDataLabel
			// 
			this.splitDataLabel.AutoSize = true;
			this.splitDataLabel.Location = new System.Drawing.Point(137, 54);
			this.splitDataLabel.Name = "splitDataLabel";
			this.splitDataLabel.Size = new System.Drawing.Size(53, 13);
			this.splitDataLabel.TabIndex = 1;
			this.splitDataLabel.Text = "Split Data";
			// 
			// addSplitButton
			// 
			this.addSplitButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Add;
			this.addSplitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addSplitButton.Location = new System.Drawing.Point(6, 19);
			this.addSplitButton.Name = "addSplitButton";
			this.addSplitButton.Size = new System.Drawing.Size(75, 23);
			this.addSplitButton.TabIndex = 2;
			this.addSplitButton.Text = "Add Split";
			this.addSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addSplitButton.UseVisualStyleBackColor = true;
			this.addSplitButton.Click += new System.EventHandler(this.addSplitButton_Click);
			// 
			// splitPanel
			// 
			this.splitPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitPanel.AutoScroll = true;
			this.splitPanel.Location = new System.Drawing.Point(6, 70);
			this.splitPanel.Name = "splitPanel";
			this.splitPanel.Size = new System.Drawing.Size(466, 299);
			this.splitPanel.TabIndex = 3;
			// 
			// saveSplitsButton
			// 
			this.saveSplitsButton.Location = new System.Drawing.Point(87, 19);
			this.saveSplitsButton.Name = "saveSplitsButton";
			this.saveSplitsButton.Size = new System.Drawing.Size(75, 23);
			this.saveSplitsButton.TabIndex = 4;
			this.saveSplitsButton.Text = "Save Splits";
			this.saveSplitsButton.UseVisualStyleBackColor = true;
			this.saveSplitsButton.Click += new System.EventHandler(this.saveSplitsButton_Click);
			// 
			// splitsBox
			// 
			this.splitsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitsBox.Controls.Add(this.addSplitButton);
			this.splitsBox.Controls.Add(this.splitPanel);
			this.splitsBox.Controls.Add(this.saveSplitsButton);
			this.splitsBox.Controls.Add(this.splitDataLabel);
			this.splitsBox.Controls.Add(this.splitTypeLabel);
			this.splitsBox.Location = new System.Drawing.Point(3, 3);
			this.splitsBox.Name = "splitsBox";
			this.splitsBox.Size = new System.Drawing.Size(478, 375);
			this.splitsBox.TabIndex = 5;
			this.splitsBox.TabStop = false;
			this.splitsBox.Text = "Splits";
			// 
			// SplitCollectionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitsBox);
			this.Name = "SplitCollectionControl";
			this.Size = new System.Drawing.Size(484, 381);
			this.splitsBox.ResumeLayout(false);
			this.splitsBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label splitTypeLabel;
		private System.Windows.Forms.Label splitDataLabel;
		private System.Windows.Forms.Button addSplitButton;
		private System.Windows.Forms.Panel splitPanel;
		private System.Windows.Forms.Button saveSplitsButton;
		private System.Windows.Forms.GroupBox splitsBox;
	}
}
