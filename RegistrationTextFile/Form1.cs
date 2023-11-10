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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistrationTextFile
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            string[] ListOfPrograms = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfPrograms[i].ToString());

            }

            string[] ListOfGender = new string[]
            {
                "Male",
                "Female",
                "Rather not to say"
            };
            for (int i = 0; i < 3; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string StudentNumber = txtStudentNo.Text;
            string LastName = txtLastName.Text;
            string FirstName = txtFirstName.Text;
            string MiddleName = txtMI.Text;
            string Program = cbProgram.Text;
            string Gender = cbGender.Text;
            string Age = txtAge.Text;
            string ContactNo = txtContactNo.Text;
            string Birthday = dateTimePicker1.Value.ToShortDateString();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = $"{ StudentNumber }_Registration.txt";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                outputFile.WriteLine($"Student No.: {StudentNumber}");
                outputFile.WriteLine($"Full Name: {LastName}, {FirstName}, {MiddleName}");
                outputFile.WriteLine($"Program: {Program}");
                outputFile.WriteLine($"Age: {Age}");
                outputFile.WriteLine($"Gender: {Gender}");
                outputFile.WriteLine($"Contact No.: {ContactNo}");
                outputFile.WriteLine($"Birthday: {Birthday}");


            }
            MessageBox.Show("Registration successful!");
        }
    }
}
