using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_System
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int userID;
            bool isNum = int.TryParse(UsernameTextBox.Text, out userID);

            if (!isNum)
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }

            string password = PasswordTextBox.Text;

            using (var DbContext = new AppDbContext()) 
            {
                var user = DbContext.Users.FirstOrDefault(u => u.UserID == userID && u.Password == password);

                if (user != null)
                {

                    string userType;

                    switch (user.UserType)
                    {
                        case 0:
                            userType = "Crew";
                            break;
                        case 1:
                            userType = "Team Lead";
                            break;
                        case 2:
                            userType = "Manager";
                            break;
                        default:
                            userType = "Not Valid";
                            break;
                    }

                    MessageBox.Show($"Login succesful. Name: {user.Name} | User Type: {userType}");
                }
                else
                {
                    MessageBox.Show("Invalid User ID or password.");
                }
            }
        }

    }
}
