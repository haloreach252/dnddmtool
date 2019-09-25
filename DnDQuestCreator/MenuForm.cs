﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDQuestCreator {
	public partial class MenuForm : Form {

		public static MainForm questCreatorForm;
		public static RandomQuestForm randQuestForm;
		public static RandomShopkeeperForm randShopForm;

		public MenuForm() {
			InitializeComponent();

			if (questCreatorForm == null) questCreatorForm = new MainForm();
			if (randQuestForm == null) randQuestForm = new RandomQuestForm();
			if (randShopForm == null) randShopForm = new RandomShopkeeperForm();
		}

		private void questCreatorButton_Click(object sender, EventArgs e) {
			questCreatorForm.Show();
		}

		private void randomQuestButton_Click(object sender, EventArgs e) {
			randQuestForm.Show();
		}

		private void shopkeeperGeneratorButton_Click(object sender, EventArgs e) {
			randShopForm.Show();
		}
	}
}
