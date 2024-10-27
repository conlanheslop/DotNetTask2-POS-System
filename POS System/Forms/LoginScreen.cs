using POS_System.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using POS_System.Classes;
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
                // fetch the user record from the db
                var userRecord = DbContext.Users.FirstOrDefault(u => u.UserID == userID && u.Password == password);

                if (userRecord != null)
                {
                    // create the subclasses
                    POSUser user;
                    switch (userRecord.UserType)
                    {
                        case 0:
                            user = new Crew(userRecord.UserID, userRecord.Password, userRecord.Name);
                            break;
                        case 1:
                            user = new TeamLead(userRecord.UserID, userRecord.Password, userRecord.Name);
                            break;
                        case 2:
                            user = new Manager(userRecord.UserID, userRecord.Password, userRecord.Name);
                            break;
                        default:
                            MessageBox.Show("Invalid user role.");
                            return;
                    }

                    var itemMenu = new ItemMenu(user);
                    itemMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User ID or password.");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
