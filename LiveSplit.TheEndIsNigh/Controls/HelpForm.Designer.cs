namespace LiveSplit.TheEndIsNigh.Controls
{
	partial class HelpForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
			this.summaryLabel = new System.Windows.Forms.Label();
			this.bodyPartLabel = new System.Windows.Forms.Label();
			this.bodyPartDescription = new System.Windows.Forms.Label();
			this.cartridgeLabel = new System.Windows.Forms.Label();
			this.cartridgeDescription = new System.Windows.Forms.Label();
			this.tumorLabel = new System.Windows.Forms.Label();
			this.tumorDescription = new System.Windows.Forms.Label();
			this.worldEventLabel = new System.Windows.Forms.Label();
			this.worldEventDescription = new System.Windows.Forms.Label();
			this.zoneLabel = new System.Windows.Forms.Label();
			this.zoneDescription = new System.Windows.Forms.Label();
			this.levelLabel = new System.Windows.Forms.Label();
			this.levelDescription = new System.Windows.Forms.Label();
			this.futureLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.futureDescription = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// summaryLabel
			// 
			this.summaryLabel.AutoSize = true;
			this.summaryLabel.Location = new System.Drawing.Point(13, 13);
			this.summaryLabel.Name = "summaryLabel";
			this.summaryLabel.Size = new System.Drawing.Size(458, 26);
			this.summaryLabel.TabIndex = 0;
			this.summaryLabel.Text = "This is the autosplitter for The End Is Nigh. It starts your LiveSplit timer auto" +
    "matically when you\r\nstart a new file, then splits when certain game events occur" +
    ". Splits can be configured as follows.";
			// 
			// bodyPartLabel
			// 
			this.bodyPartLabel.AutoSize = true;
			this.bodyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bodyPartLabel.Location = new System.Drawing.Point(3, 0);
			this.bodyPartLabel.Name = "bodyPartLabel";
			this.bodyPartLabel.Size = new System.Drawing.Size(73, 13);
			this.bodyPartLabel.TabIndex = 1;
			this.bodyPartLabel.Text = "• Body Part";
			// 
			// bodyPartDescription
			// 
			this.bodyPartDescription.AutoSize = true;
			this.bodyPartDescription.Location = new System.Drawing.Point(138, 0);
			this.bodyPartDescription.Name = "bodyPartDescription";
			this.bodyPartDescription.Size = new System.Drawing.Size(301, 26);
			this.bodyPartDescription.TabIndex = 2;
			this.bodyPartDescription.Text = "Splits when the selected body part is collected. This happens\r\nimmediately upon p" +
    "icking up the body part, not when you land.";
			// 
			// cartridgeLabel
			// 
			this.cartridgeLabel.AutoSize = true;
			this.cartridgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cartridgeLabel.Location = new System.Drawing.Point(3, 40);
			this.cartridgeLabel.Name = "cartridgeLabel";
			this.cartridgeLabel.Size = new System.Drawing.Size(106, 13);
			this.cartridgeLabel.TabIndex = 3;
			this.cartridgeLabel.Text = "• Cartridge Count";
			// 
			// cartridgeDescription
			// 
			this.cartridgeDescription.AutoSize = true;
			this.cartridgeDescription.Location = new System.Drawing.Point(138, 40);
			this.cartridgeDescription.Name = "cartridgeDescription";
			this.cartridgeDescription.Size = new System.Drawing.Size(314, 26);
			this.cartridgeDescription.TabIndex = 4;
			this.cartridgeDescription.Text = "Splits when a target cartridge count is reached. Cartridge count is\r\nupdated imme" +
    "diately when you touch the cartridge.";
			// 
			// tumorLabel
			// 
			this.tumorLabel.AutoSize = true;
			this.tumorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tumorLabel.Location = new System.Drawing.Point(3, 80);
			this.tumorLabel.Name = "tumorLabel";
			this.tumorLabel.Size = new System.Drawing.Size(90, 13);
			this.tumorLabel.TabIndex = 5;
			this.tumorLabel.Text = "• Tumor Count";
			// 
			// tumorDescription
			// 
			this.tumorDescription.AutoSize = true;
			this.tumorDescription.Location = new System.Drawing.Point(138, 80);
			this.tumorDescription.Name = "tumorDescription";
			this.tumorDescription.Size = new System.Drawing.Size(320, 39);
			this.tumorDescription.TabIndex = 6;
			this.tumorDescription.Text = "Splits when a target tumor count is reached (or exceeded). Unlike\r\ncartridges, tu" +
    "mor count only updates when you collect a tumor and\r\nmove to another level (i.e." +
    " when the tumor is confirmed).";
			// 
			// worldEventLabel
			// 
			this.worldEventLabel.AutoSize = true;
			this.worldEventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.worldEventLabel.Location = new System.Drawing.Point(3, 220);
			this.worldEventLabel.Name = "worldEventLabel";
			this.worldEventLabel.Size = new System.Drawing.Size(88, 13);
			this.worldEventLabel.TabIndex = 7;
			this.worldEventLabel.Text = "• World Event";
			// 
			// worldEventDescription
			// 
			this.worldEventDescription.AutoSize = true;
			this.worldEventDescription.Location = new System.Drawing.Point(138, 220);
			this.worldEventDescription.Name = "worldEventDescription";
			this.worldEventDescription.Size = new System.Drawing.Size(318, 52);
			this.worldEventDescription.TabIndex = 8;
			this.worldEventDescription.Text = resources.GetString("worldEventDescription.Text");
			// 
			// zoneLabel
			// 
			this.zoneLabel.AutoSize = true;
			this.zoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zoneLabel.Location = new System.Drawing.Point(3, 285);
			this.zoneLabel.Name = "zoneLabel";
			this.zoneLabel.Size = new System.Drawing.Size(47, 13);
			this.zoneLabel.TabIndex = 9;
			this.zoneLabel.Text = "• Zone";
			// 
			// zoneDescription
			// 
			this.zoneDescription.AutoSize = true;
			this.zoneDescription.Location = new System.Drawing.Point(138, 285);
			this.zoneDescription.Name = "zoneDescription";
			this.zoneDescription.Size = new System.Drawing.Size(299, 26);
			this.zoneDescription.TabIndex = 10;
			this.zoneDescription.Text = "Splits when the selected zone is reached for the first time.\r\nSpecifically, you m" +
    "ust enter the first level of the selected zone.";
			// 
			// levelLabel
			// 
			this.levelLabel.AutoSize = true;
			this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelLabel.Location = new System.Drawing.Point(3, 170);
			this.levelLabel.Name = "levelLabel";
			this.levelLabel.Size = new System.Drawing.Size(49, 13);
			this.levelLabel.TabIndex = 11;
			this.levelLabel.Text = "• Level";
			// 
			// levelDescription
			// 
			this.levelDescription.AutoSize = true;
			this.levelDescription.Location = new System.Drawing.Point(138, 170);
			this.levelDescription.Name = "levelDescription";
			this.levelDescription.Size = new System.Drawing.Size(317, 39);
			this.levelDescription.TabIndex = 12;
			this.levelDescription.Text = resources.GetString("levelDescription.Text");
			// 
			// futureLabel
			// 
			this.futureLabel.AutoSize = true;
			this.futureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.futureLabel.Location = new System.Drawing.Point(3, 130);
			this.futureLabel.Name = "futureLabel";
			this.futureLabel.Size = new System.Drawing.Size(120, 13);
			this.futureLabel.TabIndex = 13;
			this.futureLabel.Text = "• Future Completion";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.bodyPartLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.zoneDescription, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.zoneLabel, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.futureLabel, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.levelLabel, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.worldEventLabel, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.bodyPartDescription, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.cartridgeLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cartridgeDescription, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tumorLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tumorDescription, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.worldEventDescription, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.levelDescription, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.futureDescription, 1, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 52);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 359);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// futureDescription
			// 
			this.futureDescription.AutoSize = true;
			this.futureDescription.Location = new System.Drawing.Point(138, 130);
			this.futureDescription.Name = "futureDescription";
			this.futureDescription.Size = new System.Drawing.Size(325, 26);
			this.futureDescription.TabIndex = 14;
			this.futureDescription.Text = "Splits when the selected future zone is completed (i.e. the teleporter\r\nat the en" +
    "d of the stage is reached).";
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 372);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.summaryLabel);
			this.Name = "HelpForm";
			this.Text = "The End Is Nigh Autosplitter Help";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label summaryLabel;
		private System.Windows.Forms.Label bodyPartLabel;
		private System.Windows.Forms.Label bodyPartDescription;
		private System.Windows.Forms.Label cartridgeLabel;
		private System.Windows.Forms.Label cartridgeDescription;
		private System.Windows.Forms.Label tumorLabel;
		private System.Windows.Forms.Label tumorDescription;
		private System.Windows.Forms.Label worldEventLabel;
		private System.Windows.Forms.Label worldEventDescription;
		private System.Windows.Forms.Label zoneLabel;
		private System.Windows.Forms.Label zoneDescription;
		private System.Windows.Forms.Label levelLabel;
		private System.Windows.Forms.Label levelDescription;
		private System.Windows.Forms.Label futureLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label futureDescription;
	}
}