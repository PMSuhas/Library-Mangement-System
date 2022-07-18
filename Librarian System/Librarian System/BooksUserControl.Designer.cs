namespace Librarian_System
{
	partial class BooksUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Booklabel = new System.Windows.Forms.Label();
			this.BookSearchtextBox = new System.Windows.Forms.TextBox();
			this.SearchBookButton = new System.Windows.Forms.Button();
			this.Addbutton = new System.Windows.Forms.Button();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.accNoLabel = new System.Windows.Forms.Label();
			this.Publisherlabel = new System.Windows.Forms.Label();
			this.Namelabel = new System.Windows.Forms.Label();
			this.ISBNlabel = new System.Windows.Forms.Label();
			this.Authorlabel = new System.Windows.Forms.Label();
			this.AccNotextBox = new System.Windows.Forms.TextBox();
			this.ISBNtextBox = new System.Windows.Forms.TextBox();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.PublishertextBox = new System.Windows.Forms.TextBox();
			this.AuthortextBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Depeartment_combobox = new System.Windows.Forms.ComboBox();
			this.Did_label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Booklabel
			// 
			this.Booklabel.AutoSize = true;
			this.Booklabel.BackColor = System.Drawing.Color.Black;
			this.Booklabel.ForeColor = System.Drawing.Color.Cyan;
			this.Booklabel.Location = new System.Drawing.Point(68, 18);
			this.Booklabel.Name = "Booklabel";
			this.Booklabel.Size = new System.Drawing.Size(53, 17);
			this.Booklabel.TabIndex = 0;
			this.Booklabel.Text = "BookID";
			// 
			// BookSearchtextBox
			// 
			this.BookSearchtextBox.Location = new System.Drawing.Point(153, 15);
			this.BookSearchtextBox.Name = "BookSearchtextBox";
			this.BookSearchtextBox.Size = new System.Drawing.Size(206, 22);
			this.BookSearchtextBox.TabIndex = 1;
			this.BookSearchtextBox.TextChanged += new System.EventHandler(this.BookSearchtextBox_TextChanged);
			// 
			// SearchBookButton
			// 
			this.SearchBookButton.BackColor = System.Drawing.Color.Black;
			this.SearchBookButton.ForeColor = System.Drawing.Color.DodgerBlue;
			this.SearchBookButton.Location = new System.Drawing.Point(394, 5);
			this.SearchBookButton.Name = "SearchBookButton";
			this.SearchBookButton.Size = new System.Drawing.Size(153, 42);
			this.SearchBookButton.TabIndex = 3;
			this.SearchBookButton.Text = "Search Book";
			this.SearchBookButton.UseVisualStyleBackColor = false;
			this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
			// 
			// Addbutton
			// 
			this.Addbutton.BackColor = System.Drawing.Color.Black;
			this.Addbutton.ForeColor = System.Drawing.Color.OrangeRed;
			this.Addbutton.Location = new System.Drawing.Point(14, 209);
			this.Addbutton.Name = "Addbutton";
			this.Addbutton.Size = new System.Drawing.Size(67, 34);
			this.Addbutton.TabIndex = 4;
			this.Addbutton.Text = "Add";
			this.Addbutton.UseVisualStyleBackColor = false;
			this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
			// 
			// Deletebutton
			// 
			this.Deletebutton.BackColor = System.Drawing.Color.Black;
			this.Deletebutton.ForeColor = System.Drawing.Color.OrangeRed;
			this.Deletebutton.Location = new System.Drawing.Point(263, 209);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(67, 34);
			this.Deletebutton.TabIndex = 6;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = false;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.BackColor = System.Drawing.Color.Black;
			this.ClearButton.ForeColor = System.Drawing.Color.OrangeRed;
			this.ClearButton.Location = new System.Drawing.Point(513, 209);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(71, 34);
			this.ClearButton.TabIndex = 7;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = false;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// accNoLabel
			// 
			this.accNoLabel.AutoSize = true;
			this.accNoLabel.BackColor = System.Drawing.Color.Black;
			this.accNoLabel.ForeColor = System.Drawing.Color.Aqua;
			this.accNoLabel.Location = new System.Drawing.Point(35, 266);
			this.accNoLabel.Name = "accNoLabel";
			this.accNoLabel.Size = new System.Drawing.Size(53, 17);
			this.accNoLabel.TabIndex = 8;
			this.accNoLabel.Text = "AccNo.";
			// 
			// Publisherlabel
			// 
			this.Publisherlabel.AutoSize = true;
			this.Publisherlabel.BackColor = System.Drawing.Color.Black;
			this.Publisherlabel.ForeColor = System.Drawing.Color.Aqua;
			this.Publisherlabel.Location = new System.Drawing.Point(35, 354);
			this.Publisherlabel.Name = "Publisherlabel";
			this.Publisherlabel.Size = new System.Drawing.Size(67, 17);
			this.Publisherlabel.TabIndex = 9;
			this.Publisherlabel.Text = "Publisher";
			// 
			// Namelabel
			// 
			this.Namelabel.AutoSize = true;
			this.Namelabel.BackColor = System.Drawing.Color.Black;
			this.Namelabel.ForeColor = System.Drawing.Color.Aqua;
			this.Namelabel.Location = new System.Drawing.Point(35, 308);
			this.Namelabel.Name = "Namelabel";
			this.Namelabel.Size = new System.Drawing.Size(45, 17);
			this.Namelabel.TabIndex = 10;
			this.Namelabel.Text = "Name";
			// 
			// ISBNlabel
			// 
			this.ISBNlabel.AutoSize = true;
			this.ISBNlabel.BackColor = System.Drawing.Color.Black;
			this.ISBNlabel.ForeColor = System.Drawing.Color.Aqua;
			this.ISBNlabel.Location = new System.Drawing.Point(329, 264);
			this.ISBNlabel.Name = "ISBNlabel";
			this.ISBNlabel.Size = new System.Drawing.Size(39, 17);
			this.ISBNlabel.TabIndex = 11;
			this.ISBNlabel.Text = "ISBN";
			this.ISBNlabel.Click += new System.EventHandler(this.ISBNlabel_Click);
			// 
			// Authorlabel
			// 
			this.Authorlabel.AutoSize = true;
			this.Authorlabel.BackColor = System.Drawing.Color.Black;
			this.Authorlabel.ForeColor = System.Drawing.Color.Aqua;
			this.Authorlabel.Location = new System.Drawing.Point(329, 308);
			this.Authorlabel.Name = "Authorlabel";
			this.Authorlabel.Size = new System.Drawing.Size(50, 17);
			this.Authorlabel.TabIndex = 12;
			this.Authorlabel.Text = "Author";
			this.Authorlabel.Click += new System.EventHandler(this.Authorlabel_Click);
			// 
			// AccNotextBox
			// 
			this.AccNotextBox.Location = new System.Drawing.Point(114, 261);
			this.AccNotextBox.Name = "AccNotextBox";
			this.AccNotextBox.Size = new System.Drawing.Size(174, 22);
			this.AccNotextBox.TabIndex = 13;
			// 
			// ISBNtextBox
			// 
			this.ISBNtextBox.Location = new System.Drawing.Point(425, 261);
			this.ISBNtextBox.Name = "ISBNtextBox";
			this.ISBNtextBox.Size = new System.Drawing.Size(174, 22);
			this.ISBNtextBox.TabIndex = 14;
			// 
			// NametextBox
			// 
			this.NametextBox.Location = new System.Drawing.Point(114, 308);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(174, 22);
			this.NametextBox.TabIndex = 15;
			// 
			// PublishertextBox
			// 
			this.PublishertextBox.Location = new System.Drawing.Point(114, 354);
			this.PublishertextBox.Name = "PublishertextBox";
			this.PublishertextBox.Size = new System.Drawing.Size(174, 22);
			this.PublishertextBox.TabIndex = 16;
			// 
			// AuthortextBox
			// 
			this.AuthortextBox.Location = new System.Drawing.Point(425, 303);
			this.AuthortextBox.Name = "AuthortextBox";
			this.AuthortextBox.Size = new System.Drawing.Size(174, 22);
			this.AuthortextBox.TabIndex = 17;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 53);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(616, 150);
			this.dataGridView1.TabIndex = 18;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Depeartment_combobox
			// 
			this.Depeartment_combobox.FormattingEnabled = true;
			this.Depeartment_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.Depeartment_combobox.Location = new System.Drawing.Point(425, 351);
			this.Depeartment_combobox.Name = "Depeartment_combobox";
			this.Depeartment_combobox.Size = new System.Drawing.Size(174, 24);
			this.Depeartment_combobox.TabIndex = 19;
			// 
			// Did_label
			// 
			this.Did_label.AutoSize = true;
			this.Did_label.BackColor = System.Drawing.Color.Black;
			this.Did_label.ForeColor = System.Drawing.Color.Aqua;
			this.Did_label.Location = new System.Drawing.Point(329, 354);
			this.Did_label.Name = "Did_label";
			this.Did_label.Size = new System.Drawing.Size(82, 17);
			this.Did_label.TabIndex = 20;
			this.Did_label.Text = "Department";
			// 
			// BooksUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Librarian_System.Properties.Resources.LibraryBookBackGroundImage_3;
			this.Controls.Add(this.Did_label);
			this.Controls.Add(this.Depeartment_combobox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.AuthortextBox);
			this.Controls.Add(this.PublishertextBox);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.ISBNtextBox);
			this.Controls.Add(this.AccNotextBox);
			this.Controls.Add(this.Authorlabel);
			this.Controls.Add(this.ISBNlabel);
			this.Controls.Add(this.Namelabel);
			this.Controls.Add(this.Publisherlabel);
			this.Controls.Add(this.accNoLabel);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.Addbutton);
			this.Controls.Add(this.SearchBookButton);
			this.Controls.Add(this.BookSearchtextBox);
			this.Controls.Add(this.Booklabel);
			this.Name = "BooksUserControl";
			this.Size = new System.Drawing.Size(622, 397);
			this.Load += new System.EventHandler(this.BooksUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Booklabel;
		private System.Windows.Forms.TextBox BookSearchtextBox;
		private System.Windows.Forms.Button SearchBookButton;
		private System.Windows.Forms.Button Addbutton;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Label accNoLabel;
		private System.Windows.Forms.Label Publisherlabel;
		private System.Windows.Forms.Label Namelabel;
		private System.Windows.Forms.Label ISBNlabel;
		private System.Windows.Forms.Label Authorlabel;
		private System.Windows.Forms.TextBox AccNotextBox;
		private System.Windows.Forms.TextBox ISBNtextBox;
		private System.Windows.Forms.TextBox NametextBox;
		private System.Windows.Forms.TextBox PublishertextBox;
		private System.Windows.Forms.TextBox AuthortextBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox Depeartment_combobox;
		private System.Windows.Forms.Label Did_label;
	}
}
