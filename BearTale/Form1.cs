using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BearTale
{
	public partial class Form1 : Form
	{
		private int rowIndexOfItemUnderMouseToDrop;
		private int rowIndexFromMouseDown;
		delegate void view(string value, string type, string checkPath);
		private view view_event;
		DataGridView dgv = new DataGridView();
		//탭페이지 선언
		TabPage page = new TabPage();

		public Form1()
		{
			InitializeComponent();
		}

		private void addTab()
		{
			try
			{
				string filePath = string.Empty;
				string fileName = string.Empty;
				string fileContent = string.Empty;

				using (OpenFileDialog fd = new OpenFileDialog())
				{
					fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //바탕화면으로 기본폴더 설정
					if (fd.ShowDialog() == DialogResult.OK)
					{
						filePath = fd.FileName; //전체 경로와 파일명 
						fileName = fd.SafeFileName; //선택한 파일명은 fd.SafeFileName

						//경로텍스트박스 초기화
						toolStripTextBoxPath.Clear();
						//경로텍스트박스 경로내용추가
						toolStripTextBoxPath.AppendText(fileName);
						//데이터그리드뷰 선언
						dgv.Dock = DockStyle.Fill;
						//dgv에 내용 입력
						dgv.Columns.Add("content", "");
						dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
						dgv.ColumnHeadersVisible = false;
						//dgv row 번호입력
						dgv.RowPostPaint += dgv_RowPostPaint;

						//datagridview suspendlayout
						dgv.SuspendLayout();
						//한줄씩 읽고 추가하기
						string[] contents = System.IO.File.ReadAllLines(filePath);
						if (contents.Length > 0)
						{
							for (int i = 0; i < contents.Length; i++)
							{
								dgv.Rows.Add(contents[i]);
							}
						}
						//datagrudvuew resumelayout
						dgv.ResumeLayout();


						//탭페이지 선언
						TabPage page = new TabPage(fileName);

						//탭페이지에 데이터그리드뷰 dgv 입력
						page.Controls.Add(dgv);
						//탭컨트롤에 탭페이지 추가
						tabControl1.TabPages.Add(page);

					}
					else
					{
						return; //취소했을때 함수 종료 (함수가 void일 경우에 해당)
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			//탭추가
			addTab();
		}

		//폴더 감시
		private void FolderCheck(string checkPath)
		{
			System.IO.FileSystemWatcher watcher = new System.IO.FileSystemWatcher();
			watcher.Path = checkPath;
			watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;

			watcher.Changed += new FileSystemEventHandler(Changed);
			//watcher.Created += new FileSystemEventHandler(Changed);
			//watcher.Deleted += new FileSystemEventHandler(Changed);
			//watcher.Renamed += new RenamedEventHandler(Renamed);
			watcher.EnableRaisingEvents = true;
			view_event += new view(Form1_view_event);
		}

		private void Form1_view_event(string value, string type, string checkPath)
		{
			//datagridview suspendlayout
			dgv.SuspendLayout();
			//한줄씩 읽고 추가하기
			string[] contents = System.IO.File.ReadAllLines(checkPath);
			if (contents.Length > 0)
			{
				for (int i = 0; i < contents.Length; i++)
				{
					dgv.Rows.Add(contents[i]);
				}
			}
			//datagrudvuew resumelayout
			dgv.ResumeLayout();
		}


		private void openFile()
		{
			try
			{
				string filePath = string.Empty;
				string fileContent = string.Empty;

				using (OpenFileDialog fd = new OpenFileDialog())
				{
					fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //바탕화면으로 기본폴더 설정
					if (fd.ShowDialog() == DialogResult.OK)
					{
						filePath = fd.FileName; //전체 경로와 파일명 //선택한 파일명은 fd.SafeFileName

						//경로텍스트박스 초기화
						toolStripTextBoxPath.Clear();
						//경로텍스트박스 경로내용추가
						toolStripTextBoxPath.AppendText(filePath);
						page.Text = filePath;

						//데이터그리드뷰 초기화
						dgv.Rows.Clear();
						dgv.Columns.Add("content", "");
						dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
						dgv.ColumnHeadersVisible = false;

						//datagridview suspendlayout
						dgv.SuspendLayout();
						//한줄씩 읽고 추가하기
						string[] contents = System.IO.File.ReadAllLines(filePath);
						if (contents.Length > 0)
						{
							for (int i = 0; i < contents.Length; i++)
							{
								dgv.Rows.Add(contents[i]);
							}
						}
						//datagrudvuew resumelayout
						dgv.ResumeLayout();
					}
					else
					{
						return; //취소했을때 함수 종료 (함수가 void일 경우에 해당)
					}
				}
				//string checkPath = filePath;
				//FolderCheck(checkPath);

			}
			catch (Exception)
			{
			}
		}

		private void Changed(object sender, FileSystemEventArgs e)
		{
			string msg = "File: " + e.FullPath + ". Change : " + e.ChangeType;
			this.Invoke(view_event, new object[] { msg, "0" });
		}
		private void Renamed(object source, RenamedEventArgs e)
		{
			string msg = "File: " + e.OldFullPath + " renamed to " + e.FullPath;
			this.Invoke(view_event, new object[] { msg, "1" });
		}

		private void highLighting()
		{
			try
			{
				Form2 newform2 = new Form2();
				newform2.ShowDialog(this);
			}
			catch (Exception)
			{
			}
		}


		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			highLighting();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			dgv.GridColor = Color.White;
			dgv.CurrentCell = null;

			page.Text = "";
			OnFile = new OnDelegateFile(ListViewAdd); //OnFile 델리게이트에서 ListViewAdd를 실행시키자.
			dgv.ReadOnly = true;
			comboBoxUtf.Items.Add("UTF-8");
			comboBoxUtf.SelectedIndex = 0;

			dgv.CellFormatting += dgv_CellFormatting;
		}

		private void ListViewAdd(string fn, string fl, string fc) //리스트뷰에 들어온 데이터를 추가하자 
		{
			dgv.Columns.Add("1", "1");
			dgv.Columns.Add("2", "2");
			dgv.Columns.Add("3", "3");
			string fSize = GetFileSize(Convert.ToDouble(fl));
			this.dgv.Rows.Add(new ListViewItem(new string[] { fn, fc, fSize }));
		}


		private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
			toolStripButton1_Click(sender, e);
		}
		private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//Form2 highLightForm = (Form2)Owner;
			//highLightForm form2 = (Form2)highLightForm;
			string fileName = "high.xml";
			List<List<string>> data = new List<List<string>>();
			XmlSerializer xs = new XmlSerializer(data.GetType());
			using (TextReader tr = new StreamReader(fileName))
				data = (List<List<string>>)xs.Deserialize(tr);


			foreach (List<string> rowData in data)
			{
				if (rowData.ToArray() == rowData.ToArray())
				{
					dgv.Rows[0].Cells[0].Style.ForeColor = Color.Red;
				}
				// dgv.Rows[0].Cells[0].Style.ForeColor =	rowData.First.ToString();
				//dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.FromName(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value.ToString());
				//				dgv.Rows.Add(rowData.ToArray());
			}

		}

		Thread threadFileView = null; //파일조회 스레드 개체 생성
		private delegate void OnDelegateFile(string fn, string fl, string fc);
		private OnDelegateFile OnFile = null; //델리게이트 생성
		bool HiddenFile = true; //전체 조회, False 일때는 숨김파일이 아닌경우만 조회

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.dgv.Rows.Clear();
				this.toolStripTextBoxPath.Text = this.folderBrowserDialog1.SelectedPath;

				threadFileView = new Thread(new ParameterizedThreadStart(FileView));
				threadFileView.Start(this.folderBrowserDialog1.SelectedPath); ///선택된 디렉토리를 매개변수로 넘기자.
			}

		}

		private string GetFileSize(double byteCount) //파일사이즈를 Bytes,KB,MB,GB 단위로 표현하자.
		{
			string size = "0 Bytes";
			if (byteCount >= 1024 * 1024 * 1024)
				size = String.Format("{0:##.##}", byteCount / (1024 * 1024 * 1024)) + " GB";
			else if (byteCount >= 1024 * 1024)
				size = String.Format("{0:##.##}", byteCount / (1024 * 1024)) + " MB";
			else if (byteCount >= 1024)
				size = String.Format("{0:##.##}", byteCount / 1024) + " KB";
			else if (byteCount > 0 && byteCount < 1024.0)
				size = byteCount.ToString() + " Bytes";

			return size;
		}


		private void FileView(object dir)
		{
			DirectoryInfo di = new DirectoryInfo((string)dir);
			DirectoryInfo[] dti = di.GetDirectories();

			foreach (var f in di.GetFiles())
			{
				if (HiddenFile == true) //전체 파일을 모두 조회한다.
				{
					Invoke(OnFile, f.Name, f.Length.ToString(),
							f.CreationTime.ToString());
				}
				else
				{
					if (!f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString())) // 속성이 숨김파일이 아닐 때만 조회한다.
					{
						Invoke(OnFile, f.Name, f.Length.ToString(),
								f.CreationTime.ToString());
					}
				}
			}

			for (int i = 0; i < di.GetDirectories().Length; i++) ///하위 디렉토리 파일을 조회 하자.
			{
				try
				{
					FileView(dti[i].FullName);
				}
				catch
				{
					continue;
				}
			}
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void clearToolStripMenuItemClear_Click(object sender, EventArgs e)
		{
			tabControl1.Controls.Remove(tabControl1.SelectedTab);
		}

		private void aboutBearTaliToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void highlightingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			highLighting();
		}

		private void checkBoxTail_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void tabControl1_DragDrop(object sender, DragEventArgs e)
		{
			Point clientPoint = dgv.PointToClient(new Point(e.X, e.Y));
			rowIndexOfItemUnderMouseToDrop = dgv.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

			if (e.Effect == DragDropEffects.Move)
			{
				// get 한 행을 삭제하고 원하는 위치에 넣어줍니다.
				DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
				dgv.Rows.RemoveAt(rowIndexFromMouseDown);
				dgv.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
			}
		}

		private void viewToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}