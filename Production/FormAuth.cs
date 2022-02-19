using Production.User;
using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Production
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string sSourceData;
            byte[] tmpSource;
            byte[] tmpHash;
            sSourceData = "MySourceData";
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            byte[] tmpNewHash;
            tmpNewHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DBAuth db = new DBAuth();

            if (new Users(loginField.Text, passField.Text).CheckUser())
            {
                if (loginField.Text == "admin")
                {
                    MessageBox.Show("Добро пожаловать, уважаемый Администратор!");
                    FormMain f = new FormMain();
                    f.Left = this.Left;
                    f.Top = this.Top;
                    f.Show();
                    f.Closed += (s, args) => this.Close();
                    this.Hide();
                }


                else if (loginField.Text == "user")
                {
                    if (new Users(loginField.Text, passField.Text).CheckUser())
                    {
                        MessageBox.Show("Добро пожаловать, уважаемый Пользователь!");
                        FormMainUser f = new FormMainUser();
                        f.Left = this.Left;
                        f.Top = this.Top;
                        f.Show();
                        f.Closed += (s, args) => this.Close();
                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Данные не верны!");
                }
            }
            else
            {
                MessageBox.Show("Данные не верны!");
            }
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }
    }
}
