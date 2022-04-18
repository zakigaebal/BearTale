namespace BearTale
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadFromFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highlightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutBearTaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripTextBoxPath = new System.Windows.Forms.ToolStripTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.checkBoxTail = new System.Windows.Forms.CheckBox();
			this.comboBoxUtf = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.clearToolStripMenuItemClear,
            this.clearAllToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItemClear
			// 
			this.clearToolStripMenuItemClear.Name = "clearToolStripMenuItemClear";
			this.clearToolStripMenuItemClear.Size = new System.Drawing.Size(180, 22);
			this.clearToolStripMenuItemClear.Text = "Clear";
			this.clearToolStripMenuItemClear.Click += new System.EventHandler(this.clearToolStripMenuItemClear_Click);
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.clearAllToolStripMenuItem.Text = "ClearAll";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFilesToolStripMenuItem,
            this.saveFromFileToolStripMenuItem,
            this.highlightingToolStripMenuItem});
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.preferencesToolStripMenuItem.Text = "Preferences";
			// 
			// loadFromFilesToolStripMenuItem
			// 
			this.loadFromFilesToolStripMenuItem.Name = "loadFromFilesToolStripMenuItem";
			this.loadFromFilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loadFromFilesToolStripMenuItem.Text = "Load from File";
			// 
			// saveFromFileToolStripMenuItem
			// 
			this.saveFromFileToolStripMenuItem.Name = "saveFromFileToolStripMenuItem";
			this.saveFromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveFromFileToolStripMenuItem.Text = "Save from File";
			// 
			// highlightingToolStripMenuItem
			// 
			this.highlightingToolStripMenuItem.Name = "highlightingToolStripMenuItem";
			this.highlightingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.highlightingToolStripMenuItem.Text = "Highlighting";
			this.highlightingToolStripMenuItem.Click += new System.EventHandler(this.highlightingToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBearTaliToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutBearTaliToolStripMenuItem
			// 
			this.aboutBearTaliToolStripMenuItem.Name = "aboutBearTaliToolStripMenuItem";
			this.aboutBearTaliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutBearTaliToolStripMenuItem.Text = "About bearTail";
			this.aboutBearTaliToolStripMenuItem.Click += new System.EventHandler(this.aboutBearTaliToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripTextBoxPath});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
			this.toolStripButton1.Text = "Open";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(94, 22);
			this.toolStripButton2.Text = "Highlighting";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripTextBoxPath
			// 
			this.toolStripTextBoxPath.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripTextBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolStripTextBoxPath.Enabled = false;
			this.toolStripTextBoxPath.Font = new System.Drawing.Font("맑은 고딕", 9F);
			this.toolStripTextBoxPath.Name = "toolStripTextBoxPath";
			this.toolStripTextBoxPath.ReadOnly = true;
			this.toolStripTextBoxPath.Size = new System.Drawing.Size(300, 25);
			this.toolStripTextBoxPath.Click += new System.EventHandler(this.toolStripTextBoxPath_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 401);
			this.panel1.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 401);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragDrop);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// checkBoxTail
			// 
			this.checkBoxTail.AutoSize = true;
			this.checkBoxTail.Location = new System.Drawing.Point(164, 30);
			this.checkBoxTail.Name = "checkBoxTail";
			this.checkBoxTail.Size = new System.Drawing.Size(88, 16);
			this.checkBoxTail.TabIndex = 6;
			this.checkBoxTail.Text = "Follow_Tail";
			this.checkBoxTail.UseVisualStyleBackColor = true;
			this.checkBoxTail.CheckedChanged += new System.EventHandler(this.checkBoxTail_CheckedChanged);
			// 
			// comboBoxUtf
			// 
			this.comboBoxUtf.FormattingEnabled = true;
			this.comboBoxUtf.Location = new System.Drawing.Point(259, 28);
			this.comboBoxUtf.Name = "comboBoxUtf";
			this.comboBoxUtf.Size = new System.Drawing.Size(121, 20);
			this.comboBoxUtf.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBoxUtf);
			this.Controls.Add(this.checkBoxTail);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BearTale";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPath;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.CheckBox checkBoxTail;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItemClear;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutBearTaliToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFromFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveFromFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highlightingToolStripMenuItem;
		private System.Windows.Forms.ComboBox comboBoxUtf;
	}
}

