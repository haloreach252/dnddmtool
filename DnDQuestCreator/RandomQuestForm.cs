using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace DnDQuestCreator {
	public partial class RandomQuestForm : Form {
		GenerationData genData;
		string textFileFolderPath;
		Random rand;

		public RandomQuestForm() {
			InitializeComponent();
			genData = new GenerationData();
			if (!Debugger.IsAttached) textFileFolderPath = AppDomain.CurrentDomain.BaseDirectory + @"\randomgenerator\";
			else textFileFolderPath = @"H:\Coding\C#Projects\DnDQuestCreator\DnDQuestCreator\randomgenerator\";
			SetGenerationData();
			rand = new Random();
		}

		private void SetGenerationData() {
			genData.humanMaleNames = File.ReadAllLines(textFileFolderPath + "human-male-names.txt");
			genData.humanFemaleNames = File.ReadAllLines(textFileFolderPath + "human-female-names.txt");
			genData.elfMaleNames = File.ReadAllLines(textFileFolderPath + "elf-male-names.txt");
			genData.elfFemaleNames = File.ReadAllLines(textFileFolderPath + "elf-female-names.txt");

			genData.questTypes = File.ReadAllLines(textFileFolderPath + "quest-types.txt");
			genData.questTwists = File.ReadAllLines(textFileFolderPath + "quest-twists.txt");
			genData.questHooks = File.ReadAllLines(textFileFolderPath + "quest-hooks.txt");

			genData.bountyQuestDescriptions = File.ReadAllLines(textFileFolderPath + "bounty-quest-desc.txt");
			genData.killQuestDescriptions = File.ReadAllLines(textFileFolderPath + "kill-quest-desc.txt");
			genData.deliverQuestDescriptions = File.ReadAllLines(textFileFolderPath + "deliver-quest-desc.txt");
			genData.roleplayQuestDescriptions = File.ReadAllLines(textFileFolderPath + "roleplay-quest-desc.txt");
		}

		private void generateQuestButton_Click(object sender, EventArgs e) {
			string questText = "";
			string twistText = "";
			bool twist = false;
			if (rand.NextDouble() > .5) twist = true;
			if (twist) twistText = "However, " + genData.questTwists[rand.Next(genData.questTwists.Length)];

			string[] names = GetRandomNameGroup();

			string questType = genData.questTypes[rand.Next(0, genData.questTypes.Length)];
			string[] questTypeDesc = GetQuestTypeDesc(questType);

			string name = names[rand.Next(0, names.Length)];
			string hook = genData.questHooks[rand.Next(0, genData.questHooks.Length)];
			string questDesc = questTypeDesc[rand.Next(0, questTypeDesc.Length)];

			questText = String.Format("{0} {1} {2} quest. {3}. {4}", name, hook, questType, questDesc, twistText);
			questTextBox.Text = questText;
		}

		private string[] GetQuestTypeDesc(string input) {
			switch (input) {
				case "Kill":
					return genData.killQuestDescriptions;
				case "Bounty":
					return genData.bountyQuestDescriptions;
				case "Delivery":
					return genData.deliverQuestDescriptions;
				case "Roleplay":
					return genData.roleplayQuestDescriptions;
				default:
					return null;
			}
		}

		private string[] GetRandomNameGroup() {
			int num = rand.Next(0, 4);
			switch (num) {
				case 0:
					return genData.humanMaleNames;
				case 1:
					return genData.humanFemaleNames;
				case 2:
					return genData.elfMaleNames;
				case 3:
					return genData.elfFemaleNames;
				default:
					return genData.humanMaleNames;
			}
		}

	}

	public class GenerationData {

		// NAME SPECIFIC STRINGS
		public string[] humanMaleNames;
		public string[] humanFemaleNames;
		public string[] elfMaleNames;
		public string[] elfFemaleNames;

		// QUEST SPECIFIC STRINGS
		public string[] questTypes;
		public string[] questTwists;
		public string[] questHooks;

		// QUEST TYPE DESCRIPTIONS
		public string[] bountyQuestDescriptions;
		public string[] killQuestDescriptions;
		public string[] deliverQuestDescriptions;
		public string[] roleplayQuestDescriptions;

	}

}
