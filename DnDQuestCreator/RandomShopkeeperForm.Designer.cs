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
			this.shopGroupBox = new System.Windows.Forms.GroupBox();
			this.shopTypeBox = new System.Windows.Forms.TextBox();
			this.itemGridView = new System.Windows.Forms.DataGridView();
			this.itemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemPriceCheap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemPriceNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemPriceExpensive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemLocaleRural = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.itemLocaleUrban = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.itemLocalePremium = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.shopGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Controls";
			// 
			// shopGroupBox
			// 
			this.shopGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.shopGroupBox.Controls.Add(this.itemGridView);
			this.shopGroupBox.Controls.Add(this.shopTypeBox);
			this.shopGroupBox.Location = new System.Drawing.Point(13, 120);
			this.shopGroupBox.Name = "shopGroupBox";
			this.shopGroupBox.Size = new System.Drawing.Size(910, 667);
			this.shopGroupBox.TabIndex = 1;
			this.shopGroupBox.TabStop = false;
			this.shopGroupBox.Text = "Shop";
			// 
			// shopTypeBox
			// 
			this.shopTypeBox.Location = new System.Drawing.Point(7, 22);
			this.shopTypeBox.Name = "shopTypeBox";
			this.shopTypeBox.Size = new System.Drawing.Size(215, 22);
			this.shopTypeBox.TabIndex = 0;
			// 
			// itemGridView
			// 
			this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameCol,
            this.itemPriceCheap,
            this.itemPriceNormal,
            this.itemPriceExpensive,
            this.itemLocaleRural,
            this.itemLocaleUrban,
            this.itemLocalePremium});
			this.itemGridView.Location = new System.Drawing.Point(7, 51);
			this.itemGridView.Name = "itemGridView";
			this.itemGridView.RowTemplate.Height = 24;
			this.itemGridView.Size = new System.Drawing.Size(893, 610);
			this.itemGridView.TabIndex = 1;
			// 
			// itemNameCol
			// 
			this.itemNameCol.HeaderText = "Item Name";
			this.itemNameCol.Name = "itemNameCol";
			this.itemNameCol.ReadOnly = true;
			this.itemNameCol.Width = 250;
			// 
			// itemPriceCheap
			// 
			this.itemPriceCheap.HeaderText = "Cost (Cheap)";
			this.itemPriceCheap.Name = "itemPriceCheap";
			this.itemPriceCheap.ReadOnly = true;
			// 
			// itemPriceNormal
			// 
			this.itemPriceNormal.HeaderText = "Cost (Normal)";
			this.itemPriceNormal.Name = "itemPriceNormal";
			this.itemPriceNormal.ReadOnly = true;
			// 
			// itemPriceExpensive
			// 
			this.itemPriceExpensive.HeaderText = "Cost (Expensive)";
			this.itemPriceExpensive.Name = "itemPriceExpensive";
			this.itemPriceExpensive.ReadOnly = true;
			// 
			// itemLocaleRural
			// 
			this.itemLocaleRural.HeaderText = "Rural Locale";
			this.itemLocaleRural.Name = "itemLocaleRural";
			this.itemLocaleRural.ReadOnly = true;
			// 
			// itemLocaleUrban
			// 
			this.itemLocaleUrban.HeaderText = "Urban Locale";
			this.itemLocaleUrban.Name = "itemLocaleUrban";
			this.itemLocaleUrban.ReadOnly = true;
			// 
			// itemLocalePremium
			// 
			this.itemLocalePremium.HeaderText = "Premium Locale";
			this.itemLocalePremium.Name = "itemLocalePremium";
			this.itemLocalePremium.ReadOnly = true;
			this.itemLocalePremium.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.itemLocalePremium.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// RandomShopkeeperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(935, 799);
			this.Controls.Add(this.shopGroupBox);
			this.Controls.Add(this.groupBox1);
			this.Name = "RandomShopkeeperForm";
			this.Text = "Shop Generator";
			this.shopGroupBox.ResumeLayout(false);
			this.shopGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox shopGroupBox;
		private System.Windows.Forms.DataGridView itemGridView;
		private System.Windows.Forms.TextBox shopTypeBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceCheap;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceNormal;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceExpensive;
		private System.Windows.Forms.DataGridViewCheckBoxColumn itemLocaleRural;
		private System.Windows.Forms.DataGridViewCheckBoxColumn itemLocaleUrban;
		private System.Windows.Forms.DataGridViewCheckBoxColumn itemLocalePremium;
	}
}