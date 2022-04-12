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
			this.listBox1 = new System.Windows.Forms.ListBox();
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
			this.button8 = new System.Windows.Forms.Button();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.colorComboBox2 = new BearTale.ColorComboBox();
			this.colorComboBox1 = new BearTale.ColorComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(522, 148);
			this.listBox1.TabIndex = 0;
			this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 161);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(47, 23);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(59, 161);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Location = new System.Drawing.Point(134, 161);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
			this.buttonMoveUp.TabIndex = 3;
			this.buttonMoveUp.Text = "Move Up";
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Location = new System.Drawing.Point(209, 161);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(88, 23);
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
			this.label2.Location = new System.Drawing.Point(294, 187);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "Background Color";
			// 
			// buttonPageUp
			// 
			this.buttonPageUp.Location = new System.Drawing.Point(296, 161);
			this.buttonPageUp.Name = "buttonPageUp";
			this.buttonPageUp.Size = new System.Drawing.Size(63, 23);
			this.buttonPageUp.TabIndex = 4;
			this.buttonPageUp.Text = "Page Up";
			this.buttonPageUp.UseVisualStyleBackColor = true;
			this.buttonPageUp.Click += new System.EventHandler(this.buttonPageUp_Click);
			// 
			// buttonPageDown
			// 
			this.buttonPageDown.Location = new System.Drawing.Point(359, 161);
			this.buttonPageDown.Name = "buttonPageDown";
			this.buttonPageDown.Size = new System.Drawing.Size(88, 23);
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
			this.textBoxString.Size = new System.Drawing.Size(519, 21);
			this.textBoxString.TabIndex = 6;
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(384, 265);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(459, 265);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 8;
			this.button8.Text = "CANCEL";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(447, 161);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 23);
			this.buttonLoad.TabIndex = 9;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(489, 161);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(45, 23);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(165, 201);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 12;
			this.textBox1.Text = "asdas";
			// 
			// colorComboBox2
			// 
			this.colorComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.colorComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.colorComboBox2.FormattingEnabled = true;
			this.colorComboBox2.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
			this.colorComboBox2.Location = new System.Drawing.Point(296, 203);
			this.colorComboBox2.MyColors = new string[] {
        "Black",
        "Red",
        "Blue",
        "Green"};
			this.colorComboBox2.Name = "colorComboBox2";
			this.colorComboBox2.Size = new System.Drawing.Size(121, 22);
			this.colorComboBox2.TabIndex = 13;
			this.colorComboBox2.SelectionChangeCommitted += new System.EventHandler(this.colorComboBox2_SelectionChangeCommitted);
			// 
			// colorComboBox1
			// 
			this.colorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.colorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.colorComboBox1.FormattingEnabled = true;
			this.colorComboBox1.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Orange"});
			this.colorComboBox1.Location = new System.Drawing.Point(12, 201);
			this.colorComboBox1.MyColors = new string[] {
        "Black",
        "Red",
        "Blue",
        "Green",
        "Yellow",
        "Orange"};
			this.colorComboBox1.Name = "colorComboBox1";
			this.colorComboBox1.Size = new System.Drawing.Size(121, 22);
			this.colorComboBox1.TabIndex = 11;
			this.colorComboBox1.SelectionChangeCommitted += new System.EventHandler(this.colorComboBox1_SelectionChangeCommitted);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(459, 198);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 289);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.colorComboBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.colorComboBox1);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.button8);
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
			this.Controls.Add(this.listBox1);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Highlighting";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
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
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Button buttonSave;
		private ColorComboBox colorComboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private ColorComboBox colorComboBox2;
		private System.Windows.Forms.Button button1;
	}
}