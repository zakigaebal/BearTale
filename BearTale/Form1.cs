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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				string filePath = string.Empty;
				string fileContent = string.Empty;
				//string[] contents = null;

				using (OpenFileDialog fd = new OpenFileDialog())
				{
					fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //바탕화면으로 기본폴더 설정
																																															//fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //필터 설정
																																															//fd.FilterIndex = 1; //1번 선택시 txt , 2번 선택시 *.*
					if (fd.ShowDialog() == DialogResult.OK)
					{
						filePath = fd.FileName; //전체 경로와 파일명 //선택한 파일명은 fd.SafeFileName
					}
				}
				//경로텍스트박스 초기화
				toolStripTextBoxPath.Clear();
				//경로텍스트박스 경로내용추가
				toolStripTextBoxPath.AppendText(filePath);

				dataGridView1.Columns.Add("content", "");
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dataGridView1.ColumnHeadersVisible = false;
				//한줄씩 읽고 추가하기
				string[] contents = System.IO.File.ReadAllLines(filePath);
				if (contents.Length > 0)
				{
					for (int i = 0; i < contents.Length; i++)
					{
						//(i+1).ToString() + 
						dataGridView1.Rows.Add(contents[i]);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			try
			{
				Form2 newform2 = new Form2();
				newform2.ShowDialog();
			}
			catch (Exception)
			{
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.GridColor = Color.White;
			dataGridView1.CurrentCell = null;
		}

		private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			numberCount(e);
		}

		private void toolStripTextBoxPath_Click(object sender, EventArgs e)
		{
		}

		void numberCount(DataGridViewRowPostPaintEventArgs e)
		{
			try
			{
				// row header 에 자동 일련번호 넣기
				StringFormat drawFormat = new StringFormat();
				//drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
				drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
				using (Brush brush = new SolidBrush(Color.Red))
				{
					e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
				}
			}
			catch (Exception)
			{
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton1_Click(sender,e);
		}
	}
}
