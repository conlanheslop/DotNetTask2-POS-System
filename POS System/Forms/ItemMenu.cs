using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Forms
{
    public partial class ItemMenu : Form
    {
        public ItemMenu(string userName, string role)
        {
            InitializeComponent();

            LabelName.Text = $"Name: {userName}";
            LabelRole.Text = $"Role: {role}";
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDateAndTime.Text = $"Date and Time: {DateTime.Now.ToString("f")}";
        }

        private void LabelDateAndTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginScreen = new LoginScreen();
            loginScreen.Show();

            this.Hide();
        }
    }
}
