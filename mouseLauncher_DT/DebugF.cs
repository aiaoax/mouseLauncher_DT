using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseLauncher_DT {
	public partial class DebugF:Form {
		public DebugF() {
			InitializeComponent();
		}

		public Icon icon;

		private void DebugF_Load(object sender,EventArgs e) {
			pictureBox1.Image = icon.ToBitmap();
		}
	}
}
