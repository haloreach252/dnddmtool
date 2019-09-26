using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace DnDQuestCreator {
	public partial class RandomShopkeeperForm : Form {
		List<string> shopTypes = new List<string> {"blacksmith","fletcher","leatherworker","potion","arcane","tailor","jeweler","temple","general"};
		private string xmlPath = AppDomain.CurrentDomain.BaseDirectory + @"\randomgenerator\shopinfo.xml";

		public RandomShopkeeperForm() {
			InitializeComponent();
			if (Debugger.IsAttached) xmlPath = @"H:\Coding\C#Projects\dnddmtool\DnDQuestCreator\randomgenerator\shopinfo.xml";
		}

		private void generateButton_Click(object sender, EventArgs e) {
			itemGridView.Rows.Clear();
			if (!shopTypes.Contains(shopTypeBox.Text.ToLower())) shopTypeBox.Text = "blacksmith";
			List<string[]> items = GetData(shopTypeBox.Text.ToLower());
			foreach (string[] item in items) itemGridView.Rows.Add(item);
		}

		public List<string[]> GetData(string shopType) {
			List<string[]> data = new List<string[]>();
			XmlReader reader = XmlReader.Create(xmlPath);
			while (reader.Read()) {
				if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "product") && (reader.GetAttribute("type") == shopType)) {
					string[] node = new string[6] { reader.GetAttribute("name"), reader.GetAttribute("cheapcost") , reader.GetAttribute("normalcost"),
						reader.GetAttribute("expensivecost"), reader.GetAttribute("limited"), reader.GetAttribute("locale") };
					string[] temp = new string[8];
					for (int i = 0; i < 5; i++) {
						temp[i] = node[i];
					}
					if (node[5] == "7") for (int i = 0; i < 3; i++) temp[i + 5] = "true";
					else {
						string[] ruralStrings = new string[3] { "1", "3", "5" }; if (ruralStrings.Contains(node[5])) temp[5] = "true";
						string[] urbanStrings = new string[3] { "2", "3", "6" }; if (urbanStrings.Contains(node[5])) temp[6] = "true";
						string[] premiumStrings = new string[3] { "4", "5", "6" }; if (premiumStrings.Contains(node[5])) temp[7] = "true";
					}
					data.Add(temp);
				}
			}
			return data;
		}
	}
}