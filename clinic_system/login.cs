using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_system
{
    public partial class login : Form
    {
        //to delete it after signout
        public TextBox pwTextBox;

        public login()
        {
            InitializeComponent();
            pwTextBox = passwordTextBox;
        }


        private void logInBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            bool success = false;
               
            foreach (var doctor in appManager.entities.doctors)
            {
                if (username == doctor.username)
                {
                    success = doctor.password == password ? true : false;
                }
            }
            //chech if the user credintials are correct
            if (success)
            {
                appManager.mainForm = new MainForm();
                appManager.mainForm.Show();
                //hide the login form
                appManager.loginForm.Hide();
            }
            else
            {
                MessageBox.Show("كامة مرور خاطئه");
            }
        }
        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logInBtn_Click(null, null);
            }
        }
    }
}
