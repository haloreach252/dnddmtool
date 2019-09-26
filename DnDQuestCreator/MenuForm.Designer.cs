namespace DnDQuestCreator {
	partial class MenuForm {
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
			this.questCreatorButton = new System.Windows.Forms.Button();
			this.randomQuestButton = new System.Windows.Forms.Button();
			this.shopkeeperGeneratorButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// questCreatorButton
			// 
			this.questCreatorButton.BackColor = System.Drawing.Color.Indigo;
			this.questCreatorButton.Font = new System.Drawing.Font("Dungeon", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.questCreatorButton.ForeColor = System.Drawing.Color.White;
			this.questCreatorButton.Location = new System.Drawing.Point(10, 10);
			this.questCreatorButton.Name = "questCreatorButton";
			this.questCreatorButton.Size = new System.Drawing.Size(320, 100);
			this.questCreatorButton.TabIndex = 0;
			this.questCreatorButton.Text = "Quest Creator";
			this.questCreatorButton.UseVisualStyleBackColor = false;
			this.questCreatorButton.Click += new System.EventHandler(this.questCreatorButton_Click);
			// 
			// randomQuestButton
			// 
			this.randomQuestButton.BackColor = System.Drawing.Color.Indigo;
			this.randomQuestButton.Font = new System.Drawing.Font("Dungeon", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randomQuestButton.ForeColor = System.Drawing.Color.White;
			this.randomQuestButton.Location = new System.Drawing.Point(10, 120);
			this.randomQuestButton.Name = "randomQuestButton";
			this.randomQuestButton.Size = new System.Drawing.Size(320, 100);
			this.randomQuestButton.TabIndex = 1;
			this.randomQuestButton.Text = "Random Quest Generator";
			this.randomQuestButton.UseVisualStyleBackColor = false;
			this.randomQuestButton.Click += new System.EventHandler(this.randomQuestButton_Click);
			// 
			// shopkeeperGeneratorButton
			// 
			this.shopkeeperGeneratorButton.BackColor = System.Drawing.Color.Indigo;
			this.shopkeeperGeneratorButton.Font = new System.Drawing.Font("Dungeon", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shopkeeperGeneratorButton.ForeColor = System.Drawing.Color.White;
			this.shopkeeperGeneratorButton.Location = new System.Drawing.Point(10, 230);
			this.shopkeeperGeneratorButton.Name = "shopkeeperGeneratorButton";
			this.shopkeeperGeneratorButton.Size = new System.Drawing.Size(320, 100);
			this.shopkeeperGeneratorButton.TabIndex = 2;
			this.shopkeeperGeneratorButton.Text = "Random Shopkeep Generator";
			this.shopkeeperGeneratorButton.UseVisualStyleBackColor = false;
			this.shopkeeperGeneratorButton.Click += new System.EventHandler(this.shopkeeperGeneratorButton_Click);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(339, 341);
			this.Controls.Add(this.shopkeeperGeneratorButton);
			this.Controls.Add(this.randomQuestButton);
			this.Controls.Add(this.questCreatorButton);
			this.Name = "MenuForm";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button questCreatorButton;
		private System.Windows.Forms.Button randomQuestButton;
		private System.Windows.Forms.Button shopkeeperGeneratorButton;
	}
}