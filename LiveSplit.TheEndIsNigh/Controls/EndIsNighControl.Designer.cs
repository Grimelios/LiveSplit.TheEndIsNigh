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
			this.autosplitterLabel = new System.Windows.Forms.Label();
			this.helpButton = new System.Windows.Forms.Button();
			this.splitCollectionControl1 = new LiveSplit.TheEndIsNigh.Controls.SplitCollectionControl();
			this.defaultCategoryControl1 = new LiveSplit.TheEndIsNigh.Controls.DefaultCategoryControl();
			this.settingsControl1 = new LiveSplit.TheEndIsNigh.Controls.SettingsControl();
			this.SuspendLayout();
			// 
			// autosplitterLabel
			// 
			this.autosplitterLabel.AutoSize = true;
			this.autosplitterLabel.Location = new System.Drawing.Point(10, 12);
			this.autosplitterLabel.Name = "autosplitterLabel";
			this.autosplitterLabel.Size = new System.Drawing.Size(139, 13);
			this.autosplitterLabel.TabIndex = 2;
			this.autosplitterLabel.Text = "The End Is Nigh Autosplitter";
			// 
			// helpButton
			// 
			this.helpButton.Image = global::LiveSplit.TheEndIsNigh.Properties.Resources.Question;
			this.helpButton.Location = new System.Drawing.Point(227, 8);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(36, 23);
			this.helpButton.TabIndex = 3;
			this.helpButton.UseVisualStyleBackColor = true;
			this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
			// 
			// splitCollectionControl1
			// 
			this.splitCollectionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitCollectionControl1.Location = new System.Drawing.Point(7, 148);
			this.splitCollectionControl1.Name = "splitCollectionControl1";
			this.splitCollectionControl1.Size = new System.Drawing.Size(462, 378);
			this.splitCollectionControl1.SplitCollection = null;
			this.splitCollectionControl1.TabIndex = 1;
			// 
			// defaultCategoryControl1
			// 
			this.defaultCategoryControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.defaultCategoryControl1.CollectionControl = null;
			this.defaultCategoryControl1.Location = new System.Drawing.Point(7, 91);
			this.defaultCategoryControl1.Name = "defaultCategoryControl1";
			this.defaultCategoryControl1.Size = new System.Drawing.Size(462, 65);
			this.defaultCategoryControl1.TabIndex = 0;
			// 
			// settingsControl1
			// 
			this.settingsControl1.Location = new System.Drawing.Point(7, 38);
			this.settingsControl1.Name = "settingsControl1";
			this.settingsControl1.Size = new System.Drawing.Size(462, 51);
			this.settingsControl1.TabIndex = 4;
			// 
			// EndIsNighControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.settingsControl1);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.autosplitterLabel);
			this.Controls.Add(this.splitCollectionControl1);
			this.Controls.Add(this.defaultCategoryControl1);
			this.Name = "EndIsNighControl";
			this.Size = new System.Drawing.Size(472, 529);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DefaultCategoryControl defaultCategoryControl1;
		private SplitCollectionControl splitCollectionControl1;
		private System.Windows.Forms.Label autosplitterLabel;
		private System.Windows.Forms.Button helpButton;
		private SettingsControl settingsControl1;
	}
}
