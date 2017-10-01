using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using pdfApp;
using System.IO;

namespace pdfApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void bttnSelect_Click(object sender, EventArgs e)
        {
            //open file dialog and let users select multiple pdfs.
            OpenFileDialog openDiag = new OpenFileDialog();
            openDiag.Filter = "Pdf files (*.Pdf)|*.Pdf";
            openDiag.Multiselect = true;
            openDiag.ShowDialog();

            //itterate through the selected items and add them to the ListView
            //if they are not already in the ListView.
            foreach (string items in openDiag.FileNames)
            {
                ListViewItem tempItem = listView1.FindItemWithText(items);
                if(tempItem == null)
                {
                    listView1.Items.Add(items);
                }
            }

            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count ==0)
            {
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Would you like to remove the file?", "Remove File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    int index = listView1.FocusedItem.Index;
                    listView1.Items.RemoveAt(index);
                    listView1.SelectedItems.Clear();
                    
                }
            }
        }

        private void bttnMerge_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            //Check the number of items can't merge if there are 
            //no items.
            if (listView1.Items.Count <= 0)
            {
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "You must Select pdfs to merge.";
            }
            else
            {
                //Make sure there is a file name chosen to write too.
                if (string.IsNullOrEmpty(txtBoxNewPDFName.Text))
                {
                    lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                    lblErrorMessage.Text = "Please choose a file name to write too.";
                }
                else
                {
                    List<string> listOfFileNames = new List<string>();
                    foreach (ListViewItem item in listView1.Items)
                    {
                        listOfFileNames.Add(item.Text);
                    }
                    string projectPath =Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    projectPath += "\\" + "PDF" + "\\" + txtBoxNewPDFName.Text;
                    projectPath = pdfclass.checkFileExtension(projectPath);
                    bool didItwork = pdfclass.MergePDFS(listOfFileNames, projectPath);

                    if (didItwork)
                    {
                        lblErrorMessage.ForeColor = System.Drawing.Color.Green;

                        lblErrorMessage.Text = "PDF's successfully merged!";

                    }
                    else
                    {
                        lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                        lblErrorMessage.Text = "PDF's failed to merge!";
                    }
                }
            }
        }

        private void bttnRemovePages_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewFileName.Text))
            {
                lblRemoveError.ForeColor = System.Drawing.Color.Red;
                lblRemoveError.Text = "You must choose a new file name!";
                lblErrorMessage.Update();

            }
            else if(checkedListBox1.CheckedItems.Count <= 0)
            {
                lblRemoveError.ForeColor = System.Drawing.Color.Red;
                lblRemoveError.Text = "There are no pages selected for deletion!";
                lblErrorMessage.Update();
            }
            else
            {
                int pageCount = pdfclass.countPages(txtboxCurrentPDFName.Text);
                int size = pageCount - checkedListBox1.CheckedItems.Count;
                int[] pages = new int[size];
                int iterator = 0;
                for (int p = 1; p <= pageCount; p++)
                {
                    if (!checkedListBox1.CheckedItems.Contains(p))
                    {
                        pages[iterator] = p;
                        iterator++;
                    }
                    else
                    {
                        continue;
                    }
                }
                string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                projectPath += "\\" + "PDF" + "\\" + txtNewFileName.Text;
                projectPath = pdfclass.checkFileExtension(projectPath);
                pdfclass.removePages(txtboxCurrentPDFName.Text, projectPath, pages);

                axAcroPDF1.src = projectPath;

                lblRemoveError.ForeColor = System.Drawing.Color.Green;
                lblRemoveError.Text = "Successfully removed pages! ";
                lblRemoveError.Update();
                
            }
        }

        

        private void bttnSelectPDF_Click(object sender, EventArgs e)
        {
            lblRemoveError.Text = null;
            checkedListBox1.Items.Clear();
            txtNewFileName.Text = null;
            
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.ValidateNames = true;
            newFile.Multiselect = false;
            newFile.Filter = "Pdf files (*.Pdf)|*.Pdf";
            newFile.ShowDialog();

            if (!string.IsNullOrEmpty(newFile.FileName))
            {
                axAcroPDF1.src = newFile.FileName;
                txtboxCurrentPDFName.Text = newFile.FileName;
                bttnRemovePages.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtboxCurrentPDFName.Visible = true;
                txtNewFileName.Visible = true;
                checkedListBox1.Visible = true;
                int count = pdfclass.countPages(txtboxCurrentPDFName.Text);
                for(int i =1; i <= count; i++)
                {
                    checkedListBox1.Items.Add(i);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bttnSelectInsertionPDF_Click(object sender, EventArgs e)
        {
            lblInsertError.Text = null;
            checkedListBox2.Items.Clear();
            txtBoxInsertNewPDFName.Text = null;

            OpenFileDialog newFile = new OpenFileDialog();
            newFile.ValidateNames = true;
            newFile.Multiselect = false;
            newFile.Filter = "Pdf files (*.Pdf)|*.Pdf";
            newFile.ShowDialog();

            if (!string.IsNullOrEmpty(newFile.FileName))
            {
                axAcroPDF2.src = newFile.FileName;
                txtBoxInsertCurrentPDF.Text = newFile.FileName;
                bttnInsertPages.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                txtBoxInsertCurrentPDF.Visible = true;
                txtBoxInsertNewPDFName.Visible = true;
                txtboxInsertedPagesPDFName.Visible = true;
                checkedListBox2.Visible = true;
                int count = pdfclass.countPages(txtBoxInsertCurrentPDF.Text);
                for (int i = 1; i <= count; i++)
                {
                    checkedListBox2.Items.Add(i);
                }
            }
        }

        private void bttnInsertPages_Click(object sender, EventArgs e)
        {
            
            //make sure the other source file is selected
            if (string.IsNullOrEmpty(txtboxInsertedPagesPDFName.Text))
            {
                lblInsertError.ForeColor = System.Drawing.Color.Red;
                lblInsertError.Text = "No pages to insert selected.";
                txtboxInsertedPagesPDFName.Focus();
                lblInsertError.Update();

            }
            //make sure a new pdf name is available.
            else if (string.IsNullOrEmpty(txtBoxInsertNewPDFName.Text))
            {
                lblInsertError.ForeColor = System.Drawing.Color.Red;
                lblInsertError.Text = "A new PDF name must be selected";
                txtBoxInsertNewPDFName.Focus();
                lblInsertError.Update();
            }
            else if(checkedListBox2.SelectedItems.Count <=0)
            {
                lblInsertError.ForeColor = System.Drawing.Color.Red;
                lblInsertError.Text = "You must select where to insert the pages.";
                checkedListBox2.Focus();
                lblInsertError.Update();
            }
            else
            {
                string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                projectPath += "\\" + "PDF" + "\\" + txtBoxInsertNewPDFName.Text;
                projectPath = pdfclass.checkFileExtension(projectPath);

                int index = checkedListBox2.SelectedIndex;
                int value = (int)checkedListBox2.Items[index]+1;
                pdfclass.Insert(txtBoxInsertCurrentPDF.Text, txtboxInsertedPagesPDFName.Text, projectPath, value);
                axAcroPDF2.src = projectPath;
                lblInsertError.ForeColor = System.Drawing.Color.Green;
                lblInsertError.Text = "Insertion of pages successful!";

            }
        }

        
        private void txtboxInsertedPagesPDFName_Click(object sender, EventArgs e)
        {
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.ValidateNames = true;
            newFile.Multiselect = false;
            newFile.Filter = "Pdf files (*.Pdf)|*.Pdf";
            newFile.ShowDialog();
            txtboxInsertedPagesPDFName.Text = newFile.FileName;
            

        }
    }
}
