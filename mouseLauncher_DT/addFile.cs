using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mouseLauncher_DT {
	public partial class addFile:Form {
		public addFile(string name = "",string file = "",string args = "",string user = "",string pass = "",bool admin = false,bool isUrl = false,bool isDirectory = false) {
			InitializeComponent();
			name_T.Text = name;
			file_T.Text = file;
			args_T.Text = args;
			user_T.Text = user;
			pass_T.Text = pass;
			admin_CB.Checked = admin;
			admin_CB.Enabled = args_T.Enabled = user_T.Enabled = pass_T.Enabled = !isUrl && !isDirectory;
		}

		public bool admin;

		private void addFile_Load(object sender,EventArgs e) {

		}

		private void openfile_B_Click(object sender,EventArgs e) {

			ofd1.InitialDirectory = file_T.Text != "" ? Path.GetDirectoryName(file_T.Text) : "";
			if(ofd1.ShowDialog() == DialogResult.OK) {
				file_T.Text = ofd1.FileName;
				if(name_T.Text == "") {
					name_T.Text = Path.GetFileName(file_T.Text).Replace(".exe","").Replace(".lnk","");

				}
			}
		}

		private void addFile_DragEnter(object sender,DragEventArgs e) {
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
				//ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
				e.Effect = DragDropEffects.Copy;
			else if(e.Data.GetDataPresent("UniformResourceLocator"))
				e.Effect = DragDropEffects.Link;
			else
				//ファイル以外は受け付けない
				e.Effect = DragDropEffects.None;
		}

		private async void addFile_DragDrop(object sender,DragEventArgs e) {
			if(e.Data.GetDataPresent(DataFormats.FileDrop)) {
				string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop,false);
				if(fileNames.Length > 0) {
					var item = fileNames[0];
					if(File.Exists(item)) {
						file_T.Text = item;
						if(name_T.Text == "") {
							name_T.Text = Path.GetFileName(item).Replace(".exe","").Replace(".lnk","");
						}
					}
					else if(Directory.Exists(item)) {
						file_T.Text = item;
						if(name_T.Text == "") {
							name_T.Text = Path.GetDirectoryName(item);
						}
					}
					admin_CB.Enabled = args_T.Enabled = user_T.Enabled = pass_T.Enabled = true;
				}
			}
			else if(e.Data.GetDataPresent("UniformResourceLocator")) {
				string url = (string)e.Data.GetData(DataFormats.Text);
				if(url != "") {
					var path = new Uri(url);
					using(var http = new HttpClient()) {
						var html = await http.GetStringAsync(url);
						var charset = Regex.Match(html,"charset=\"*([A-Za-z0-9_-]*)\"*");
						if(charset.Success) {
							var cs = charset.Result("$1");
							if(cs != "") {

								Encoding enc = Encoding.GetEncoding(cs);
								if(enc != Encoding.UTF8) {
									var tmp = await http.GetByteArrayAsync(url);
									html = toUTF8(tmp,enc);

								}
							}
						}

						var title = Regex.Match(html,"<(?:title|TITLE).*?>\\s*(.*)\\s</(?:title|TITLE)>");
						if(title.Success) {
							name_T.Text = title.Result("$1");
						}
						else {
							name_T.Text = path.Host;
						}
						file_T.Text = path.AbsoluteUri;
						admin_CB.Enabled = args_T.Enabled = user_T.Enabled = pass_T.Enabled = false;
					}
				}
			}
		}

		private string toUTF8(byte[] html,Encoding srcenc) {
			string ret = "";
			var tmp = Encoding.Convert(srcenc,Encoding.Default,html);
			ret = Encoding.Default.GetString(tmp);
			return ret;
		}

		private void addFile_Activated(object sender,EventArgs e) {
			Owner.Opacity = 1;
		}

		private void addFile_Deactivate(object sender,EventArgs e) {
			Owner.Opacity = 0;
		}

		private void addFile_FormClosed(object sender,FormClosedEventArgs e) {
			Owner.Opacity = 1;
		}

		private void admin_CB_CheckedChanged(object sender,EventArgs e) {
			admin = admin_CB.Checked;
		}
	}
}
