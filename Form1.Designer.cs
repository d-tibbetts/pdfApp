namespace pdfApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.bttnMerge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNewPDFName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnSelect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRemoveError = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxCurrentPDFName = new System.Windows.Forms.TextBox();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.bttnSelectPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnRemovePages = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtboxInsertedPagesPDFName = new System.Windows.Forms.TextBox();
            this.lblInsertError = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxInsertCurrentPDF = new System.Windows.Forms.TextBox();
            this.txtBoxInsertNewPDFName = new System.Windows.Forms.TextBox();
            this.bttnSelectInsertionPDF = new System.Windows.Forms.Button();
            this.bttnInsertPages = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.BackgroundImage = global::pdfApp.Properties.Resources.background;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.lblErrorMessage);
            this.tabPage1.Controls.Add(this.bttnMerge);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBoxNewPDFName);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.bttnSelect);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Combine";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(290, 81);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMessage.TabIndex = 9;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnMerge
            // 
            this.bttnMerge.BackColor = System.Drawing.Color.Peru;
            this.bttnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnMerge.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMerge.Location = new System.Drawing.Point(482, 294);
            this.bttnMerge.Name = "bttnMerge";
            this.bttnMerge.Size = new System.Drawing.Size(112, 28);
            this.bttnMerge.TabIndex = 7;
            this.bttnMerge.Text = "Merge";
            this.bttnMerge.UseVisualStyleBackColor = false;
            this.bttnMerge.Click += new System.EventHandler(this.bttnMerge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(110, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Pdf name";
            // 
            // txtBoxNewPDFName
            // 
            this.txtBoxNewPDFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNewPDFName.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPDFName.Location = new System.Drawing.Point(218, 299);
            this.txtBoxNewPDFName.Name = "txtBoxNewPDFName";
            this.txtBoxNewPDFName.Size = new System.Drawing.Size(221, 22);
            this.txtBoxNewPDFName.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.NavajoWhite;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(113, 122);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 166);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Selected PDF File Names";
            this.columnHeader1.Width = 475;
            // 
            // bttnSelect
            // 
            this.bttnSelect.BackColor = System.Drawing.Color.Peru;
            this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelect.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSelect.Location = new System.Drawing.Point(113, 74);
            this.bttnSelect.Name = "bttnSelect";
            this.bttnSelect.Size = new System.Drawing.Size(112, 28);
            this.bttnSelect.TabIndex = 0;
            this.bttnSelect.Text = "Select PDF(s)";
            this.bttnSelect.UseVisualStyleBackColor = false;
            this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Khaki;
            this.tabPage2.BackgroundImage = global::pdfApp.Properties.Resources.background;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.lblRemoveError);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtboxCurrentPDFName);
            this.tabPage2.Controls.Add(this.txtNewFileName);
            this.tabPage2.Controls.Add(this.bttnSelectPDF);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bttnRemovePages);
            this.tabPage2.Controls.Add(this.axAcroPDF1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remove";
            // 
            // lblRemoveError
            // 
            this.lblRemoveError.AutoSize = true;
            this.lblRemoveError.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveError.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveError.Location = new System.Drawing.Point(394, 89);
            this.lblRemoveError.Name = "lblRemoveError";
            this.lblRemoveError.Size = new System.Drawing.Size(0, 19);
            this.lblRemoveError.TabIndex = 11;
            this.lblRemoveError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(487, 224);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(84, 55);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(366, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pages to Remove:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(375, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "New PDF name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(390, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current PDF:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // txtboxCurrentPDFName
            // 
            this.txtboxCurrentPDFName.Location = new System.Drawing.Point(487, 140);
            this.txtboxCurrentPDFName.Name = "txtboxCurrentPDFName";
            this.txtboxCurrentPDFName.Size = new System.Drawing.Size(161, 22);
            this.txtboxCurrentPDFName.TabIndex = 6;
            this.txtboxCurrentPDFName.Visible = false;
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.ForeColor = System.Drawing.Color.Black;
            this.txtNewFileName.Location = new System.Drawing.Point(487, 182);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(161, 22);
            this.txtNewFileName.TabIndex = 5;
            this.txtNewFileName.Visible = false;
            // 
            // bttnSelectPDF
            // 
            this.bttnSelectPDF.BackColor = System.Drawing.Color.Peru;
            this.bttnSelectPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelectPDF.Location = new System.Drawing.Point(453, 26);
            this.bttnSelectPDF.Name = "bttnSelectPDF";
            this.bttnSelectPDF.Size = new System.Drawing.Size(112, 28);
            this.bttnSelectPDF.TabIndex = 4;
            this.bttnSelectPDF.Text = "Select PDF";
            this.bttnSelectPDF.UseVisualStyleBackColor = false;
            this.bttnSelectPDF.Click += new System.EventHandler(this.bttnSelectPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(110, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PDF PREVIEW";
            // 
            // bttnRemovePages
            // 
            this.bttnRemovePages.BackColor = System.Drawing.Color.Peru;
            this.bttnRemovePages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnRemovePages.Location = new System.Drawing.Point(453, 345);
            this.bttnRemovePages.Name = "bttnRemovePages";
            this.bttnRemovePages.Size = new System.Drawing.Size(112, 28);
            this.bttnRemovePages.TabIndex = 1;
            this.bttnRemovePages.Text = "Remove Pages";
            this.bttnRemovePages.UseVisualStyleBackColor = false;
            this.bttnRemovePages.Visible = false;
            this.bttnRemovePages.Click += new System.EventHandler(this.bttnRemovePages_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(20, 26);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(271, 365);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::pdfApp.Properties.Resources.background;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtboxInsertedPagesPDFName);
            this.tabPage3.Controls.Add(this.lblInsertError);
            this.tabPage3.Controls.Add(this.checkedListBox2);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtBoxInsertCurrentPDF);
            this.tabPage3.Controls.Add(this.txtBoxInsertNewPDFName);
            this.tabPage3.Controls.Add(this.bttnSelectInsertionPDF);
            this.tabPage3.Controls.Add(this.bttnInsertPages);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.axAcroPDF2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(705, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Insert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label10.Location = new System.Drawing.Point(387, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pages to Insert:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Visible = false;
            // 
            // txtboxInsertedPagesPDFName
            // 
            this.txtboxInsertedPagesPDFName.ForeColor = System.Drawing.Color.Black;
            this.txtboxInsertedPagesPDFName.Location = new System.Drawing.Point(499, 214);
            this.txtboxInsertedPagesPDFName.Name = "txtboxInsertedPagesPDFName";
            this.txtboxInsertedPagesPDFName.Size = new System.Drawing.Size(161, 22);
            this.txtboxInsertedPagesPDFName.TabIndex = 20;
            this.txtboxInsertedPagesPDFName.Visible = false;
            this.txtboxInsertedPagesPDFName.Click += new System.EventHandler(this.txtboxInsertedPagesPDFName_Click);
            this.txtboxInsertedPagesPDFName.Enter += new System.EventHandler(this.txtboxInsertedPagesPDFName_Click);
            // 
            // lblInsertError
            // 
            this.lblInsertError.AutoSize = true;
            this.lblInsertError.BackColor = System.Drawing.Color.Transparent;
            this.lblInsertError.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertError.Location = new System.Drawing.Point(401, 91);
            this.lblInsertError.Name = "lblInsertError";
            this.lblInsertError.Size = new System.Drawing.Size(0, 19);
            this.lblInsertError.TabIndex = 19;
            this.lblInsertError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(499, 262);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(84, 55);
            this.checkedListBox2.TabIndex = 18;
            this.checkedListBox2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label7.Location = new System.Drawing.Point(342, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Insert Pages After Page:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label8.Location = new System.Drawing.Point(387, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "New PDF name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label9.Location = new System.Drawing.Point(402, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Current PDF:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Visible = false;
            // 
            // txtBoxInsertCurrentPDF
            // 
            this.txtBoxInsertCurrentPDF.Location = new System.Drawing.Point(499, 140);
            this.txtBoxInsertCurrentPDF.Name = "txtBoxInsertCurrentPDF";
            this.txtBoxInsertCurrentPDF.Size = new System.Drawing.Size(161, 22);
            this.txtBoxInsertCurrentPDF.TabIndex = 14;
            this.txtBoxInsertCurrentPDF.Visible = false;
            // 
            // txtBoxInsertNewPDFName
            // 
            this.txtBoxInsertNewPDFName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxInsertNewPDFName.Location = new System.Drawing.Point(499, 177);
            this.txtBoxInsertNewPDFName.Name = "txtBoxInsertNewPDFName";
            this.txtBoxInsertNewPDFName.Size = new System.Drawing.Size(161, 22);
            this.txtBoxInsertNewPDFName.TabIndex = 13;
            this.txtBoxInsertNewPDFName.Visible = false;
            // 
            // bttnSelectInsertionPDF
            // 
            this.bttnSelectInsertionPDF.BackColor = System.Drawing.Color.Peru;
            this.bttnSelectInsertionPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelectInsertionPDF.Location = new System.Drawing.Point(465, 26);
            this.bttnSelectInsertionPDF.Name = "bttnSelectInsertionPDF";
            this.bttnSelectInsertionPDF.Size = new System.Drawing.Size(112, 28);
            this.bttnSelectInsertionPDF.TabIndex = 12;
            this.bttnSelectInsertionPDF.Text = "Select PDF";
            this.bttnSelectInsertionPDF.UseVisualStyleBackColor = false;
            this.bttnSelectInsertionPDF.Click += new System.EventHandler(this.bttnSelectInsertionPDF_Click);
            // 
            // bttnInsertPages
            // 
            this.bttnInsertPages.BackColor = System.Drawing.Color.Peru;
            this.bttnInsertPages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnInsertPages.Location = new System.Drawing.Point(465, 345);
            this.bttnInsertPages.Name = "bttnInsertPages";
            this.bttnInsertPages.Size = new System.Drawing.Size(112, 28);
            this.bttnInsertPages.TabIndex = 11;
            this.bttnInsertPages.Text = "Insert Pages";
            this.bttnInsertPages.UseVisualStyleBackColor = false;
            this.bttnInsertPages.Visible = false;
            this.bttnInsertPages.Click += new System.EventHandler(this.bttnInsertPages_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(110, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "PDF PREVIEW";
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(19, 26);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(271, 365);
            this.axAcroPDF2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(723, 452);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Miramonte", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "PDF Modifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bttnSelect;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button bttnMerge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNewPDFName;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button bttnRemovePages;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnSelectPDF;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxCurrentPDFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblRemoveError;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxInsertCurrentPDF;
        private System.Windows.Forms.TextBox txtBoxInsertNewPDFName;
        private System.Windows.Forms.Button bttnSelectInsertionPDF;
        private System.Windows.Forms.Button bttnInsertPages;
        private System.Windows.Forms.Label label6;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.Label lblInsertError;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtboxInsertedPagesPDFName;
    }
}

