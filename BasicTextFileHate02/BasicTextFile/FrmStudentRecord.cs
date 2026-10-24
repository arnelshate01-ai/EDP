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
    public partial class FrmStudentRecord : Form
    {
        private Form _registrationForm;

        public FrmStudentRecord(Form registrationForm)
        {
            InitializeComponent();
            _registrationForm = registrationForm;
        }
        private void FrmStudentRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            _registrationForm.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                lvShowText.Items.Clear();
                using (StreamReader streamReader = File.OpenText(openFileDialog1.FileName))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lvShowText.Items.Add(line);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not read the file: " + ex.Message, "Error");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _registrationForm.Show();
            this.Close();
        }
        

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvShowText.Items.Clear();
        }
    }
}
