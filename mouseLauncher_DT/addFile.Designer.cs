namespace mouseLauncher_DT {
	partial class addFile {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.name_T = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.file_T = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.openfile_B = new System.Windows.Forms.Button();
			this.ofd1 = new System.Windows.Forms.OpenFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.args_T = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.admin_CB = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.user_T = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pass_T = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// name_T
			// 
			this.name_T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.name_T.Location = new System.Drawing.Point(12, 31);
			this.name_T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.name_T.Name = "name_T";
			this.name_T.Size = new System.Drawing.Size(460, 25);
			this.name_T.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "表示名";
			// 
			// file_T
			// 
			this.file_T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.file_T.Location = new System.Drawing.Point(12, 82);
			this.file_T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.file_T.Name = "file_T";
			this.file_T.Size = new System.Drawing.Size(398, 25);
			this.file_T.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "ファイルを選択してください";
			// 
			// openfile_B
			// 
			this.openfile_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.openfile_B.Location = new System.Drawing.Point(416, 77);
			this.openfile_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.openfile_B.Name = "openfile_B";
			this.openfile_B.Size = new System.Drawing.Size(56, 34);
			this.openfile_B.TabIndex = 4;
			this.openfile_B.Text = "参照";
			this.openfile_B.UseVisualStyleBackColor = true;
			this.openfile_B.Click += new System.EventHandler(this.openfile_B_Click);
			// 
			// ofd1
			// 
			this.ofd1.AddExtension = false;
			this.ofd1.InitialDirectory = "./";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(354, 269);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 34);
			this.button2.TabIndex = 5;
			this.button2.Text = "OK";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new System.Drawing.Point(416, 269);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 34);
			this.button3.TabIndex = 6;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// args_T
			// 
			this.args_T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.args_T.Location = new System.Drawing.Point(12, 133);
			this.args_T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.args_T.Name = "args_T";
			this.args_T.Size = new System.Drawing.Size(460, 25);
			this.args_T.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "引数";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 277);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(296, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "ファイルをドラッグ＆ドロップしても登録できます。";
			// 
			// admin_CB
			// 
			this.admin_CB.AutoSize = true;
			this.admin_CB.Location = new System.Drawing.Point(52, 110);
			this.admin_CB.Name = "admin_CB";
			this.admin_CB.Size = new System.Drawing.Size(87, 22);
			this.admin_CB.TabIndex = 9;
			this.admin_CB.Text = "管理者権限";
			this.admin_CB.UseVisualStyleBackColor = true;
			this.admin_CB.CheckedChanged += new System.EventHandler(this.admin_CB_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 18);
			this.label5.TabIndex = 11;
			this.label5.Text = "ユーザー名";
			// 
			// user_T
			// 
			this.user_T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.user_T.Location = new System.Drawing.Point(12, 184);
			this.user_T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.user_T.Name = "user_T";
			this.user_T.Size = new System.Drawing.Size(460, 25);
			this.user_T.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 213);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "パスワード";
			// 
			// pass_T
			// 
			this.pass_T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pass_T.Location = new System.Drawing.Point(12, 235);
			this.pass_T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pass_T.Name = "pass_T";
			this.pass_T.PasswordChar = '*';
			this.pass_T.Size = new System.Drawing.Size(460, 25);
			this.pass_T.TabIndex = 12;
			// 
			// addFile
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 311);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pass_T);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.user_T);
			this.Controls.Add(this.admin_CB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.args_T);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.openfile_B);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.file_T);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.name_T);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 350);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 350);
			this.Name = "addFile";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.addFile_Activated);
			this.Deactivate += new System.EventHandler(this.addFile_Deactivate);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addFile_FormClosed);
			this.Load += new System.EventHandler(this.addFile_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.addFile_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.addFile_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button openfile_B;
		private System.Windows.Forms.OpenFileDialog ofd1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		public System.Windows.Forms.TextBox name_T;
		public System.Windows.Forms.TextBox file_T;
		public System.Windows.Forms.TextBox args_T;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox admin_CB;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox user_T;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox pass_T;
	}
}