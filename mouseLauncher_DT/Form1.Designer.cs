namespace mouseLauncher_DT {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.runas_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.folder_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.edit_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.delete_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.ofd1 = new System.Windows.Forms.OpenFileDialog();
			this.close_TM = new System.Windows.Forms.Timer(this.components);
			this.item_LV = new System.Windows.Forms.ListView();
			this.name_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.path_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.args_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.s_IL = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runas_MI,
            this.folder_MI,
            this.edit_MI,
            this.delete_MI});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip1.Size = new System.Drawing.Size(171, 92);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
			// 
			// runas_MI
			// 
			this.runas_MI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.runas_MI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.runas_MI.Name = "runas_MI";
			this.runas_MI.Size = new System.Drawing.Size(170, 22);
			this.runas_MI.Text = "管理者として実行";
			this.runas_MI.Click += new System.EventHandler(this.runas_MI_Click);
			// 
			// folder_MI
			// 
			this.folder_MI.Name = "folder_MI";
			this.folder_MI.Size = new System.Drawing.Size(170, 22);
			this.folder_MI.Text = "ファイルの場所を開く";
			this.folder_MI.Click += new System.EventHandler(this.folder_MI_Click);
			// 
			// edit_MI
			// 
			this.edit_MI.Name = "edit_MI";
			this.edit_MI.Size = new System.Drawing.Size(170, 22);
			this.edit_MI.Text = "編集";
			this.edit_MI.Click += new System.EventHandler(this.edit_MI_Click);
			// 
			// delete_MI
			// 
			this.delete_MI.Name = "delete_MI";
			this.delete_MI.Size = new System.Drawing.Size(170, 22);
			this.delete_MI.Text = "削除";
			this.delete_MI.Click += new System.EventHandler(this.delete_MI_Click);
			// 
			// ofd1
			// 
			this.ofd1.AddExtension = false;
			this.ofd1.InitialDirectory = "./";
			this.ofd1.SupportMultiDottedExtensions = true;
			this.ofd1.Title = "ファイルを選択してください";
			// 
			// close_TM
			// 
			this.close_TM.Interval = 1000;
			this.close_TM.Tick += new System.EventHandler(this.close_TM_Tick);
			// 
			// item_LV
			// 
			this.item_LV.AllowDrop = true;
			this.item_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_H,
            this.path_H,
            this.args_H});
			this.item_LV.ContextMenuStrip = this.contextMenuStrip1;
			this.item_LV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.item_LV.LargeImageList = this.s_IL;
			this.item_LV.Location = new System.Drawing.Point(0, 0);
			this.item_LV.Name = "item_LV";
			this.item_LV.Size = new System.Drawing.Size(200, 49);
			this.item_LV.SmallImageList = this.s_IL;
			this.item_LV.TabIndex = 1;
			this.item_LV.UseCompatibleStateImageBehavior = false;
			this.item_LV.View = System.Windows.Forms.View.SmallIcon;
			this.item_LV.DragDrop += new System.Windows.Forms.DragEventHandler(this.item_LV_DragDrop);
			this.item_LV.DragEnter += new System.Windows.Forms.DragEventHandler(this.item_LV_DragEnter);
			this.item_LV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemList_LB_KeyPress);
			this.item_LV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemList_LB_MouseClick);
			this.item_LV.MouseLeave += new System.EventHandler(this.itemList_LB_MouseLeave);
			this.item_LV.MouseHover += new System.EventHandler(this.itemList_LB_MouseHover);
			// 
			// name_H
			// 
			this.name_H.Text = "名前";
			// 
			// path_H
			// 
			this.path_H.Text = "パス";
			// 
			// args_H
			// 
			this.args_H.Text = "引数";
			// 
			// s_IL
			// 
			this.s_IL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("s_IL.ImageStream")));
			this.s_IL.TransparentColor = System.Drawing.Color.Transparent;
			this.s_IL.Images.SetKeyName(0, "add.png");
			this.s_IL.Images.SetKeyName(1, "config.png");
			this.s_IL.Images.SetKeyName(2, "cloce.png");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(200, 49);
			this.Controls.Add(this.item_LV);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ML";
			this.TopMost = true;
			this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseLeave += new System.EventHandler(this.itemList_LB_MouseLeave);
			this.MouseHover += new System.EventHandler(this.itemList_LB_MouseHover);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog ofd1;
		public System.Windows.Forms.Timer close_TM;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem edit_MI;
		private System.Windows.Forms.ToolStripMenuItem delete_MI;
		private System.Windows.Forms.ListView item_LV;
		private System.Windows.Forms.ColumnHeader name_H;
		private System.Windows.Forms.ColumnHeader path_H;
		private System.Windows.Forms.ColumnHeader args_H;
		private System.Windows.Forms.ImageList s_IL;
		private System.Windows.Forms.ToolStripMenuItem runas_MI;
		private System.Windows.Forms.ToolStripMenuItem folder_MI;
	}
}

