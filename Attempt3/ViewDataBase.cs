using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Attempt3
{

    public partial class ViewDataBase : Form
    {

        private MainScreen mainScreen;

        public ViewDataBase()
        {
            
        }
        public ViewDataBase(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
            ControlBox = false;          

        }

        private void BackToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainScreen.Visible = true;
        }

        private void ViewDataBase_Load(object sender, EventArgs e)
        {
            this.ShowIcon = true;
            this.MinimizeBox = true;
            this.MaximizeBox = true;

        }

        private void ComboBoxChooseSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ShowData()
        {
            Values aa = new Values();

            string asd = aa.ThePathToTheFolder;

            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + asd + ";Extended Properties=Excel 12.0;"); MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                DataGridViewShowExcelDataBase.DataSource = DtSet.Tables[0];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewShowExcelDataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
