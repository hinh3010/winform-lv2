using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        void DefaultColor(){
            //pictureBoxUserName.BackgroundImage = Properties.Resources....anh1
            panelUserName.BackColor = Color.Gainsboro;
            txtUserName.ForeColor = Color.Gainsboro; ;

            //pictureBoxPassWord.BackgroundImage = Properties.Resources....anh1
            panelPassWord.BackColor = Color.Gainsboro;
            txtPassWord.ForeColor = Color.Gainsboro;

            //pictureBoxEmail.BackgroundImage = Properties.Resources....anh1
            panelEmail.BackColor = Color.Gainsboro;
            txtEmail.ForeColor = Color.Gainsboro;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            DefaultColor();

            //txtUserName.Clear();
            //pictureBoxUserName.BackgroundImage = Properties.Resources....anh2
            panelUserName.BackColor = Color.FromArgb(78, 184, 206);
            txtUserName.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            DefaultColor();

            //txtPassWord.Clear();
            //pictureBoxPassWord.BackgroundImage = Properties.Resources....anh2
            panelPassWord.BackColor = Color.FromArgb(78, 184, 206);
            txtPassWord.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            DefaultColor();

            //txtEmail.Clear();
            //pictureBoxEmail.BackgroundImage = Properties.Resources....anh2
            panelEmail.BackColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);
        }


        Login formLogin = new Login();
        private void timer1_Tick(object sender, EventArgs e)
        {
            formLogin.Left += 10;
            if (formLogin.Left >= 900)
            {
                timer1.Stop();
                this.TopMost = false;
                formLogin.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            formLogin.Left -= 10;
            if (formLogin.Left <= 460)
            {
                timer2.Stop();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            this.Hide();
            formLogin.Show();
        }


        string checkUser(string user)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{6,20}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (user == "")
            {
                return "is Require";
            }
            else if (!hasMiniMaxChars.IsMatch(user))
            {
                return "6 -> 20 ki tu";
            }
            else if (!hasLowerChar.IsMatch(user))
            {
                return "it nhat 1 ki tu in thuong";
            }
            else if (!hasUpperChar.IsMatch(user))
            {
                return "it nhat 1 ki tu in hoa";
            }
            else
            {
                return "";
            }
        }


        string checkPassWord(string pass) {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{6,10}");
            var hasLowerChar = new Regex(@"[a-z]+");
            //var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (pass == "")
            {
                return "is Require";
            }
            else if (!hasMiniMaxChars.IsMatch(pass))
            {
                return "6 -> 10 ki tu";
            }
            else if (!hasNumber.IsMatch(pass))
            {
                return "it nhat 1 so";

            }
            else if (!hasLowerChar.IsMatch(pass))
            {
                return "it nhat 1 ki tu in thuong";
            }
            else if (!hasUpperChar.IsMatch(pass))
            {
                return "it nhat 1 ki tu in hoa";
            } 
            else
            {
                return "";
            }
        }

        string checkEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (email == "")
            {
                return "is Require";
            }
            else if (match.Success)
                return "";
            else
                return "not an email";
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            string email = txtEmail.Text;

            lblErrUserName.Text = checkUser(username.Trim());

            lblErrPassWord.Text = checkPassWord(password.Trim());

            lblErrEmail.Text = checkEmail(email.Trim());

            if(lblErrUserName.Text == "" && lblErrPassWord.Text == "" && lblErrEmail.Text == "")
            {
                MessageBox.Show($"username :{username} \n\r " +
                    $"password : {password} \n\r" +
                    $"email : {email}");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            lblErrUserName.Text = checkUser(username.Trim());
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassWord.Text;
            lblErrPassWord.Text = checkPassWord(password.Trim());
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            lblErrEmail.Text = checkEmail(email.Trim());
        }
    }
}
