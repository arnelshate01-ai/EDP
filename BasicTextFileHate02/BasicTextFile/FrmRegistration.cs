using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                    cbProgram.SelectedIndex == -1 ||
                    cbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all required fields correctly.", "Error");
                    return;
                }

                if (!Regex.IsMatch(txtStudentNo.Text.Trim(), @"^\d+$"))
                {
                    MessageBox.Show("Student No. must contain numbers only.", "Error");
                    txtStudentNo.Focus();
                    return;
                }

                if (!Regex.IsMatch(txtAge.Text.Trim(), @"^\d+$"))
                {
                    MessageBox.Show("Age must contain numbers only.", "Error");
                    txtAge.Focus();
                    return;
                }

                if (!Regex.IsMatch(txtContactNo.Text.Trim(), @"^\d+$"))
                {
                    MessageBox.Show("Contact No. must contain numbers only.", "Error");
                    txtContactNo.Focus();
                    return;
                }

                string[] lines =
                {
                "Student No.:" + txtStudentNo.Text.Trim(),
                "Full Name:" + txtLastName.Text.Trim() + ", " + txtFirstName.Text.Trim() + ", " + txtMI.Text.Trim(),
                "Program: " + cbProgram.Text,
                "Gender: " + cbGender.Text,
                "Age: " + txtAge.Text.Trim(),
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No." + txtContactNo.Text.Trim()
            };

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = txtStudentNo.Text.Trim() + ".txt";

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
                {
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }
                }

                MessageBox.Show("File created in My Documents!");
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord records = new FrmStudentRecord(this);
            records.Show();
            ClearFields();
            this.Hide();
        }
        private void ClearFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMI.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            cbProgram.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Today;
            txtStudentNo.Focus();
        }
    }
}
