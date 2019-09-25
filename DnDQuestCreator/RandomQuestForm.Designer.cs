namespace DnDQuestCreator {
	partial class RandomQuestForm {
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
			this.questTextBox = new System.Windows.Forms.RichTextBox();
			this.generateQuestButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.groupBox1.Controls.Add(this.questTextBox);
			this.groupBox1.Controls.Add(this.generateQuestButton);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 426);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Random Quest Generator";
			// 
			// questTextBox
			// 
			this.questTextBox.BackColor = System.Drawing.Color.Indigo;
			this.questTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.questTextBox.ForeColor = System.Drawing.Color.White;
			this.questTextBox.Location = new System.Drawing.Point(6, 22);
			this.questTextBox.Name = "questTextBox";
			this.questTextBox.Size = new System.Drawing.Size(764, 324);
			this.questTextBox.TabIndex = 1;
			this.questTextBox.Text = "";
			// 
			// generateQuestButton
			// 
			this.generateQuestButton.BackColor = System.Drawing.Color.DarkViolet;
			this.generateQuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.generateQuestButton.ForeColor = System.Drawing.Color.White;
			this.generateQuestButton.Location = new System.Drawing.Point(6, 352);
			this.generateQuestButton.Name = "generateQuestButton";
			this.generateQuestButton.Size = new System.Drawing.Size(764, 68);
			this.generateQuestButton.TabIndex = 0;
			this.generateQuestButton.Text = "Generate Quest!";
			this.generateQuestButton.UseVisualStyleBackColor = false;
			this.generateQuestButton.Click += new System.EventHandler(this.generateQuestButton_Click);
			// 
			// RandomQuestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "RandomQuestForm";
			this.Text = "Random Quest";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox questTextBox;
		private System.Windows.Forms.Button generateQuestButton;
	}
}