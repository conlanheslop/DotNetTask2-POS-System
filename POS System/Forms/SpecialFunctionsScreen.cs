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
    public partial class SpecialFunctionsScreen : Form
    {

        private readonly POSUser LoggedInUser;

        public SpecialFunctionsScreen(POSUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoggedInUser = user;
        }


        private void ButtonViewSalesReport_Click(object sender, EventArgs e)
        {
            if (LoggedInUser is Manager) 
            {
                var salesReportScreen = new SalesReportScreen(false);
                salesReportScreen.Show();
            }
            else if (LoggedInUser is TeamLead)
            {
                var salesReportScreen = new SalesReportScreen(true);
                salesReportScreen.Show();
            }
            else
            {
                MessageBox.Show("Access Denied. Only managers can view the sales report.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            var itemMenu = new ItemMenu(LoggedInUser);
            itemMenu.Show();
            this.Close();
        }
    }
}
