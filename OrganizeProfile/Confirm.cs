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
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblName.Text = StudentInformation.SetFullName;
            lblGender.Text = StudentInformation.SetGender;
            lblProgram.Text = StudentInformation.SetProgram;

            lblStudentNo.Text = StudentInformation.SetStudentNo.ToString();
            lblContactNo.Text = StudentInformation.SetContactNo.ToString();
            lblBirthday.Text = StudentInformation.SetBirthday;
        }
    }
}
