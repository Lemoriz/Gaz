using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;




namespace Attempt3
{
    public partial class MainScreen : Form
    {
        private ViewDataBase viewDataBase;

        public MainScreen()
        {
            InitializeComponent();
            viewDataBase = new ViewDataBase(this) { Visible = false };
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void CreateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void CreateProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        //DataSet result;

        private void OpenProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            Values thePathToTheFile = new Values();

            openFile.Title = "Выберите файл";
            openFile.Filter = "Excel|* xlsx";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                thePathToTheFile.ThePathToTheFolder = openFile.FileName;
                MessageBox.Show(openFile.FileName, "Загружен файл из папки");
            }

        }

        private void SaveProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void CloseProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void СalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PerformToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConstructAGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void ViewDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            viewDataBase.Visible = true;
            
            
        }
    }
}
