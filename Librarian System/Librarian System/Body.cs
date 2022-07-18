using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Librarian_System
{
	public partial class Body : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int IParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		public Body()
		{
			InitializeComponent();
		}	

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.Opacity <= 1)
			{
				this.Opacity += 1;
			}
			else
				logintimer.Stop();
		}

		private void Body_Load(object sender, EventArgs e)
		{
			
			this.Opacity = 0.2;
			logintimer.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form1 obj = new Form1();
			this.Hide();
			obj.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			
				if(e.Button==MouseButtons.Left)
				{
					ReleaseCapture();
					SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			
		}
		

		



		

		private void button5_Click(object sender, EventArgs e)
		{
			if (!ContentPanel.Controls.Contains(BorrowersUserControl.Instance))
			{
				ContentPanel.Controls.Add(BorrowersUserControl.Instance);
				BorrowersUserControl.Instance.Dock = DockStyle.Fill;
				BorrowersUserControl.Instance.BringToFront();
			}
			else
			{
				BorrowersUserControl.Instance.BringToFront();
			}
		}

		private void Book_tab_Click(object sender, EventArgs e)
		{
			if (! ContentPanel.Controls.Contains(BooksUserControl.Instance))
			{
				ContentPanel.Controls.Add(BooksUserControl.Instance);
				BooksUserControl.Instance.Dock = DockStyle.Fill;
				BooksUserControl.Instance.BringToFront();
			}
			else
			{
				BooksUserControl.Instance.BringToFront();
			}
		}

		private void Transaction_Tab_Click(object sender, EventArgs e)
		{
			if (!ContentPanel.Controls.Contains(TransactionUserControl.Instance))
			{
				ContentPanel.Controls.Add(TransactionUserControl.Instance);
				TransactionUserControl.Instance.Dock = DockStyle.Fill;
				TransactionUserControl.Instance.BringToFront();
			}
			else
			{
				TransactionUserControl.Instance.BringToFront();
			}
		}

		

		private void About_tab_Click(object sender, EventArgs e)
		{
			if (!ContentPanel.Controls.Contains(AboutUserControl.Instance))
			{
				ContentPanel.Controls.Add(AboutUserControl.Instance);
				AboutUserControl.Instance.Dock = DockStyle.Fill;
				AboutUserControl.Instance.BringToFront();
			}
			else
			{
				AboutUserControl.Instance.BringToFront();
			}
		}

		private void ContentPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
