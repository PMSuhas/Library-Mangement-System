namespace Librarian_System
{
	partial class Body
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Body));
			this.logintimer = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
			this.ContentPanel = new System.Windows.Forms.Panel();
			this.SlidingPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.About_tab = new System.Windows.Forms.Button();
			this.Transaction_Tab = new System.Windows.Forms.Button();
			this.Borrowers_tab = new System.Windows.Forms.Button();
			this.Book_tab = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SlidingPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// logintimer
			// 
			this.logintimer.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 53);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(0, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 93);
			this.panel2.TabIndex = 4;
			// 
			// ContentPanel
			// 
			this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.ContentPanel.Location = new System.Drawing.Point(178, 53);
			this.ContentPanel.Name = "ContentPanel";
			this.ContentPanel.Size = new System.Drawing.Size(622, 397);
			this.ContentPanel.TabIndex = 2;
			this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
			// 
			// SlidingPanel
			// 
			this.SlidingPanel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.SlidingPanel.BackgroundImage = global::Librarian_System.Properties.Resources.panel;
			this.SlidingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SlidingPanel.Controls.Add(this.label1);
			this.SlidingPanel.Controls.Add(this.About_tab);
			this.SlidingPanel.Controls.Add(this.Transaction_Tab);
			this.SlidingPanel.Controls.Add(this.Borrowers_tab);
			this.SlidingPanel.Controls.Add(this.Book_tab);
			this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.SlidingPanel.Location = new System.Drawing.Point(0, 53);
			this.SlidingPanel.Name = "SlidingPanel";
			this.SlidingPanel.Size = new System.Drawing.Size(180, 397);
			this.SlidingPanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu";
			// 
			// About_tab
			// 
			this.About_tab.BackColor = System.Drawing.Color.Transparent;
			this.About_tab.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.About_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.About_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.About_tab.ForeColor = System.Drawing.Color.SkyBlue;
			this.About_tab.Image = ((System.Drawing.Image)(resources.GetObject("About_tab.Image")));
			this.About_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.About_tab.Location = new System.Drawing.Point(-1, 216);
			this.About_tab.Name = "About_tab";
			this.About_tab.Size = new System.Drawing.Size(180, 54);
			this.About_tab.TabIndex = 5;
			this.About_tab.Text = "About";
			this.About_tab.UseVisualStyleBackColor = false;
			this.About_tab.Click += new System.EventHandler(this.About_tab_Click);
			// 
			// Transaction_Tab
			// 
			this.Transaction_Tab.BackColor = System.Drawing.Color.Transparent;
			this.Transaction_Tab.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.Transaction_Tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Transaction_Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Transaction_Tab.ForeColor = System.Drawing.Color.SkyBlue;
			this.Transaction_Tab.Image = ((System.Drawing.Image)(resources.GetObject("Transaction_Tab.Image")));
			this.Transaction_Tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Transaction_Tab.Location = new System.Drawing.Point(-1, 162);
			this.Transaction_Tab.Name = "Transaction_Tab";
			this.Transaction_Tab.Size = new System.Drawing.Size(180, 54);
			this.Transaction_Tab.TabIndex = 3;
			this.Transaction_Tab.Text = "Transaction";
			this.Transaction_Tab.UseVisualStyleBackColor = false;
			this.Transaction_Tab.Click += new System.EventHandler(this.Transaction_Tab_Click);
			// 
			// Borrowers_tab
			// 
			this.Borrowers_tab.BackColor = System.Drawing.Color.Transparent;
			this.Borrowers_tab.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.Borrowers_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Borrowers_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Borrowers_tab.ForeColor = System.Drawing.Color.SkyBlue;
			this.Borrowers_tab.Image = ((System.Drawing.Image)(resources.GetObject("Borrowers_tab.Image")));
			this.Borrowers_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Borrowers_tab.Location = new System.Drawing.Point(0, 108);
			this.Borrowers_tab.Name = "Borrowers_tab";
			this.Borrowers_tab.Size = new System.Drawing.Size(180, 54);
			this.Borrowers_tab.TabIndex = 2;
			this.Borrowers_tab.Text = "Borrowers";
			this.Borrowers_tab.UseVisualStyleBackColor = false;
			this.Borrowers_tab.Click += new System.EventHandler(this.button5_Click);
			// 
			// Book_tab
			// 
			this.Book_tab.BackColor = System.Drawing.Color.Transparent;
			this.Book_tab.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
			this.Book_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Book_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Book_tab.ForeColor = System.Drawing.Color.SkyBlue;
			this.Book_tab.Image = global::Librarian_System.Properties.Resources.Books1;
			this.Book_tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Book_tab.Location = new System.Drawing.Point(-1, 54);
			this.Book_tab.Name = "Book_tab";
			this.Book_tab.Size = new System.Drawing.Size(180, 54);
			this.Book_tab.TabIndex = 1;
			this.Book_tab.Text = "Books";
			this.Book_tab.UseVisualStyleBackColor = false;
			this.Book_tab.Click += new System.EventHandler(this.Book_tab_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(644, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(44, 43);
			this.button2.TabIndex = 2;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(694, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(44, 43);
			this.button3.TabIndex = 3;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.DarkSalmon;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(744, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(44, 43);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Body
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ContentPanel);
			this.Controls.Add(this.SlidingPanel);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Body";
			this.Text = "Body";
			this.Load += new System.EventHandler(this.Body_Load);
			this.panel1.ResumeLayout(false);
			this.SlidingPanel.ResumeLayout(false);
			this.SlidingPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer logintimer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel SlidingPanel;
		private System.Windows.Forms.Timer SlidingPanel_Timer;
		private System.Windows.Forms.Button Borrowers_tab;
		private System.Windows.Forms.Button Book_tab;
		private System.Windows.Forms.Button About_tab;
		private System.Windows.Forms.Button Transaction_Tab;
		private System.Windows.Forms.Panel ContentPanel;
		private System.Windows.Forms.Label label1;
	}
}