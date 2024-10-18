using ReservationSystem.business;
using ReservationSystem.entitites;
using System;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class Login : Form
    {

        private UserManager userManager;

        public Login()
        {
            InitializeComponent();

            userManager = new UserManager();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User(
                    tb_username.Text,
                    tb_password.Text
                );

            if (userManager.Login(user))
            {
                    Dashboard dashboard = new Dashboard();
                    dashboard.FormClosed += (s, args) => this.Close();
                    dashboard.Show();
                    this.Hide();
            }
            else {
                MessageBox.Show("Username or password is incorrect.");
            }
        }
    }
}
