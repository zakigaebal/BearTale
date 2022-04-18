using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BearTale
{
	public partial class Form2 : Form
	{
		private bool _cancelEdit = false;
		ListViewItem curItem;
		ListViewItem.ListViewSubItem curSbItem;
		DataGridViewTextBoxColumn textboxColumn = new DataGridViewTextBoxColumn();
		public Form2()
		{
			InitializeComponent();
			oData = new clsData();

		}

		private clsData oData { get; set; }
		private BindingSource oBS = new BindingSource();
		public static int Compare(String strA, String strB, bool ignoreCase)
		{
			if (ignoreCase)
			{
				return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase);
			}
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.None);
		}
		//		bool output = Regex.IsMatch("foo", "FOO", RegexOptions.IgnoreCase);

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textBoxString.Text == "")
			{
				return;
			}
			// 데이터그리드뷰 row1줄 추가
			dataGridView1.Rows.Add(1);

			// 데이터그리드뷰 value값 지정
			//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.ForeColor = Color.FromName(colorComboBox1.Text);
			//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.BackColor = Color.FromName(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value.ToString());

			//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.ForeColor = Color.FromName(colorComboBox1.Text);
			//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.BackColor = Color.FromName(colorComboBox2.Text);

			//// 체크박스가 볼드가 트루이면
			//if (checkBoxBold.Checked)
			//{
			//	dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
			//}
			////체크박스가 이태릭이 트루이면
			//if (checkBoxItalic.Checked)
			//{
			//	dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
			//}
			//if (checkBoxBold.Checked == true && checkBoxItalic.Checked == true)
			//{
			//	dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold | FontStyle.Italic);
			//}
			//대소문자 구분안하기 기능 체크박스
			if (checkBoxIgnore.Checked)
			{
				String str = textBoxString.Text.ToString().ToLower();
				String strA = textBoxString.Text.ToString().ToUpper();
				StringComparison comp = StringComparison.OrdinalIgnoreCase;

				bool ignoreCase = false;
				if (ignoreCase)
				{
					ignoreCase = true;
				}
				//	Boolean result = str.Contains(value, comp);
				//	Console.WriteLine($"Does string contain specified substring? {result}");
				//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].
			}
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = textBoxString.Text;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = textBoxString.Text;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = colorComboBox1.Text;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = colorComboBox2.Text;
			//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = Color.FromName(colorComboBox1.Text);
			//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = Color.FromName(colorComboBox2.Text);
			//ignoreCase
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = checkBoxIgnore.Checked.ToString();
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = checkBoxInvert.Checked.ToString();
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = checkBoxBold.Checked.ToString();
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7].Value = checkBoxItalic.Checked.ToString();

			//dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Style.Font.ToString() ;
			//데이터그리드뷰 끝으로이동
			//dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
			//데이터그리드뷰 현재셀 취소
			//dataGridView1.CurrentCell = null;
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}
			int currentRow = dataGridView1.CurrentCell.RowIndex;

			//데이터그리드뷰 해당row셀 삭제
			dataGridView1.Rows.Remove(dataGridView1.Rows[currentRow]);
		}

		private void buttonMoveUp_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGridView1;
			try
			{
				int totalRows = dgv.Rows.Count;
				// get index of the row for the selected cell
				int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
				if (rowIndex == 0)
					return;
				// get index of the column for the selected cell
				int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.Rows.Remove(selectedRow);
				dgv.Rows.Insert(rowIndex - 1, selectedRow);
				dgv.ClearSelection();
				dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
			}
			catch { }



			//int index = listBox1.SelectedIndex;
			//string listBoxItemText = listBox1.SelectedItem.ToString();

			//if (index > 0)
			//{
			//	listBox1.Items.RemoveAt(index);
			//	listBox1.Items.Insert(index - 1, listBoxItemText);
			//	listBox1.SetSelected(index - 1, true);
			//}
		}

		private int GetSelectedRowIndex(DataGridView dgv)
		{
			if (dgv.Rows.Count == 0)
			{
				return 0;
			}
			foreach (DataGridViewRow row in dgv.Rows)
			{
				if (row.Selected)
				{
					return row.Index;
				}
			}
			return 0;
		}

		private void TaskViewEditHelper_OnUpStep(object sender, EventArgs e)
		{

			if (this.dataGridView1.SelectedRows == null || this.dataGridView1.SelectedRows.Count == 0)
			{
				//	Xtramessagebox.Show("please select a row first, click the first column to select the middle row");
			}
			else
			{
				if (this.dataGridView1.SelectedRows[0].Index <= 0)
				{
					//	Xtramessagebox.Show("this line is already at the top and cannot be moved up! "";

				}
				else
				{
					//Note: This is the move up line for unbound data
					//Selected line number  
					int selectedRowIndex = GetSelectedRowIndex(this.dataGridView1);
					if (selectedRowIndex >= 1)
					{
						//Copy selected lines  
						DataGridViewRow newRow = dataGridView1.Rows[selectedRowIndex];
						//Delete selected rows  
						dataGridView1.Rows.Remove(dataGridView1.Rows[selectedRowIndex]);
						//Insert the copied row into the previous row selected  
						dataGridView1.Rows.Insert(selectedRowIndex - 1, newRow);
						dataGridView1.ClearSelection();
						//Select the initially selected row 
						dataGridView1.Rows[selectedRowIndex - 1].Selected = true;
					}
				}
			}
		}


		private void buttonMoveDown_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGridView1;
			try
			{
				int totalRows = dgv.Rows.Count;
				// get index of the row for the selected cell
				int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
				if (rowIndex == totalRows - 1)
					return;
				// get index of the column for the selected cell
				int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.Rows.Remove(selectedRow);
				dgv.Rows.Insert(rowIndex + 1, selectedRow);
				dgv.ClearSelection();
				dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
			}
			catch { }
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			string filename = "high.xml";
			List<List<string>> data = new List<List<string>>();
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				List<string> rowData = new List<string>();
				foreach (DataGridViewCell cell in row.Cells)
					//		rowData.Add(cell)
					rowData.Add(cell.FormattedValue.ToString());
				data.Add(rowData);
			}
			XmlSerializer xs = new XmlSerializer(data.GetType());
			using (TextWriter tw = new StreamWriter(filename))
			{
				xs.Serialize(tw, data);
				tw.Close();
			}
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			string fileName = "high.xml";
			List<List<string>> data = new List<List<string>>();
			XmlSerializer xs = new XmlSerializer(data.GetType());
			using (TextReader tr = new StreamReader(fileName))
				data = (List<List<string>>)xs.Deserialize(tr);
			foreach (List<string> rowData in data)
				dataGridView1.Rows.Add(rowData.ToArray());
			
		}



		private void buttonPageUp_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGridView1;
			try
			{
				int totalRows = dgv.Rows.Count;
				// get index of the row for the selected cell
				int rowNumber = 0;
				int rowIndex = dgv.SelectedCells[rowNumber].OwningRow.Index;
				if (rowIndex == 0)
					return;
				// get index of the column for the selected cell
				int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.ClearSelection();
				if (rowIndex - 10 < 0)
				{
					dgv.Rows[0].Cells[colIndex].Selected = true;
				}
				else dgv.Rows[rowIndex - 10].Cells[colIndex].Selected = true;
			}
			catch { }

		}

		private void buttonPageDown_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGridView1;
			try
			{
				int totalRows = dgv.Rows.Count;
				// get index of the row for the selected cell
				int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
				if (rowIndex == totalRows - 1)
					return;
				// get index of the column for the selected cell
				int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.Rows.Remove(selectedRow);
				dgv.Rows.Insert(rowIndex + 1, selectedRow);
				dgv.ClearSelection();
				if (dgv.Rows[dataGridView1.Rows.Count - 1].Cells[colIndex].Value == null)
				{
					dgv.Rows[dataGridView1.Rows.Count - 1].Cells[colIndex].Selected = true;
				}
				else dgv.Rows[rowIndex + 10].Cells[colIndex].Selected = true;
			}
			catch { }
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			dataGridView1.BringToFront();


			//dataGridView1.Columns.Add(textboxColumn);

			//textboxColumn.HeaderText = "color";
			dataGridView1.Columns.Add(textboxColumn);
			dataGridView1.Columns.Add("stringText", "내용");
			dataGridView1.Columns.Add("foregroundColor", "글자색");
			dataGridView1.Columns.Add("backgroundColor", "배경색");
			dataGridView1.Columns.Add("ignorecase", "ignorecase");
			dataGridView1.Columns.Add("invertmatch", "invertmatch");
			dataGridView1.Columns.Add("bold", "bold");
			dataGridView1.Columns.Add("italic", "italic");



			dataGridView1.AllowUserToAddRows = false;
			DataTable table = new DataTable();
			DataColumn col = new DataColumn("Name", typeof(TextBoxBase));
			table.Columns.Add(col);

			dataGridView1.Columns[0].Width = 50;
			dataGridView1.Columns[1].Width = 100;
			//dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.GridColor = Color.White;
			//dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.SelectAll();

			//mycolors.
			colorComboBox1.Items.Add("Custom");
			colorComboBox1.Items.Add("White");
			colorComboBox1.Items.Add("Red");
			colorComboBox1.Items.Add("Green");
			colorComboBox1.Items.Add("Blue");
			colorComboBox1.Items.Add("Yellow");
			colorComboBox1.Items.Add("Cyan");
			colorComboBox1.Items.Add("Magenta");
			colorComboBox1.Items.Add("DarkRed");
			colorComboBox1.Items.Add("DarkGreen");
			colorComboBox1.Items.Add("DarkBlue");
			colorComboBox1.Items.Add("DarkYellow");
			colorComboBox1.Items.Add("DarkCyan");
			colorComboBox1.Items.Add("DarkMagenta");

			colorComboBox2.Items.Add("Custom");
			colorComboBox2.Items.Add("White");
			colorComboBox2.Items.Add("Red");
			colorComboBox2.Items.Add("Green");
			colorComboBox2.Items.Add("Blue");
			colorComboBox2.Items.Add("Yellow");
			colorComboBox2.Items.Add("Cyan");
			colorComboBox2.Items.Add("Magenta");
			colorComboBox2.Items.Add("DarkRed");
			colorComboBox2.Items.Add("DarkGreen");
			colorComboBox2.Items.Add("DarkBlue");
			colorComboBox2.Items.Add("DarkYellow");
			colorComboBox2.Items.Add("DarkCyan");
			colorComboBox2.Items.Add("DarkMagenta");


			colorComboBox1.SelectedIndex = 3;
			colorComboBox2.SelectedIndex = 5;

			dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;
			//dataGridView1.MultiSelect = true;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView1.ReadOnly = true;
			dataGridView1.ColumnHeadersVisible = true;

			buttonLoad_Click(sender, e);
		}


		private void colorComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}
			int rowIndex = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows[rowIndex].Cells[0].Style.ForeColor = Color.FromName(colorComboBox1.Text);
			//textboxColumn.DefaultCellStyle.ForeColor = Color.FromName(colorComboBox1.Text);
		}

		private void colorComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}
			int rowIndex = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows[rowIndex].Cells[0].Style.BackColor = Color.FromName(colorComboBox2.Text);
			//textboxColumn.DefaultCellStyle.BackColor = Color.FromName(colorComboBox2.Text);
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
			using (Brush brush = new SolidBrush(Color.Black))
			{
				e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, e.RowBounds.Location.X + 30, e.RowBounds.Location.Y + 4, drawFormat);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			textBoxString.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			//	colorComboBox1.Text = textboxColumn.DefaultCellStyle.ForeColor.ToString();
			//	colorComboBox2.Text = textboxColumn.DefaultCellStyle.BackColor.ToString();
			colorComboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Style.ForeColor.Name.ToString();
			colorComboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor.Name.ToString();
			//if (dataGridView1.Columns[0].DefaultCellStyle.Font == new Font(dataGridView1.Rows[e.RowIndex].Cells[0].Style.Font, FontStyle.Bold))
			//{
			//	checkBoxBold.Checked = true;
			//}

			// 내가원하는 Columns의 index값과 기본 font의 값이 필요
			// DataGridView.Columns[i].DefaultCellStyle.Font = new Font(DataGridView.Columns[i].DefaultCellStyle.Font, FontStyle.Underline); 
			// 만약 특정 셀의 Font가 없는 경우는 아래의 코드 참고
			// DataGridView.Columns[i].DefaultCellStyle.Font = new Font(DataGridView.DefaultCellStyle.Font, FontStyle.Underline); 
			// 실제 예시
			// dgvODBCList.Columns[1].DefaultCellStyle.Font = new Font(dgvODBCList.DefaultCellStyle.Font, FontStyle.Underline);


		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			Form1 Mainform = (Form1)Owner;
			//데이터그리드뷰내용저장하기
			buttonSave_Click(sender, e);
			//int rowindex = dataGridView1.CurrentRow.Index;
			//string rowValue = dataGridView1.Rows[rowindex].Cells[1].Value.ToString().Trim();
			//if (rowValue.Contains("1"))
			//{
			//	dataGridView1.Rows[rowindex].Cells[0].Style.ForeColor = Color.FromName(colorComboBox1.Text);
			//	dataGridView1.Rows[rowindex].Cells[0].Style.BackColor = Color.FromName(colorComboBox2.Text);
			//}
			this.Close();
		}

		private void textBoxString_TextChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}
			int rowIndex = dataGridView1.CurrentCell.RowIndex;


			dataGridView1.Rows[rowIndex].Cells[0].Value = textBoxString.Text;
			dataGridView1.Rows[rowIndex].Cells[1].Value = textBoxString.Text;

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonCustom1_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				if (dataGridView1.CurrentCell == null)
				{
					colorComboBox1.ForeColor = colorDialog1.Color;
					colorComboBox1.Text = "Custom";
					return;
				}
				dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Style.ForeColor = colorDialog1.Color;
				colorComboBox1.Text = "Custom";
			}
		}

		private void buttonCustom2_Click(object sender, EventArgs e)
		{
			if (colorDialog2.ShowDialog() == DialogResult.OK)
			{
				if (dataGridView1.CurrentCell == null)
				{
					colorComboBox2.ForeColor = colorDialog2.Color;
					colorComboBox2.Text = "Custom";
					return;
				}
				dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Style.BackColor = colorDialog1.Color;
				colorComboBox2.Text = "Custom";

			}
		}


		//컬러클래스
		public class MyListBoxItem
		{
			public MyListBoxItem(TextBox textcolor, Color c, string m)
			{
				textboxColor = textcolor;
				ItemColor = c;
				Message = m;
			}
			public TextBox textboxColor { get; set; }
			public Color ItemColor { get; set; }
			public string Message { get; set; }
		}

		private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}
			int rowindex = dataGridView1.CurrentCell.RowIndex;

			//체크박스볼드가 체크되었을때
			if (checkBoxBold.Checked == true && checkBoxItalic.Checked == false)
			{
	//			dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();
			}
			//체크박스이테릭 체크되었을때
			if (checkBoxBold.Checked == false && checkBoxItalic.Checked == true)
			{
		//		dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();
			}
			//체크박스가 둘다 체크되었을때
			if (checkBoxBold.Checked == true && checkBoxItalic.Checked == true)
			{
			//	dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold | FontStyle.Italic);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();
			}
			//체크박스가 둘다 체크안되었을때
			if (checkBoxBold.Checked == false && checkBoxItalic.Checked == false)
			{
				//dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();
			}
		}


		private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			//		 dataGridView1.Columns[0].DefaultHeaderCellType.BorderColor = System.Drawing.Color.Red;
		}


		private void FileListView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}

			int rowindex = dataGridView1.CurrentCell.RowIndex;

			//체크박스이테릭만 체크되었을때
			if (checkBoxBold.Checked == false && checkBoxItalic.Checked == true)
			{
				dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();
			}
			//체크박스볼드만 체크일때
			if (checkBoxBold.Checked == true && checkBoxItalic.Checked == false)
			{
				dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();
			}
			//체크박스가 둘다 체크되었을때
			if (checkBoxBold.Checked == true && checkBoxItalic.Checked == true)
			{
				dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold | FontStyle.Italic);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();

			}
			//체크박스가 둘다 체크안되었을때
			if (checkBoxBold.Checked == false && checkBoxItalic.Checked == false)
			{
				dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
				dataGridView1.Rows[rowindex].Cells[6].Value = checkBoxBold.Checked.ToString();
				dataGridView1.Rows[rowindex].Cells[7].Value = checkBoxItalic.Checked.ToString();
			}

			//if (checkBoxItalic.Checked)
			//{
			//	checkBoxBold.Checked = false;
			//	dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
			//}
			//else
			//{
			//	dataGridView1.Rows[rowindex].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
			//}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			MessageBox.Show("선택한 row의 0번째cell의 값 == " + dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
			//MessageBox.Show("선택한 row의 0번째cell의 값 == " + dataGridView1.Rows[e.RowIndex].Cells[0].col.ToString());
		}

		private void btnGetData_Click(object sender, EventArgs e)
		{
			DataTable oTable = oData.GetData();
			oBS.DataSource = oTable;
			dataGridView1.DataSource = oBS;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DataTable oTable = (DataTable)oBS.DataSource;
			DataView oDV = new DataView(oTable, "", "", DataViewRowState.ModifiedCurrent);
			foreach (DataRowView oRow in oDV)
			{
				//write each row to the database as all of them have changed
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string a = "a";
			string A = "a";
			bool ta = false;
			Compare(a, A, ta);
			MessageBox.Show(ta.ToString());
		}

		private void checkBoxInvert_CheckedChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}

			int rowindex = dataGridView1.CurrentCell.RowIndex;

			dataGridView1.Rows[rowindex].Cells[5].Value = checkBoxInvert.Checked.ToString();

		}

		private void checkBoxIgnore_CheckedChanged(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell == null)
			{
				return;
			}
			int rowindex = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows[rowindex].Cells[4].Value = checkBoxIgnore.Checked.ToString();
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.FromName(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value.ToString());
				dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.FromName(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value.ToString());

				// 체크박스가 볼드가 True이고 체크박스 이태릭이 False일때
					if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "True" && dataGridView1.Rows[i].Cells[7].Value.ToString() == "False")
				{
					dataGridView1.Rows[i].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
				}
				//체크박스가 이태릭이 트루이고 볼드는 false일때
			  else if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "True" && dataGridView1.Rows[i].Cells[6].Value.ToString() == "False")
				{
					dataGridView1.Rows[i].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
				}
				//체크박스 둘다 트루
				else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "True" && dataGridView1.Rows[i].Cells[6].Value.ToString() == "True")
				{
					dataGridView1.Rows[i].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold | FontStyle.Italic);
				}
				//체크박스가 둘다 아닐때
				else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "False" && dataGridView1.Rows[i].Cells[6].Value.ToString() == "False")
				{
					dataGridView1.Rows[i].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
				}
			}
		}
	}
}



