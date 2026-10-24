using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BasicTextFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text first.", "Error");
                txtInput.Focus();
                return;
            }

            using (FrmFileName fileNameForm = new FrmFileName())
            {
                fileNameForm.ShowDialog();
            }

            string getInput = txtInput.Text;

            if (string.IsNullOrWhiteSpace(FrmFileName.SetFileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            string docPath = Application.StartupPath;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            this.Hide();

            MessageBox.Show("File created in My Documents!");

            FrmFileName.SetFileName = null;


            frmRegistration regForm = new frmRegistration();

            regForm.ShowDialog();
        }
    }
}
    
