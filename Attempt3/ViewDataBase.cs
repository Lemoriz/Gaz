using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attempt3
{
    public partial class ViewDataBase : Form
    {
        private MainScreen mainScreen;

        public ViewDataBase(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
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
    }
}
