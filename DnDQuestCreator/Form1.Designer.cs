namespace DnDQuestCreator {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.loadQuestButton = new System.Windows.Forms.Button();
			this.saveQuestButton = new System.Windows.Forms.Button();
			this.questRewardBox = new System.Windows.Forms.RichTextBox();
			this.questTypeBox = new System.Windows.Forms.ComboBox();
			this.questFileDialogButton = new System.Windows.Forms.Button();
			this.questFolderDialogButton = new System.Windows.Forms.Button();
			this.questFileBox = new System.Windows.Forms.TextBox();
			this.questFolderBox = new System.Windows.Forms.TextBox();
			this.questDescBox = new System.Windows.Forms.RichTextBox();
			this.questNameBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.questFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.questFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.backButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.groupBox1.Controls.Add(this.loadQuestButton);
			this.groupBox1.Controls.Add(this.saveQuestButton);
			this.groupBox1.Controls.Add(this.questRewardBox);
			this.groupBox1.Controls.Add(this.questTypeBox);
			this.groupBox1.Controls.Add(this.questFileDialogButton);
			this.groupBox1.Controls.Add(this.questFolderDialogButton);
			this.groupBox1.Controls.Add(this.questFileBox);
			this.groupBox1.Controls.Add(this.questFolderBox);
			this.groupBox1.Controls.Add(this.questDescBox);
			this.groupBox1.Controls.Add(this.questNameBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(625, 581);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quest Details";
			// 
			// loadQuestButton
			// 
			this.loadQuestButton.BackColor = System.Drawing.Color.Indigo;
			this.loadQuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.loadQuestButton.Location = new System.Drawing.Point(462, 78);
			this.loadQuestButton.Name = "loadQuestButton";
			this.loadQuestButton.Size = new System.Drawing.Size(152, 55);
			this.loadQuestButton.TabIndex = 15;
			this.loadQuestButton.Text = "Load Quest";
			this.loadQuestButton.UseVisualStyleBackColor = false;
			this.loadQuestButton.Click += new System.EventHandler(this.loadQuestButton_Click);
			// 
			// saveQuestButton
			// 
			this.saveQuestButton.BackColor = System.Drawing.Color.Indigo;
			this.saveQuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.saveQuestButton.Location = new System.Drawing.Point(462, 17);
			this.saveQuestButton.Name = "saveQuestButton";
			this.saveQuestButton.Size = new System.Drawing.Size(152, 55);
			this.saveQuestButton.TabIndex = 14;
			this.saveQuestButton.Text = "Save Quest";
			this.saveQuestButton.UseVisualStyleBackColor = false;
			this.saveQuestButton.Click += new System.EventHandler(this.saveQuestButton_Click);
			// 
			// questRewardBox
			// 
			this.questRewardBox.BackColor = System.Drawing.Color.Indigo;
			this.questRewardBox.ForeColor = System.Drawing.Color.White;
			this.questRewardBox.Location = new System.Drawing.Point(376, 165);
			this.questRewardBox.Name = "questRewardBox";
			this.questRewardBox.Size = new System.Drawing.Size(238, 410);
			this.questRewardBox.TabIndex = 13;
			this.questRewardBox.Text = "";
			// 
			// questTypeBox
			// 
			this.questTypeBox.BackColor = System.Drawing.Color.Indigo;
			this.questTypeBox.ForeColor = System.Drawing.Color.White;
			this.questTypeBox.FormattingEnabled = true;
			this.questTypeBox.Items.AddRange(new object[] {
            "Bounty",
            "Kill",
            "Retrieval",
            "Deliver",
            "Roleplay",
            "Escort",
            "Puzzle"});
			this.questTypeBox.Location = new System.Drawing.Point(132, 52);
			this.questTypeBox.Name = "questTypeBox";
			this.questTypeBox.Size = new System.Drawing.Size(238, 24);
			this.questTypeBox.TabIndex = 12;
			// 
			// questFileDialogButton
			// 
			this.questFileDialogButton.BackColor = System.Drawing.Color.Indigo;
			this.questFileDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.questFileDialogButton.Location = new System.Drawing.Point(376, 116);
			this.questFileDialogButton.Name = "questFileDialogButton";
			this.questFileDialogButton.Size = new System.Drawing.Size(75, 23);
			this.questFileDialogButton.TabIndex = 11;
			this.questFileDialogButton.Text = "Browse";
			this.questFileDialogButton.UseVisualStyleBackColor = false;
			this.questFileDialogButton.Click += new System.EventHandler(this.questFileDialogButton_Click);
			// 
			// questFolderDialogButton
			// 
			this.questFolderDialogButton.BackColor = System.Drawing.Color.Indigo;
			this.questFolderDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.questFolderDialogButton.Location = new System.Drawing.Point(376, 84);
			this.questFolderDialogButton.Name = "questFolderDialogButton";
			this.questFolderDialogButton.Size = new System.Drawing.Size(75, 23);
			this.questFolderDialogButton.TabIndex = 10;
			this.questFolderDialogButton.Text = "Browse";
			this.questFolderDialogButton.UseVisualStyleBackColor = false;
			this.questFolderDialogButton.Click += new System.EventHandler(this.questFolderDialogButton_Click);
			// 
			// questFileBox
			// 
			this.questFileBox.BackColor = System.Drawing.Color.Indigo;
			this.questFileBox.ForeColor = System.Drawing.Color.White;
			this.questFileBox.Location = new System.Drawing.Point(132, 116);
			this.questFileBox.Name = "questFileBox";
			this.questFileBox.Size = new System.Drawing.Size(238, 23);
			this.questFileBox.TabIndex = 9;
			// 
			// questFolderBox
			// 
			this.questFolderBox.BackColor = System.Drawing.Color.Indigo;
			this.questFolderBox.ForeColor = System.Drawing.Color.White;
			this.questFolderBox.Location = new System.Drawing.Point(132, 84);
			this.questFolderBox.Name = "questFolderBox";
			this.questFolderBox.Size = new System.Drawing.Size(238, 23);
			this.questFolderBox.TabIndex = 8;
			// 
			// questDescBox
			// 
			this.questDescBox.BackColor = System.Drawing.Color.Indigo;
			this.questDescBox.ForeColor = System.Drawing.Color.White;
			this.questDescBox.Location = new System.Drawing.Point(9, 165);
			this.questDescBox.Name = "questDescBox";
			this.questDescBox.Size = new System.Drawing.Size(361, 410);
			this.questDescBox.TabIndex = 7;
			this.questDescBox.Text = "";
			// 
			// questNameBox
			// 
			this.questNameBox.BackColor = System.Drawing.Color.Indigo;
			this.questNameBox.ForeColor = System.Drawing.Color.White;
			this.questNameBox.Location = new System.Drawing.Point(132, 17);
			this.questNameBox.Name = "questNameBox";
			this.questNameBox.Size = new System.Drawing.Size(238, 23);
			this.questNameBox.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(373, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Quest Rewards:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(45, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Quest Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(46, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Folder Path:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(64, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "File Path:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(6, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Quest Description:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(40, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quest Name:";
			// 
			// questFileDialog
			// 
			this.questFileDialog.FileName = "openFileDialog1";
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.Indigo;
			this.backButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.backButton.Location = new System.Drawing.Point(645, 13);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 1;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(763, 606);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "MainForm";
			this.Text = "D&D Quest Creator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox questRewardBox;
		private System.Windows.Forms.ComboBox questTypeBox;
		private System.Windows.Forms.Button questFileDialogButton;
		private System.Windows.Forms.Button questFolderDialogButton;
		private System.Windows.Forms.TextBox questFileBox;
		private System.Windows.Forms.TextBox questFolderBox;
		private System.Windows.Forms.RichTextBox questDescBox;
		private System.Windows.Forms.TextBox questNameBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FolderBrowserDialog questFolderDialog;
		private System.Windows.Forms.OpenFileDialog questFileDialog;
		private System.Windows.Forms.Button loadQuestButton;
		private System.Windows.Forms.Button saveQuestButton;
		private System.Windows.Forms.Button backButton;
	}
}

