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
			this.SuspendLayout();
			// 
			// splitTypeLabel
			// 
			this.splitTypeLabel.AutoSize = true;
			this.splitTypeLabel.Location = new System.Drawing.Point(4, 4);
			this.splitTypeLabel.Name = "splitTypeLabel";
			this.splitTypeLabel.Size = new System.Drawing.Size(54, 13);
			this.splitTypeLabel.TabIndex = 0;
			this.splitTypeLabel.Text = "Split Type";
			// 
			// splitDataLabel
			// 
			this.splitDataLabel.AutoSize = true;
			this.splitDataLabel.Location = new System.Drawing.Point(103, 4);
			this.splitDataLabel.Name = "splitDataLabel";
			this.splitDataLabel.Size = new System.Drawing.Size(53, 13);
			this.splitDataLabel.TabIndex = 1;
			this.splitDataLabel.Text = "Split Data";
			// 
			// addSplitButton
			// 
			this.addSplitButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Add;
			this.addSplitButton.Location = new System.Drawing.Point(7, 27);
			this.addSplitButton.Name = "addSplitButton";
			this.addSplitButton.Size = new System.Drawing.Size(36, 23);
			this.addSplitButton.TabIndex = 2;
			this.addSplitButton.UseVisualStyleBackColor = true;
			this.addSplitButton.Click += new System.EventHandler(this.addSplitButton_Click);
			// 
			// splitPanel
			// 
			this.splitPanel.Location = new System.Drawing.Point(7, 21);
			this.splitPanel.Name = "splitPanel";
			this.splitPanel.Size = new System.Drawing.Size(500, 0);
			this.splitPanel.TabIndex = 3;
			// 
			// SplitCollectionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.addSplitButton);
			this.Controls.Add(this.splitPanel);
			this.Controls.Add(this.splitDataLabel);
			this.Controls.Add(this.splitTypeLabel);
			this.Name = "SplitCollectionControl";
			this.Size = new System.Drawing.Size(484, 381);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label splitTypeLabel;
		private System.Windows.Forms.Label splitDataLabel;
		private System.Windows.Forms.Button addSplitButton;
		private System.Windows.Forms.Panel splitPanel;
	}
}
