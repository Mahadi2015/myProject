using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class StudentInfoUI : Form
    {
        Student aStudent = new Student();
        public StudentInfoUI()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            ClearAllTexBox();

            MessageBox.Show(aStudent.GetFullName() +
                ", your reg no is:" + aStudent.regNo);

        }

        private void ClearAllTexBox()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            MessageBox.Show("Cleared");
        }

    }
}
