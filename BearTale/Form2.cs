using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BearTale
{
	public partial class Form2 : Form
	{
		DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
		public Form2()
		{
			InitializeComponent();
		}



		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textBoxString.Text == "")
			{
				return;
			}
			//TextBox textboxColor = new TextBox();
			//textboxColor.Visible = true;
			//textboxColor.Text = colorComboBox1.Text;
			//textboxColor.ForeColor = Color.FromName(colorComboBox1.Text);
			//textboxColor.BackColor = Color.FromName(colorComboBox2.Text);
			//MyListBoxItem newitem = new MyListBoxItem(textboxColor, Color.FromName(colorComboBox1.Text), textBoxString.Text);

			//textboxColumn.DefaultCellStyle.ForeColor = Color.FromName(colorComboBox1.Text);
			//textboxColumn.DefaultCellStyle.BackColor = Color.FromName(colorComboBox2.Text);

			dataGridView1.Rows.Add(1);
			int i = 0;

					//텍스트박스컬럼설정
	//		textboxColumn.Visible = true;
		//	textboxColumn.HeaderText = "컬러";

	//		dataGridView1.Rows.Add(textboxColumn, "s");
		//	textboxColumn.DefaultCellStyle.ForeColor = Color.FromName(colorComboBox1.Text);
			//textboxColumn.DefaultCellStyle.BackColor = Color.FromName(colorComboBox2.Text);

			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.ForeColor = Color.FromName(colorComboBox1.Text);
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.BackColor = Color.FromName(colorComboBox2.Text);
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = textBoxString.Text;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = textBoxString.Text;

			dataGridView1.CurrentCell = null;

		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			//listBox1.Items.Remove(listBox1.SelectedItem);
		}

		private void buttonMoveUp_Click(object sender, EventArgs e)
		{
			//int index = listBox1.SelectedIndex;
			//string listBoxItemText = listBox1.SelectedItem.ToString();
			//if (index > 0)
			//{
			//	listBox1.Items.RemoveAt(index);
			//	listBox1.Items.Insert(index - 1, listBoxItemText);
			//	listBox1.SetSelected(index - 1, true);
			//}
		}

		private void buttonMoveDown_Click(object sender, EventArgs e)
		{
			//int index = listBox1.SelectedIndex;
			//string listBoxItemText = listBox1.SelectedItem.ToString();
			//if (index < listBox1.Items.Count - 1)
			//{
			//	listBox1.Items.RemoveAt(index);
			//	listBox1.Items.Insert(index + 1, listBoxItemText);
			//	listBox1.SetSelected(index + 1, true);
			//}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	StreamWriter sw;
			//	sw = new StreamWriter("highilight.txt");
			//	int nCount = listBox1.Items.Count;
			//	for (int i = 0; i < nCount; i++)
			//	{
			//		listBox1.Items[i] += "\r\n";
			//		sw.Write(listBox1.Items[i]);
			//	}
			//	sw.Close();
			//}
			//catch (Exception ex)
			//{
			//}
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			try
			{
				//listBox1.Items.Clear();
				//string currentPath = System.IO.Directory.GetCurrentDirectory();
				//StreamReader file = new StreamReader(currentPath + "\\highilight.txt", Encoding.Default);
				//string s = "";
				//while (s != null)
				//{
				//	s = file.ReadLine();
				//	if (!string.IsNullOrEmpty(s)) listBox1.Items.Add(s);
				//}
				//file.Close();
			}
			catch (Exception ex)
			{
			}
		}

		private void buttonPageUp_Click(object sender, EventArgs e)
		{
			//listBox1.SelectedIndex = 0;
		}

		private void buttonPageDown_Click(object sender, EventArgs e)
		{
			//listBox1.SelectedIndex = listBox1.Items.Count - 1;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			colorComboBox1.SelectedIndex = 0;
			colorComboBox2.SelectedIndex = 1;

			
			dataGridView1.Columns.Add(textboxColumn);
			textboxColumn.HeaderText = "color";
			dataGridView1.Columns.Add("stringText", "내용");

			dataGridView1.AllowUserToAddRows = false;

			DataTable table = new DataTable();
			DataColumn col = new DataColumn("Name", typeof(TextBoxBase));
			table.Columns.Add(col);

			dataGridView1.Columns[0].Width = 50;
			dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.GridColor = Color.White;
			//dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}


		private void colorComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			textBox1.ForeColor = Color.FromName(colorComboBox1.Text);
			//listBox1.Items. = colorComboBox1.Text;
		}

		private void colorComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
		{
			textBox1.BackColor = Color.FromName(colorComboBox2.Text);
			//listBox1.BackColor = Color.FromName(colorComboBox2.Text);
		}

	

		private void colorComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{// row header 에 자동 일련번호 넣기
			StringFormat drawFormat = new StringFormat();
			//drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
			drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
			using (Brush brush = new SolidBrush(Color.Red))
			{
				e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			textBoxString.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}
	}



	//컬러클래스
	public class MyListBoxItem
		{
			public MyListBoxItem(TextBox textcolor, Color c,  string m)
			{
				textboxColor = textcolor;
				ItemColor = c;
				Message = m;
			}
			public TextBox textboxColor { get; set; }
			public Color ItemColor { get; set; }
			public string Message { get; set; }
		}

	
	}



