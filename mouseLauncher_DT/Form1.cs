using mouseLauncher_DT.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace mouseLauncher_DT {
	public partial class Form1:Form {

		string filename = "mlsetting.txt";

		bool opening;

		public Form1() {
			Settings.LoadSettings();
			InitializeComponent();
			s_IL = new ImageList {
				ColorDepth = ColorDepth.Depth32Bit
			};
			//盾アイコンを取得
			runas_MI.Image = new Bitmap(SystemIcons.Shield.ToBitmap(),Settings.size,Settings.size);
		}

		private void Form1_Load(object sender,EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;
			TopMost = false;
			getItems();
			TopMost = true;
			Cursor.Current = Cursors.Default;
		}

		private void itemList_LB_KeyPress(object sender,KeyPressEventArgs e) {
			//エンターキーを押したとき
			if(e.KeyChar == (char)Keys.Enter) {
				itemList_LB_MouseClick(sender,null);
			}
		}

		private void close_TM_Tick(object sender,EventArgs e) {
			//時間がたてば
			Close();
		}

		private void itemList_LB_MouseLeave(object sender,EventArgs e) {
			//メニューなどを開いていないときにカーソルがウィンドウの外に出たら開始
			if(TopMost) {
				close_TM.Start();
			}
		}

		private void itemList_LB_MouseHover(object sender,EventArgs e) {
			//カーソルがウィンドウに戻ってきたら停止
			close_TM.Stop();
		}

		private void itemList_LB_MouseClick(object sender,MouseEventArgs e) {
			//こうしないとメニュー表示中でも消える
			close_TM.Stop();
			if(e.Button == MouseButtons.Left) {
				var item = ((ListView)sender).SelectedItems[0] as programItem;
				if(item == null) return;
				switch(item.path) {
					case "add"://追加
						TopMost = false;
						using(var addfile = new addFile()) {
							if(addfile.ShowDialog(this) == DialogResult.OK) {
								addRow(addfile.name_T.Text,addfile.file_T.Text,addfile.args_T.Text,addfile.user_T.Text,addfile.pass_T.Text,addfile.admin ? "\a" : "");
							}
						}
						fileSave();
						TopMost = true;
						break;

					case "conf"://設定
						TopMost = false;
						using(var f = new config_F()) {
							if(f.ShowDialog() == DialogResult.OK) {
								try {
									while(opening) { Thread.Sleep(1000); };
									string output = "";
									foreach(programItem pitem in f.programItemBindingSource) {
										if(pitem.path != "add" && pitem.path != "conf" && pitem.path != "cfg" && pitem.path != "end") {
											var str = ($"{pitem.name}{'\t'}{pitem.path}{'\t'}{pitem.args}{'\t'}{pitem.user}{'\t'}{pitem.pass}").Trim() + (pitem.admin ? "\t\a" : "");
											output += str + Environment.NewLine;
										}
									}
									File.WriteAllText(filename,output,Encoding.UTF8);
								}
								catch(Exception ex) {
									Debug.WriteLine(ex.Message);
								}
							}
						}
						getItems();
						TopMost = true;

						break;
					case "cfg"://設定ファイル
						try {
							Process p = new Process();
							p.StartInfo.FileName = filename;
							p.Start();
						}
						catch(Exception ex) {
							close_TM.Stop();
							MessageBox.Show(ex.Message,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
						}
						Close();
						break;

					case "end"://閉じる
						Program.end = true;
						Close();
						break;

					default://ファイルかフォルダーだったとき

						if(File.Exists(item.path) || Directory.Exists(item.path)) {
							try {
								using(SecureString ss = new SecureString()) {
									ProcessStartInfo psi = new ProcessStartInfo(item.path,item.args);
									if(item.admin) {//管理者として実行
										psi.Verb = "runas";
										psi.ErrorDialog = true;
										psi.ErrorDialogParentHandle = Handle;
									}
									if(item.user != "") {//別のユーザーとして実行
										psi.UserName = item.user;
										foreach(char c in item.pass) {
											ss.AppendChar(c);
										}
										psi.Password = ss;
										psi.UseShellExecute = false;
									}
									//作業フォルダーを設定
									psi.WorkingDirectory = Path.GetDirectoryName(item.path);
									Process.Start(psi);//スタート！
								}
							}
							catch(Exception ex) {
								close_TM.Stop();
								TopMost = false;
								MessageBox.Show(ex.Message,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
							}
						}
						else {
							using(var client = new HttpClient()) {
								try {
									var response = client.GetAsync(item.path).Result;
									//サイトが見つかったとき
									if(response.StatusCode == System.Net.HttpStatusCode.OK) {
										Process.Start(item.path);
									}
									else {
										close_TM.Stop();
										TopMost = false;
										MessageBox.Show($"指定されたサイトは存在しません。({response.StatusCode}){Environment.NewLine}{item.path}","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
										Close();
									}
								}
								catch {
									close_TM.Stop();
									TopMost = false;
									MessageBox.Show($"指定されたアイテムは存在しません。{Environment.NewLine}{item.path}","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
									Close();
								}
							}

						}
						Close();
						break;
				}
				Opacity = 1;

				getItems();
			}
			else if(e.Button == MouseButtons.Right) {
				TopMost = false;
			}
		}

		private void runas_MI_Click(object sender,EventArgs e) {
			close_TM.Stop();
			foreach(programItem item in item_LV.SelectedItems) {
				if(item == null) continue;
				if(File.Exists(item.path)) {
					try {
						Process p = new Process();
						p.StartInfo.FileName = item.path;
						p.StartInfo.Arguments = item.args;
						p.StartInfo.Verb = "runas";
						p.StartInfo.ErrorDialog = true;
						p.StartInfo.ErrorDialogParentHandle = Handle;
						p.Start();
					}
					catch(Exception ex) {
						close_TM.Stop();
						MessageBox.Show(ex.Message,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
				else {
					close_TM.Stop();
					MessageBox.Show($"指定されたアイテムは存在しません。{Environment.NewLine}{item.path}","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			Close();
		}

		private void edit_MI_Click(object sender,EventArgs e) {
			close_TM.Stop();
			if(item_LV.SelectedItems.Count > 0) {
				foreach(programItem item in item_LV.SelectedItems) {
					if(item == null) continue;
					TopMost = false;
					try {
						using(var addfile = new addFile(item.name,item.path,item.args,item.user,item.pass,item.admin,item.isUrl,item.isDirectory)) {
							if(addfile.ShowDialog(this) == DialogResult.OK) {
								item.name = addfile.name_T.Text;
								item.path = addfile.file_T.Text;
								item.args = addfile.args_T.Text;
								item.user = addfile.user_T.Text;
								item.pass = addfile.pass_T.Text;
								item.admin = addfile.admin;
							}
							Opacity = 1;
						}
					}
					catch(Exception ex) {
						Debug.WriteLine(ex.Message);
					}
				}
				fileSave();
				getItems();
				TopMost = true;
			}
		}

		private void delete_MI_Click(object sender,EventArgs e) {
			try {
				close_TM.Stop();
				if(item_LV.SelectedItems.Count > 0) {
					if(MessageBox.Show(item_LV.SelectedItems.Count > 1 ? "すべて削除しますか？" : "削除しますか？","確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
						foreach(programItem item in item_LV.SelectedItems) {
							if(item == null) continue;
							TopMost = false;
							item_LV.Items.Remove(item);
						}
						fileSave();
						getItems();
					}
				}
			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
			TopMost = true;
		}

		private void Form1_Deactivate(object sender,EventArgs e) {
			if(TopMost) {
				close_TM.Start();
			}
		}

		private void item_LV_DragEnter(object sender,DragEventArgs e) {
			try {
				if(e.Data.GetDataPresent(DataFormats.FileDrop))//ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
					e.Effect = DragDropEffects.Copy;
				else if(e.Data.GetDataPresent("UniformResourceLocator"))//URLの時はリンクとする
					e.Effect = DragDropEffects.Link;
				else
					//ファイル以外は受け付けない
					e.Effect = DragDropEffects.None;
			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
		}

		private async void item_LV_DragDrop(object sender,DragEventArgs e) {
			try {
				if(e.Data.GetDataPresent(DataFormats.FileDrop)) {
					string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop,false);
					if(fileNames.Length > 0) {
						foreach(var item in fileNames) {
							string name = "", file = "";
							if(File.Exists(item)) {
								file = item;
								var path = new Uri(item);
								name = Uri.UnescapeDataString(path.Segments[path.Segments.Length - 1].Replace(".exe","").Replace(".lnk",""));
							}
							else if(Directory.Exists(item)) {
								file = item;
								var path = new Uri(item);
								name = Uri.UnescapeDataString(path.Segments[path.Segments.Length - 1]);
							}
							else {
								continue;
							}
							addRow(name,file);
						}
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
							//タイトルを取得
							var title = Regex.Match(html,"<(?:title|TITLE).*?>\\s*(.*)\\s</(?:title|TITLE)>");
							if(title.Success) {
								addRow(title.Result("$1"),path.AbsoluteUri);

							}
							else {
								addRow(path.Host,path.AbsoluteUri);
							}

						}
					}
				}
			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
		}

		private string toUTF8(byte[] html,Encoding srcenc) {
			string ret = "";
			var tmp = Encoding.Convert(srcenc,Encoding.Default,html);
			ret = Encoding.Default.GetString(tmp);
			return ret;
		}

		private void contextMenuStrip1_Opening(object sender,System.ComponentModel.CancelEventArgs e) {
			e.Cancel = item_LV.SelectedItems.Count < 1;
			if(e.Cancel) return;
			programItem txt = (programItem)item_LV.SelectedItems[0];
			e.Cancel |= txt.path.Contains("add");
			e.Cancel |= txt.path.Contains("conf");
			e.Cancel |= txt.path.Contains("cfg");
			e.Cancel |= txt.path.Contains("end");
		}

		private void contextMenuStrip1_Opened(object sender,EventArgs e) {
			programItem pi = item_LV.SelectedItems[0] as programItem;
			folder_MI.Visible = runas_MI.Visible = !pi.isUrl && !pi.isDirectory;
			folder_MI.Visible = !pi.isUrl;
			folder_MI.Text = pi.isDirectory ? "フォルダーの場所を開く" : "ファイルの場所を開く";
		}

		private void folder_MI_Click(object sender,EventArgs e) {
			close_TM.Stop();
			foreach(programItem item in item_LV.SelectedItems) {
				if(item == null) continue;
				item.path = item.path.Replace("\"","");
				var path = Path.GetDirectoryName(item.path);
				if(Directory.Exists(path)) {
					try {
						Process p = new Process();
						p.StartInfo.FileName = path;
						p.Start();
					}
					catch(Exception ex) {
						close_TM.Stop();
						MessageBox.Show(ex.Message,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
				else {
					close_TM.Stop();
					MessageBox.Show($"指定されたアイテムは存在しません。{Environment.NewLine}{item.path}","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			Close();
		}

		private void Form1_FormClosed(object sender,FormClosedEventArgs e) {
			fileSave();
			s_IL.Dispose();
			item_LV.Items.Clear();
		}

		private void getItems() {
			try {
				if(IsDisposed) return;
				Settings.LoadSettings();
				item_LV.Items.Clear();
				s_IL.Images.Clear();
				item_LV.SmallImageList = s_IL;
				item_LV.LargeImageList = s_IL;
				s_IL.ImageSize = new Size(Settings.size,Settings.size);
				s_IL.Images.Add($"{s_IL.Images.Count}",Resources.add);
				s_IL.Images.Add($"{s_IL.Images.Count}",Resources.config);
				s_IL.Images.Add($"{s_IL.Images.Count}",Resources.cloce);
				s_IL.Images.Add($"{s_IL.Images.Count}",Resources.folder);
				Width = 0;
				try {
					var txts = File.ReadAllLines(filename);
					foreach(var item in txts.Select((s,i) => new { s,i })) {
						try {
							string line = item.s.Trim('\r','\n','\t');
							var rows = line.Split('\t');
							if(rows.Length < 2) {
								rows = line.Split('\a');
							}
							addRow(item.i + s_IL.Images.Count + 1,rows);
						}
						catch { }
					}
					item_LV.Items.Add(new programItem("新規追加","add",_imageindex: 0));
					item_LV.Items.Add(new programItem("設定","conf",_imageindex: 1));
					item_LV.Items.Add(new programItem("設定ファイル","cfg",_imageindex: 1));
					if(Width < item_LV.Items[item_LV.Items.Count - 1].Bounds.Width + item_LV.Margin.Horizontal + 2) {
						Width = item_LV.Items[item_LV.Items.Count - 1].Bounds.Width + item_LV.Margin.Horizontal + 2;
					}
					item_LV.Items.Add(new programItem("終了","end","",_imageindex: 2));

					Height = (item_LV.Items.Count + 1) * item_LV.Items[0].Bounds.Height;
					if(Screen.PrimaryScreen.Bounds.Height < Height) {
						Height = Screen.PrimaryScreen.Bounds.Height;
					}
				}
				catch { }
				Top = Screen.PrimaryScreen.Bounds.Height - Height;
			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
		}

		private void addRow(params string[] rows) {
			addRow(item_LV.Items.Count,rows);
		}

		private void addRow(int idx,params string[] rows) {
			if(rows.Length < 2) return;
			opening = true;
			int imgnum = idx;
			bool isUrl = false, isDirectory = false;
			try {
				if(File.Exists(rows[1])) {
					using(var ico = Icon.ExtractAssociatedIcon(rows[1])) {
						s_IL.Images.Add($"{imgnum}",ico.ToBitmap());
					}
				}
				else if(Directory.Exists(rows[1])) {
					imgnum = 3;
					isDirectory = true;
				}
				else if(Regex.IsMatch(rows[1],@"^s?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+$")) {
					var bmp = Resources.web;
					isUrl = true;
					Task.Run(() => {
						try {
							using(var client = new HttpClient()) {
								try {
									var response = client.GetAsync(rows[1]).Result;
									if(response.StatusCode == System.Net.HttpStatusCode.OK) {
										try {
											var uri = new Uri(rows[1]);
											using(var icon = client.GetStreamAsync($"{uri.GetLeftPart(UriPartial.Authority)}/favicon.ico")) {
												icon.Wait(5000);
												if(icon != null) {
													bmp = new Bitmap(icon.Result);
												}
											}
										}
										catch {

										}
									}
									else {
										bmp = Resources.none;
									}
								}
								catch {
									bmp = Resources.none;
								}
							}

							if(!IsDisposed) {
								if((bool)item_LV?.InvokeRequired) {
									item_LV?.Invoke((Action)(() => {
										s_IL?.Images?.Add($"{imgnum}",bmp);
									}));
								}
								else {
									s_IL?.Images?.Add($"{imgnum}",bmp);
								}
							}

							bmp?.Dispose();
							bmp = null;
						}
						catch(Exception ex) {
							Debug.WriteLine(ex.Message);

						}
					});

				}
				else {
					s_IL.Images.Add($"{imgnum}",Resources.none);
				}

				programItem pitem;

				if(rows.Length > 4) {
					pitem = new programItem(rows[0].Trim(),rows[1].Trim(),rows[2].Trim(),rows[3].Trim(),rows[4].Trim(),imgnum,rows[rows.Length - 1] == "\a",isUrl,isDirectory);
				}
				else if(rows.Length > 2) {
					pitem = new programItem(rows[0].Trim(),rows[1].Trim(),rows[2].Trim(),_imageindex: imgnum,_admin: rows[rows.Length - 1] == "\a",_isUrl: isUrl,_isDirectory: isDirectory);
				}
				else if(rows.Length > 1) {
					pitem = new programItem(rows[0].Trim(),rows[1].Trim(),"",_imageindex: imgnum,_admin: rows[rows.Length - 1] == "\a",_isUrl: isUrl,_isDirectory: isDirectory);
				}
				else {
					opening = false;
					return;
				}

				item_LV.Items.Add(pitem);
				if(Width < item_LV.Items[item_LV.Items.Count - 1].Bounds.Width + item_LV.Margin.Horizontal + SystemInformation.VerticalScrollBarWidth + 2) {
					Width = item_LV.Items[item_LV.Items.Count - 1].Bounds.Width + item_LV.Margin.Horizontal + SystemInformation.VerticalScrollBarWidth + 2;
				}
			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
			opening = false;
		}

		private void fileSave() {
			try {
				while(opening) { Thread.Sleep(1000); }
				string output = "";
				foreach(programItem pitem in item_LV.Items) {
					if(pitem.path != "add" && pitem.path != "conf" && pitem.path != "cfg" && pitem.path != "end") {
						var str = ($"{pitem.name}{'\t'}{pitem.path}{'\t'}{pitem.args}{'\t'}{pitem.user}{'\t'}{pitem.pass}").Trim() + (pitem.admin ? "\t\a" : "");
						output += str + Environment.NewLine;
					}
				}
				File.WriteAllText(filename,output,Encoding.UTF8);
			}
			catch(Exception ex) {
				Debug.WriteLine(ex.Message);
			}
		}


	}
}
