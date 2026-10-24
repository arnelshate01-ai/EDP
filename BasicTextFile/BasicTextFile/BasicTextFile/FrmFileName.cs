using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicTextFile
{
    public partial class FrmFileName : Form
    {

        public static string SetFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtFileName.Text))
                {
                    MessageBox.Show("Please enter a file name.");
                    return;
                }

                SetFileName = txtFileName.Text.Trim() + ".txt";
                this.Close();
            }
        }
    }
}
