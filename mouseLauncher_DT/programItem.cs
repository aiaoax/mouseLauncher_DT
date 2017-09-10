using System.Drawing;
using System.Windows.Forms;

class programItem:ListViewItem {

	public programItem(string _name,string _path,string _args = "",string _user = "",string _pass = "",int _imageindex = -1,bool _admin = false,bool _isUrl = false,bool _isDirectory = false) {
		Text = name = _name;
		path = _path.Replace("\"","");
		args = _args.Replace("\"","");
		user = _user;
		pass = _pass;
		ImageKey=$"{_imageindex}";
		//ImageIndex = _imageindex;
		admin = _admin;
		isUrl = _isUrl;
		isDirectory = _isDirectory;
		if(admin) {
			ForeColor = Color.Red;
		}
		if(user != "") {
			BackColor = Color.Gray;

		}
	}

	public string args { get { return _args; } set { _args = value != "\a" ? value : ""; } }

	public string name { get { return _name; } set { _name = value != "\a" ? value : ""; } }

	public string path { get { return _path; } set { _path = value != "\a" ? value : ""; } }

	public bool admin { get; set; }

	public string user { get { return _user; } set { _user = value != "\a" ? value : ""; } }

	public string pass { get { return _pass; } set { _pass = value != "\a" ? value : ""; } }

	public bool isUrl { get; set; }

	public bool isDirectory { get; set; }

	string _args { get; set; }

	string _name { get; set; }

	string _path { get; set; }

	string _user { get; set; }

	string _pass { get; set; }



	public override string ToString() {
		return name;
	}

}