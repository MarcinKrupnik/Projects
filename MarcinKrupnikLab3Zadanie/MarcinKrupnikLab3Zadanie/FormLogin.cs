using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinKrupnikLab3Zadanie
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn(textBoxUsername.Text, textBoxPassword.Text);
            FormMain formMain = new FormMain();

            if (sign.SignInMain())
            {
                formMain.Show();
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }

        }
    }
}
