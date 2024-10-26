using System;
using System.Linq;
using System.Windows.Forms;
using POS_System.Classes;

namespace POS_System.Forms
{
    public partial class ItemMenu : Form
    {
        private POSUser LoggedInUser;

        public ItemMenu(POSUser user)
        {
            InitializeComponent();
            LoggedInUser = user;

            LabelName.Text = $"Name: {LoggedInUser.Name}";
            LabelRole.Text = $"Role: {LoggedInUser.Role}";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // show the date and time, update every second
            LabelDateAndTime.Text = $"Date and Time: {DateTime.Now:f}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
