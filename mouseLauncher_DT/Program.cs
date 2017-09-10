using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseLauncher_DT {
	static class Program {

		public static bool end = false;

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Process p = Process.GetCurrentProcess();
			var ps = Process.GetProcesses().Where(x => x.ProcessName == p.ProcessName);
			
			foreach(var item in ps) {
				if(item.Id != p.Id)
					item.Kill();
			}

			

			while(!end) {
				int h = Screen.PrimaryScreen.Bounds.Height - 1;
				int x = Control.MousePosition.X;
				int y = Control.MousePosition.Y;

				if(x == 0 && y == h) {
					using(var f = new Form1()) {
						f.ShowDialog();
					}
				}
				Thread.Sleep(1000);
			}

		}
	}
}
