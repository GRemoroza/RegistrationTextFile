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
    public partial class StudentRecord : Form
    {
        private Registration Registration;
        public StudentRecord()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                MessageBox.Show($"File found: {path}");

                DisplayToList(path);
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            lvViewRecord.Items.Clear();
            
            MessageBox.Show("Successfully Uploaded!");
        }
        private void StudentRecord_Load(object sender, EventArgs e)
        {

        }
        private void DisplayToList(string path)
        {
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvViewRecord.Items.Add(_getText);
                }
            }
        }
        
    }
}
