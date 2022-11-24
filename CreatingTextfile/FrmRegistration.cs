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

namespace CreatingTextfile
{
    public partial class FrmRegistration : Form
    {
        public object FrmFileName { get; private set; }

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String getStudentNo = StudentNo.Text;
            String getlastName = LastName.Text;
            String getAge = Age.Text;
            String getBirthday = Birthday.Text;
            String getProgram = Program.Text;
            String getFirstName = FirstName.Text;
            String getMI = MI.Text;
            String getGender = Gender.Text;
            String getContactNo = ContactNo.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            getStudentNo +".txt")))
            {
                outputFile.WriteLine("Student No.: "+getStudentNo);
                outputFile.WriteLine("Full Name: "+getlastName+" "+getFirstName+" "+getMI+".");
                outputFile.WriteLine("Program: "+getProgram);
                outputFile.WriteLine("Gender: "+getGender);
                outputFile.WriteLine("Age: "+getAge);
                outputFile.WriteLine("Birthday: "+getBirthday);
                outputFile.WriteLine("ContactNo.: " + getContactNo);
                Close();
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
