namespace BearTale
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonPageUp = new System.Windows.Forms.Button();
			this.buttonPageDown = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxString = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.checkBoxIgnore = new System.Windows.Forms.CheckBox();
			this.checkBoxInvert = new System.Windows.Forms.CheckBox();
			this.checkBoxBold = new System.Windows.Forms.CheckBox();
			this.checkBoxItalic = new System.Windows.Forms.CheckBox();
			this.buttonCustom1 = new System.Windows.Forms.Button();
			this.buttonCustom2 = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorDialog2 = new System.Windows.Forms.ColorDialog();
			this.colorComboBox2 = new BearTale.ColorComboBox();
			this.colorComboBox1 = new BearTale.ColorComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 161);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(35, 23);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(46, 161);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(49, 23);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Location = new System.Drawing.Point(94, 161);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(63, 23);
			this.buttonMoveUp.TabIndex = 3;
			this.buttonMoveUp.Text = "Move Up";
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Location = new System.Drawing.Point(156, 161);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(80, 23);
			this.buttonMoveDown.TabIndex = 4;
			this.buttonMoveDown.Text = "Move Down";
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "ForeGround Color";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(234, 187);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "Background Color";
			// 
			// buttonPageUp
			// 
			this.buttonPageUp.Location = new System.Drawing.Point(235, 161);
			this.buttonPageUp.Name = "buttonPageUp";
			this.buttonPageUp.Size = new System.Drawing.Size(63, 23);
			this.buttonPageUp.TabIndex = 4;
			this.buttonPageUp.Text = "Page Up";
			this.buttonPageUp.UseVisualStyleBackColor = true;
			this.buttonPageUp.Click += new System.EventHandler(this.buttonPageUp_Click);
			// 
			// buttonPageDown
			// 
			this.buttonPageDown.Location = new System.Drawing.Point(298, 161);
			this.buttonPageDown.Name = "buttonPageDown";
			this.buttonPageDown.Size = new System.Drawing.Size(78, 23);
			this.buttonPageDown.TabIndex = 4;
			this.buttonPageDown.Text = "Page Down";
			this.buttonPageDown.UseVisualStyleBackColor = true;
			this.buttonPageDown.Click += new System.EventHandler(this.buttonPageDown_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "String";
			// 
			// textBoxString
			// 
			this.textBoxString.Location = new System.Drawing.Point(13, 241);
			this.textBoxString.Name = "textBoxString";
			this.textBoxString.Size = new System.Drawing.Size(449, 21);
			this.textBoxString.TabIndex = 6;
			this.textBoxString.TextChanged += new System.EventHandler(this.textBoxString_TextChanged);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(355, 262);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(45, 23);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(399, 262);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(64, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "CANCEL";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(375, 161);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 23);
			this.buttonLoad.TabIndex = 9;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(417, 161);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(45, 23);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(449, 150);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// checkBoxIgnore
			// 
			this.checkBoxIgnore.AutoSize = true;
			this.checkBoxIgnore.Location = new System.Drawing.Point(12, 268);
			this.checkBoxIgnore.Name = "checkBoxIgnore";
			this.checkBoxIgnore.Size = new System.Drawing.Size(93, 16);
			this.checkBoxIgnore.TabIndex = 16;
			this.checkBoxIgnore.Text = "Ignore Case";
			this.checkBoxIgnore.UseVisualStyleBackColor = true;
			this.checkBoxIgnore.CheckedChanged += new System.EventHandler(this.checkBoxIgnore_CheckedChanged);
			// 
			// checkBoxInvert
			// 
			this.checkBoxInvert.AutoSize = true;
			this.checkBoxInvert.Location = new System.Drawing.Point(104, 268);
			this.checkBoxInvert.Name = "checkBoxInvert";
			this.checkBoxInvert.Size = new System.Drawing.Size(93, 16);
			this.checkBoxInvert.TabIndex = 16;
			this.checkBoxInvert.Text = "Invert Match";
			this.checkBoxInvert.UseVisualStyleBackColor = true;
			this.checkBoxInvert.CheckedChanged += new System.EventHandler(this.checkBoxInvert_CheckedChanged);
			// 
			// checkBoxBold
			// 
			this.checkBoxBold.AutoSize = true;
			this.checkBoxBold.Location = new System.Drawing.Point(196, 268);
			this.checkBoxBold.Name = "checkBoxBold";
			this.checkBoxBold.Size = new System.Drawing.Size(49, 16);
			this.checkBoxBold.TabIndex = 16;
			this.checkBoxBold.Text = "Bold";
			this.checkBoxBold.UseVisualStyleBackColor = true;
			this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
			// 
			// checkBoxItalic
			// 
			this.checkBoxItalic.AutoSize = true;
			this.checkBoxItalic.Location = new System.Drawing.Point(246, 268);
			this.checkBoxItalic.Name = "checkBoxItalic";
			this.checkBoxItalic.Size = new System.Drawing.Size(50, 16);
			this.checkBoxItalic.TabIndex = 16;
			this.checkBoxItalic.Text = "Italic";
			this.checkBoxItalic.UseVisualStyleBackColor = true;
			this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxItalic_CheckedChanged);
			// 
			// buttonCustom1
			// 
			this.buttonCustom1.Location = new System.Drawing.Point(205, 201);
			this.buttonCustom1.Name = "buttonCustom1";
			this.buttonCustom1.Size = new System.Drawing.Size(26, 23);
			this.buttonCustom1.TabIndex = 17;
			this.buttonCustom1.Text = "c";
			this.buttonCustom1.UseVisualStyleBackColor = true;
			this.buttonCustom1.Click += new System.EventHandler(this.buttonCustom1_Click);
			// 
			// buttonCustom2
			// 
			this.buttonCustom2.Location = new System.Drawing.Point(434, 201);
			this.buttonCustom2.Name = "buttonCustom2";
			this.buttonCustom2.Size = new System.Drawing.Size(26, 23);
			this.buttonCustom2.TabIndex = 17;
			this.buttonCustom2.Text = "c";
			this.buttonCustom2.UseVisualStyleBackColor = true;
			this.buttonCustom2.Click += new System.EventHandler(this.buttonCustom2_Click);
			// 
			// colorComboBox2
			// 
			this.colorComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.colorComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.colorComboBox2.FormattingEnabled = true;
			this.colorComboBox2.Location = new System.Drawing.Point(235, 201);
			this.colorComboBox2.MyColors = new string[0];
			this.colorComboBox2.Name = "colorComboBox2";
			this.colorComboBox2.Size = new System.Drawing.Size(199, 22);
			this.colorComboBox2.TabIndex = 13;
			this.colorComboBox2.SelectedIndexChanged += new System.EventHandler(this.colorComboBox2_SelectedIndexChanged);
			this.colorComboBox2.SelectionChangeCommitted += new System.EventHandler(this.colorComboBox2_SelectionChangeCommitted);
			// 
			// colorComboBox1
			// 
			this.colorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.colorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.colorComboBox1.FormattingEnabled = true;
			this.colorComboBox1.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Orange",
            "Pink"});
			this.colorComboBox1.Location = new System.Drawing.Point(12, 201);
			this.colorComboBox1.MyColors = new string[] {
        "Black",
        "Red",
        "Blue",
        "Green",
        "Yellow",
        "Orange",
        "Pink"};
			this.colorComboBox1.Name = "colorComboBox1";
			this.colorComboBox1.Size = new System.Drawing.Size(193, 22);
			this.colorComboBox1.TabIndex = 11;
			this.colorComboBox1.SelectionChangeCommitted += new System.EventHandler(this.colorComboBox1_SelectionChangeCommitted);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 287);
			this.Controls.Add(this.buttonCustom2);
			this.Controls.Add(this.buttonCustom1);
			this.Controls.Add(this.checkBoxItalic);
			this.Controls.Add(this.checkBoxBold);
			this.Controls.Add(this.checkBoxInvert);
			this.Controls.Add(this.checkBoxIgnore);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.colorComboBox2);
			this.Controls.Add(this.colorComboBox1);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxString);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonPageDown);
			this.Controls.Add(this.buttonPageUp);
			this.Controls.Add(this.buttonMoveDown);
			this.Controls.Add(this.buttonMoveUp);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAdd);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Highlighting";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonPageUp;
		private System.Windows.Forms.Button buttonPageDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxString;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Button buttonSave;
		private ColorComboBox colorComboBox1;
		private ColorComboBox colorComboBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.CheckBox checkBoxIgnore;
		private System.Windows.Forms.CheckBox checkBoxInvert;
		private System.Windows.Forms.CheckBox checkBoxBold;
		private System.Windows.Forms.CheckBox checkBoxItalic;
		private System.Windows.Forms.Button buttonCustom1;
		private System.Windows.Forms.Button buttonCustom2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ColorDialog colorDialog2;
	}
}