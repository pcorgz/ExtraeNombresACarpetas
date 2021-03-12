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

namespace ExtraeNombresACarpetas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CleanScreen();
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = ofdSelectXls.Filter;
                openFileDialog.InitialDirectory = Environment.GetFolderPath(
                        Environment.SpecialFolder.MyDocuments);
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtSourceFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the specified folder
                    txtFolderDestination.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void txtColumn_Enter(object sender, EventArgs e)
        {
            txtColumn.SelectAll();
        }

        private void numStartRow_Enter(object sender, EventArgs e)
        {
            numStartRow.Select(0, numStartRow.Text.Length);
        }

        private void numEndRow_Enter(object sender, EventArgs e)
        {
            numEndRow.Select(0, numEndRow.Text.Length);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var mainFormProcesses = new MainFormProcesses();
            mainFormProcesses.ProcessFileStart(this);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanScreen();
        }

        private void CleanScreen()
        {
            txtSourceFilePath.Text = "";
            txtColumn.Text = "A";
            numStartRow.Value = 1;
            numEndRow.Value = 1;
            txtFolderDestination.Text = "";
            txtResults.ForeColor = Color.Lime;
            txtResults.Text = "";
        }
    }
}
