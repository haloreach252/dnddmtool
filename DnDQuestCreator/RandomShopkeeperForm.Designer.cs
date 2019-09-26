namespace DnDQuestCreator {
	partial class RandomShopkeeperForm {
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
			this.shopTypeBox = new System.Windows.Forms.ComboBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.shopGroupBox = new System.Windows.Forms.GroupBox();
			this.itemGridView = new System.Windows.Forms.DataGridView();
			this.itemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemPriceCheap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemPriceNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemPriceExpensive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.limited = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.itemLocaleRural = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.itemLocaleUrban = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.itemLocalePremium = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox1.SuspendLayout();
			this.shopGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.groupBox1.Controls.Add(this.shopTypeBox);
			this.groupBox1.Controls.Add(this.generateButton);
			this.groupBox1.Location = new System.Drawing.Point(10, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(683, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Controls";
			// 
			// shopTypeBox
			// 
			this.shopTypeBox.BackColor = System.Drawing.Color.Indigo;
			this.shopTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.shopTypeBox.Font = new System.Drawing.Font("Dungeon", 18F);
			this.shopTypeBox.ForeColor = System.Drawing.Color.White;
			this.shopTypeBox.FormattingEnabled = true;
			this.shopTypeBox.Items.AddRange(new object[] {
            "Arcane",
            "Blacksmith",
            "Fletcher",
            "General",
            "Jeweler",
            "Leatherworker",
            "Potion",
            "Tailor",
            "Temple"});
			this.shopTypeBox.Location = new System.Drawing.Point(6, 19);
			this.shopTypeBox.Name = "shopTypeBox";
			this.shopTypeBox.Size = new System.Drawing.Size(139, 27);
			this.shopTypeBox.Sorted = true;
			this.shopTypeBox.TabIndex = 1;
			// 
			// generateButton
			// 
			this.generateButton.BackColor = System.Drawing.Color.Indigo;
			this.generateButton.Font = new System.Drawing.Font("Dungeon", 24F, System.Drawing.FontStyle.Bold);
			this.generateButton.ForeColor = System.Drawing.Color.White;
			this.generateButton.Location = new System.Drawing.Point(6, 62);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(139, 54);
			this.generateButton.TabIndex = 0;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = false;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// shopGroupBox
			// 
			this.shopGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.shopGroupBox.Controls.Add(this.itemGridView);
			this.shopGroupBox.Location = new System.Drawing.Point(10, 159);
			this.shopGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.shopGroupBox.Name = "shopGroupBox";
			this.shopGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.shopGroupBox.Size = new System.Drawing.Size(683, 428);
			this.shopGroupBox.TabIndex = 1;
			this.shopGroupBox.TabStop = false;
			this.shopGroupBox.Text = "Shop";
			// 
			// itemGridView
			// 
			this.itemGridView.AllowUserToAddRows = false;
			this.itemGridView.AllowUserToDeleteRows = false;
			this.itemGridView.AllowUserToResizeColumns = false;
			this.itemGridView.AllowUserToResizeRows = false;
			this.itemGridView.BackgroundColor = System.Drawing.Color.Indigo;
			this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameCol,
            this.itemPriceCheap,
            this.itemPriceNormal,
            this.itemPriceExpensive,
            this.limited,
            this.itemLocaleRural,
            this.itemLocaleUrban,
            this.itemLocalePremium});
			this.itemGridView.GridColor = System.Drawing.Color.BlueViolet;
			this.itemGridView.Location = new System.Drawing.Point(5, 17);
			this.itemGridView.Margin = new System.Windows.Forms.Padding(2);
			this.itemGridView.MultiSelect = false;
			this.itemGridView.Name = "itemGridView";
			this.itemGridView.ReadOnly = true;
			this.itemGridView.RowTemplate.Height = 24;
			this.itemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.itemGridView.Size = new System.Drawing.Size(673, 400);
			this.itemGridView.TabIndex = 1;
			// 
			// itemNameCol
			// 
			this.itemNameCol.HeaderText = "Item Name";
			this.itemNameCol.Name = "itemNameCol";
			this.itemNameCol.ReadOnly = true;
			this.itemNameCol.Width = 150;
			// 
			// itemPriceCheap
			// 
			this.itemPriceCheap.HeaderText = "Cost (Cheap)";
			this.itemPriceCheap.Name = "itemPriceCheap";
			this.itemPriceCheap.ReadOnly = true;
			this.itemPriceCheap.Width = 80;
			// 
			// itemPriceNormal
			// 
			this.itemPriceNormal.HeaderText = "Cost (Normal)";
			this.itemPriceNormal.Name = "itemPriceNormal";
			this.itemPriceNormal.ReadOnly = true;
			this.itemPriceNormal.Width = 80;
			// 
			// itemPriceExpensive
			// 
			this.itemPriceExpensive.HeaderText = "Cost (Expensive)";
			this.itemPriceExpensive.Name = "itemPriceExpensive";
			this.itemPriceExpensive.ReadOnly = true;
			this.itemPriceExpensive.Width = 80;
			// 
			// limited
			// 
			this.limited.HeaderText = "Limited";
			this.limited.Name = "limited";
			this.limited.ReadOnly = true;
			this.limited.Width = 60;
			// 
			// itemLocaleRural
			// 
			this.itemLocaleRural.HeaderText = "Rural Locale";
			this.itemLocaleRural.Name = "itemLocaleRural";
			this.itemLocaleRural.ReadOnly = true;
			this.itemLocaleRural.Width = 60;
			// 
			// itemLocaleUrban
			// 
			this.itemLocaleUrban.HeaderText = "Urban Locale";
			this.itemLocaleUrban.Name = "itemLocaleUrban";
			this.itemLocaleUrban.ReadOnly = true;
			this.itemLocaleUrban.Width = 60;
			// 
			// itemLocalePremium
			// 
			this.itemLocalePremium.HeaderText = "Premium Locale";
			this.itemLocalePremium.Name = "itemLocalePremium";
			this.itemLocalePremium.ReadOnly = true;
			this.itemLocalePremium.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.itemLocalePremium.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.itemLocalePremium.Width = 60;
			// 
			// RandomShopkeeperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(701, 594);
			this.Controls.Add(this.shopGroupBox);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "RandomShopkeeperForm";
			this.Text = "Shop Generator";
			this.groupBox1.ResumeLayout(false);
			this.shopGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox shopGroupBox;
		private System.Windows.Forms.DataGridView itemGridView;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceCheap;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceNormal;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceExpensive;
		private System.Windows.Forms.DataGridViewCheckBoxColumn limited;
		private System.Windows.Forms.DataGridViewCheckBoxColumn itemLocaleRural;
		private System.Windows.Forms.DataGridViewCheckBoxColumn itemLocaleUrban;
		private System.Windows.Forms.DataGridViewCheckBoxColumn itemLocalePremium;
		private System.Windows.Forms.ComboBox shopTypeBox;
	}
}