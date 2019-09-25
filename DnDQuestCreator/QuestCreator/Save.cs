using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DnDQuestCreator {
	public class Save {
		public bool SaveQuest(string savePath, string type, string name, string desc, string reward) {
			string path = savePath + @"\" + name.ToString() + ".txt";
			if (path == null || name == null || type == null || desc == null || reward == null) return false;
			else {
				string saveStr = String.Format("Type:\n\n{0}\n\nName:\n\n{1}\n\nDescription:\n\n{2}\n\nRewards:\n\n{3}", type, name, desc, reward);
				if (File.Exists(path)) File.Delete(path);
				using (StreamWriter sw = new StreamWriter(path, true)) {
					sw.WriteLine(saveStr);
				}
			}
			return true;
		}

	}
}
