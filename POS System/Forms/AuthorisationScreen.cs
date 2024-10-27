using POS_System.Classes;
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
    public partial class AuthorisationScreen : Form
    {

        public bool IsAuthorised { get; private set; } = false;

        public AuthorisationScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string userID = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            using (var context = new AppDbContext())
            {
                var manager = context.Users
                    .OfType<Manager>()
                    .FirstOrDefault(u => u.UserID.ToString() == userID && u.Password == password);

                if (manager != null)
                {
                    IsAuthorised = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}