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
			listBox1.Items.Add(textBoxString.Text);
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
			listBox1.BackColor = Color.FromName(colorComboBox2.Text);

		}



	}
}


