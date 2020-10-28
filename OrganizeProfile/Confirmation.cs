using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeProfile
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

          
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentInformation.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformation.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformation.SetProgram = cbPrograms.Text;
            StudentInformation.SetGender = cbGender.Text;
            StudentInformation.SetContactNo = lblContactNo(txtContactNo.Text);
            StudentInformation.SetAge = lblAge(txtAge.Text);
            StudentInformation.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

            frmConfirm frm = new frmConfirm();
            frm.ShowDialog();
        }
    }
}
