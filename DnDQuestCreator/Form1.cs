using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDQuestCreator {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private bool fileOpened = false;
		private string path;
		private string filePath;

		private void saveQuestButton_Click(object sender, EventArgs e) {
			Save save = new Save();
			save.SaveQuest(path, questTypeBox.Text, questNameBox.Text, questDescBox.Text, questRewardBox.Text);
		}

		private void loadQuestButton_Click(object sender, EventArgs e) {
			Load load = new Load();
			QuestData data = load.LoadQuest(filePath);
			if(data.type != null && data.name != null && data.desc != null && data.reward != null) {
				questTypeBox.Text = data.type;
				questNameBox.Text = data.name;
				questDescBox.Text = data.desc;
				questRewardBox.Text = data.reward;
			}
		}

		private void questFolderDialogButton_Click(object sender, EventArgs e) {
			DialogResult result = questFolderDialog.ShowDialog();
			if(result == DialogResult.OK) {
				path = questFolderDialog.SelectedPath;
				questFolderBox.Text = path;
			}
		}

		private void questFileDialogButton_Click(object sender, EventArgs e) {
			DialogResult result = questFileDialog.ShowDialog();
			if(result == DialogResult.OK) {
				filePath = questFileDialog.FileName;
				questFileBox.Text = filePath;
			}
		}

		private void backButton_Click(object sender, EventArgs e) {
			
		}
	}
}
