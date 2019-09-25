using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DnDQuestCreator {
	public class Load {

		string type, name, desc, reward;

		string[] d;

		public QuestData LoadQuest(string path) {
			bool hitRewards = false;
			if (File.Exists(path)) {
				d = File.ReadAllLines(path);
				type = d[2];
				name = d[6];
				for (int i = 10; i < d.Length - 2; i++) {
					if (d[i] == "Rewards:") {
						hitRewards = true;
					}
					if (!hitRewards) {
						desc = desc + d[i] + "\n";
					} else {
						reward = reward + d[i + 2] + "\n";
					}
				}
				return new QuestData(type, name, desc, reward);
			}
			return null;
		}
	}

	public class QuestData {
		public string type, name, desc, reward;
		public QuestData(string a, string b, string c, string d) {
			type = a;
			name = b;
			desc = c;
			reward = d;
		}
	}

}
