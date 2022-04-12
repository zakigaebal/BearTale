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
			TextBox textboxColor = new TextBox();
			textboxColor.Text = colorComboBox1.Text;
			textboxColor.ForeColor = Color.FromName(colorComboBox1.Text);
			textboxColor.BackColor = Color.FromName(colorComboBox2.Text);
			
			listBox1.Items.Add(new MyListBoxItem(textboxColor, Color.FromName(colorComboBox1.Text), textBoxString.Text));
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			listBox1.Items.Remove(listBox1.SelectedItem);
		}

		private void buttonMoveUp_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			string listBoxItemText = listBox1.SelectedItem.ToString();
			if (index > 0)
			{
				listBox1.Items.RemoveAt(index);
				listBox1.Items.Insert(index - 1, listBoxItemText);
				listBox1.SetSelected(index - 1, true);
			}
		}

		private void buttonMoveDown_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			string listBoxItemText = listBox1.SelectedItem.ToString();
			if (index < listBox1.Items.Count - 1)
			{
				listBox1.Items.RemoveAt(index);
				listBox1.Items.Insert(index + 1, listBoxItemText);
				listBox1.SetSelected(index + 1, true);
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				StreamWriter sw;
				sw = new StreamWriter("highilight.txt");
				int nCount = listBox1.Items.Count;
				for (int i = 0; i < nCount; i++)
				{
					listBox1.Items[i] += "\r\n";
					sw.Write(listBox1.Items[i]);
				}
				sw.Close();
			}
			catch (Exception ex)
			{
			}
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			try
			{
				listBox1.Items.Clear();
				string currentPath = System.IO.Directory.GetCurrentDirectory();
				StreamReader file = new StreamReader(currentPath + "\\highilight.txt", Encoding.Default);
				string s = "";
				while (s != null)
				{
					s = file.ReadLine();
					if (!string.IsNullOrEmpty(s)) listBox1.Items.Add(s);
				}
				file.Close();
			}
			catch (Exception ex)
			{
			}
		}

		private void buttonPageUp_Click(object sender, EventArgs e)
		{
			listBox1.SelectedIndex = 0;
		}

		private void buttonPageDown_Click(object sender, EventArgs e)
		{
			listBox1.SelectedIndex = listBox1.Items.Count - 1;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			colorComboBox1.SelectedIndex = 0;
			colorComboBox2.SelectedIndex = 0;
		
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

		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1) return;    //아이템이 없는 경우 는 할 일이 없습니다.
			MyListBoxItem item = listBox1.Items[e.Index] as MyListBoxItem;
			if (item != null)
			{
				e.Graphics.DrawString(
						item.Message,
						listBox1.Font,
						new SolidBrush(item.ItemColor),
						0,
						e.Index * listBox1.ItemHeight
				);
			}

			else

			{

				// The item isn't a MyListBoxItem, do something about it

			}

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
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

		private void button1_Click(object sender, EventArgs e)
		{
		//	listBox1.Items.Add(new MyListBoxItem(Color.FromName(colorComboBox1.Text), Color.FromName(colorComboBox2.Text), "빨간색 ==== Red Color"));
		}
	}
}


