using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mouseLauncher_DT {
	public static class Settings {

		static string setfilename = "mlsetfile.txt";

		enum Index {
			StartSettingIndex = -1
			, size

			, EndSettingIndex
		}

		static string[] setting { get; set; } = new string[(int)Index.EndSettingIndex];

		public static int size {
			get {
				int.TryParse(setting[(int)Index.size],out int x);
				return x;
			}
			set { setting[(int)Index.size] = $"{value}"; SaveSettings(); }
		}


		public static void SaveSettings() {
			try {
				File.WriteAllText(setfilename,SaveValues());
			}
			catch(Exception) {

			}
		}


		public static string SaveValues() {
			string ret = "";
			foreach(var set in setting) {
				ret += set + "\a";
			}
			ret = ret.Trim('\a');
			return ret;
		}

		public static void LoadSettings() {
			try {
				LoadValues(File.ReadAllText(setfilename));
			}
			catch(Exception) {
				size = 24;

			}
		}

		public static void LoadValues(string settingtxt) {

			try {
				var txts = settingtxt.Split('\a');
				foreach(var set in txts.Select((s,i) => new { s,i })) {
					if(set.i >= setting.Length) break;
					setting[set.i] = set.s;
				}
			}
			catch(Exception) {

			}
		}
	}
}
