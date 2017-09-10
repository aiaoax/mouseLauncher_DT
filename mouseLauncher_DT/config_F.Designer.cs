namespace mouseLauncher_DT {
	partial class config_F {
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.isUrl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isDirectory = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mup_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.up_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.down_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.mdown_MI = new System.Windows.Forms.ToolStripMenuItem();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.argsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.programItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.programItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.argsDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn,
            this.isUrl,
            this.isDirectory});
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.DataSource = this.programItemBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(563, 423);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridView1_CellContextMenuStripNeeded);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// isUrl
			// 
			this.isUrl.DataPropertyName = "isUrl";
			this.isUrl.HeaderText = "isUrl";
			this.isUrl.Name = "isUrl";
			this.isUrl.Visible = false;
			// 
			// isDirectory
			// 
			this.isDirectory.DataPropertyName = "isDirectory";
			this.isDirectory.HeaderText = "isDirectory";
			this.isDirectory.Name = "isDirectory";
			this.isDirectory.Visible = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mup_MI,
            this.up_MI,
            this.down_MI,
            this.mdown_MI});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(121, 92);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
			// 
			// mup_MI
			// 
			this.mup_MI.Name = "mup_MI";
			this.mup_MI.Size = new System.Drawing.Size(120, 22);
			this.mup_MI.Text = "一番上へ";
			this.mup_MI.Click += new System.EventHandler(this.mup_MI_Click);
			// 
			// up_MI
			// 
			this.up_MI.Name = "up_MI";
			this.up_MI.Size = new System.Drawing.Size(120, 22);
			this.up_MI.Text = "上へ";
			this.up_MI.Click += new System.EventHandler(this.up_MI_Click);
			// 
			// down_MI
			// 
			this.down_MI.Name = "down_MI";
			this.down_MI.Size = new System.Drawing.Size(120, 22);
			this.down_MI.Text = "下へ";
			this.down_MI.Click += new System.EventHandler(this.down_MI_Click);
			// 
			// mdown_MI
			// 
			this.mdown_MI.Name = "mdown_MI";
			this.mdown_MI.Size = new System.Drawing.Size(120, 22);
			this.mdown_MI.Text = "一番下へ";
			this.mdown_MI.Click += new System.EventHandler(this.mdown_MI_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new System.Drawing.Point(519, 442);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 34);
			this.button3.TabIndex = 7;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(457, 442);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 34);
			this.button2.TabIndex = 8;
			this.button2.Text = "OK";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// pathDataGridViewTextBoxColumn
			// 
			this.pathDataGridViewTextBoxColumn.DataPropertyName = "path";
			this.pathDataGridViewTextBoxColumn.HeaderText = "path";
			this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
			// 
			// argsDataGridViewTextBoxColumn
			// 
			this.argsDataGridViewTextBoxColumn.DataPropertyName = "args";
			this.argsDataGridViewTextBoxColumn.HeaderText = "args";
			this.argsDataGridViewTextBoxColumn.Name = "argsDataGridViewTextBoxColumn";
			// 
			// userDataGridViewTextBoxColumn
			// 
			this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
			this.userDataGridViewTextBoxColumn.HeaderText = "user";
			this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
			// 
			// passDataGridViewTextBoxColumn
			// 
			this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
			this.passDataGridViewTextBoxColumn.HeaderText = "pass";
			this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
			this.passDataGridViewTextBoxColumn.Visible = false;
			// 
			// adminDataGridViewCheckBoxColumn
			// 
			this.adminDataGridViewCheckBoxColumn.DataPropertyName = "admin";
			this.adminDataGridViewCheckBoxColumn.HeaderText = "admin";
			this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
			// 
			// programItemBindingSource
			// 
			this.programItemBindingSource.DataSource = typeof(programItem);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(53, 466);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(54, 19);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 468);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "サイズ";
			// 
			// config_F
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 489);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "config_F";
			this.Text = "設定";
			this.Load += new System.EventHandler(this.config_F_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.programItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		protected System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.BindingSource programItemBindingSource;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem up_MI;
		private System.Windows.Forms.ToolStripMenuItem down_MI;
		private System.Windows.Forms.ToolStripMenuItem mup_MI;
		private System.Windows.Forms.ToolStripMenuItem mdown_MI;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn argsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isUrl;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isDirectory;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
	}
}