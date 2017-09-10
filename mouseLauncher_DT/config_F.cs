using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseLauncher_DT {
	public partial class config_F:Form {
		public config_F() {
			InitializeComponent();
		}

		string filename = "mlsetting.txt";

		private void config_F_Load(object sender,EventArgs e) {
			Settings.LoadSettings();
			numericUpDown1.Value = Settings.size;
			var txts = File.ReadAllLines(filename);
			foreach(var item in txts) {
				try {
					string line = item.Trim('\r','\n','\t');
					var rows = line.Split('\t');
					if(rows.Length < 2) {
						rows = line.Split('\a');
					}
					addRow(rows);
				}
				catch { }
			}
		}

		bool opening = false;

		private void addRow(params string[] rows) {

			if(rows.Length < 2) return;
			opening = true;
			bool isUrl = false, isDirectory = false;
			try {
				if(Directory.Exists(rows[1])) {
					isDirectory = true;
				}
				else {

					try {
						using(var client = new HttpClient()) {
							var response = client.GetAsync(rows[1]).Result;
							if(response.StatusCode == System.Net.HttpStatusCode.OK) {
								isUrl = true;
							}
						}
					}
					catch { }
				}

				if(rows.Length > 4) {
					var pitem = new programItem(rows[0].Trim(),rows[1].Trim(),rows[2].Trim(),rows[3].Trim(),rows[4].Trim(),-1,rows[rows.Length - 1] == "\a",isUrl,isDirectory);
					programItemBindingSource.Add(pitem);
				}

				else if(rows.Length > 2) {
					var pitem = new programItem(rows[0].Trim(),rows[1].Trim(),rows[2].Trim(),_imageindex: -1,_admin: rows[rows.Length - 1] == "\a",_isUrl: isUrl,_isDirectory: isDirectory);
					programItemBindingSource.Add(pitem);
				}

				else if(rows.Length > 1) {
					var pitem = new programItem(rows[0].Trim(),rows[1].Trim(),"",_imageindex: -1,_admin: rows[rows.Length - 1] == "\a",_isUrl: isUrl,_isDirectory: isDirectory);
					programItemBindingSource.Add(pitem);
				}

			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
			opening = false;

			//if(rows.Length < 2) return;
			//try {
			//	if(rows.Length > 4) {
			//		var pitem = new programItem(rows[0].Trim(),rows[1].Trim(),rows[2].Trim(),rows[3].Trim(),rows[4].Trim(),-1,rows[rows.Length - 1] == "\a");
			//		programItemBindingSource.Add(pitem);
			//	}
			//	else if(rows.Length > 2) {
			//		var pitem = new programItem(rows[0].Trim(),rows[1].Trim(),rows[2].Trim(),_imageindex: -1,_admin: rows[rows.Length - 1] == "\a");
			//		programItemBindingSource.Add(pitem);
			//	}

			//	else if(rows.Length > 1) {
			//		var pitem = new programItem(rows[0].Trim(),rows[1].Trim(),"",_imageindex: -1,_admin: rows[rows.Length - 1] == "\a");
			//		programItemBindingSource.Add(pitem);
			//	}

			//}
			//catch(Exception ex) {
			//	Debug.WriteLine(ex.Message);
			//}

		}

		private void contextMenuStrip1_Opening(object sender,CancelEventArgs e) {
			e.Cancel = dataGridView1.SelectedRows.Count < 1;
		}

		private void contextMenuStrip1_Opened(object sender,EventArgs e) {
			mup_MI.Enabled = up_MI.Enabled = dataGridView1.SelectedRows[0].Index > 0;
			mdown_MI.Enabled = down_MI.Enabled = dataGridView1.SelectedRows[0].Index < dataGridView1.Rows.Count - 1;
		}

		private void dataGridView1_CellContextMenuStripNeeded(object sender,DataGridViewCellContextMenuStripNeededEventArgs e) {
			if(e.ColumnIndex < 0 || e.RowIndex < 0) return;
			// 右クリックされたセル
			DataGridViewCell cell = dataGridView1[e.ColumnIndex,e.RowIndex];
			// セルの選択状態を反転
			cell.Selected = !cell.Selected;
		}

		private void up_MI_Click(object sender,EventArgs e) {
			var row = dataGridView1.SelectedRows[0];
			var item = new programItem(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString(),row.Cells[2].Value.ToString(),row.Cells[3].Value.ToString(),row.Cells[4].Value.ToString(),-1,(bool)row.Cells[5].Value);
			int index = row.Index;
			programItemBindingSource.RemoveAt(index);
			programItemBindingSource.Insert(index - 1,item);

		}

		private void down_MI_Click(object sender,EventArgs e) {
			var row = dataGridView1.SelectedRows[0];
			var item = new programItem(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString(),row.Cells[2].Value.ToString(),row.Cells[3].Value.ToString(),row.Cells[4].Value.ToString(),-1,(bool)row.Cells[5].Value);
			int index = row.Index;
			programItemBindingSource.RemoveAt(index);
			programItemBindingSource.Insert(index + 1,item);

		}

		private void mup_MI_Click(object sender,EventArgs e) {
			var row = dataGridView1.SelectedRows[0];
			var item = new programItem(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString(),row.Cells[2].Value.ToString(),row.Cells[3].Value.ToString(),row.Cells[4].Value.ToString(),-1,(bool)row.Cells[5].Value);
			int index = row.Index;
			programItemBindingSource.RemoveAt(index);
			programItemBindingSource.Insert(0,item);
		}

		private void mdown_MI_Click(object sender,EventArgs e) {
			var row = dataGridView1.SelectedRows[0];
			var item = new programItem(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString(),row.Cells[2].Value.ToString(),row.Cells[3].Value.ToString(),row.Cells[4].Value.ToString(),-1,(bool)row.Cells[5].Value);
			int index = row.Index;
			programItemBindingSource.RemoveAt(index);
			programItemBindingSource.Add(item);
		}

		private void dataGridView1_CellDoubleClick(object sender,DataGridViewCellEventArgs e) {
			if(e.RowIndex < 0) return;
			try {
				var item = dataGridView1.SelectedRows[0].Cells;
				using(var addfile = new addFile(item[0].Value.ToString(),item[1].Value.ToString(),item[2].Value.ToString(),item[3].Value.ToString(),item[4].Value.ToString(),(bool)item[5].Value,(bool)item[6].Value,(bool)item[7].Value)) {
					if(addfile.ShowDialog(this) == DialogResult.OK) {
						item[0].Value = addfile.name_T.Text;
						item[1].Value = addfile.file_T.Text;
						item[2].Value = addfile.args_T.Text;
						item[3].Value = addfile.user_T.Text;
						item[4].Value = addfile.pass_T.Text;
						item[5].Value = addfile.admin;
					}
					Opacity = 1;
				}
			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
		}

		private void button2_Click(object sender,EventArgs e) {
			Settings.size = (int)numericUpDown1.Value;
		}
	}
}
