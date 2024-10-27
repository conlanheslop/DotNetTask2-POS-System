using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Classes;


namespace POS_System.Forms
{
    public partial class ItemMenu : Form
    {
        private readonly POSUser LoggedInUser;
        private readonly Order order = new Order();


        public ItemMenu(POSUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoggedInUser = user;

            LabelName.Text = $"Name: {LoggedInUser.Name}";
            LabelRole.Text = $"Role: {LoggedInUser.Role}";

            timer1.Start();

            LoadMenuItems();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDateAndTime.Text = $"Date and Time: {DateTime.Now:f}";
        }


        private void LoadMenuItems()
        {
            using (var context = new AppDbContext())

            {
                var items = context.POSItems.ToList();

                foreach (var item in items)
                {
                    var listViewItem = new ListViewItem(item.Name);
                    listViewItem.SubItems.Add(item.Price.ToString("C"));

                    MenuItemsListView.Items.Add(listViewItem);
                }
            }
        }


        private void MenuItemsListView_ItemActivate(object sender, EventArgs e)
        {
            if (MenuItemsListView.SelectedItems.Count > 0)
            {
                var selectedItem = MenuItemsListView.SelectedItems[0];
                var itemName = selectedItem.Text;

                using (var context = new AppDbContext())
                {
                    var item = context.POSItems.FirstOrDefault(i => i.Name == itemName);
                    if (item != null)
                    {
                        order.AddItem(item);
                        RefreshOrderList();
                    }
                }
            }
        }


        private void ButtonCompleteOrder_Click(object sender, EventArgs e)
        {
            if (!order.GetItems().Any())
            {
                MessageBox.Show("No items in the order.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var checkoutScreen = new CheckoutScreen(order, LoggedInUser);
            checkoutScreen.Show();
            this.Hide();
        }

        private void ButtonSpecialFunctions_Click(object sender, EventArgs e)
        {

            if (LoggedInUser is Manager)
            {
                var specialFunctionsScreen = new SpecialFunctionsScreen(LoggedInUser);
                specialFunctionsScreen.Show();
                this.Hide();

            }
            else if (LoggedInUser is TeamLead)

            {
                var specialFunctionsScreen = new SpecialFunctionsScreen(LoggedInUser);
                specialFunctionsScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied. Only managers & team leaders can view the sales report.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void RefreshOrderList()
        {
            OrderListView.Items.Clear();

            foreach (var item in order.GetItems())
            {
                var listViewItem = new ListViewItem(item.Name);

                listViewItem.SubItems.Add(item.Price.ToString("C"));

                OrderListView.Items.Add(listViewItem);
            }

            LabelTotal.Text = $"Total: {order.GetTotal():C}";
        }



        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ItemMenu_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

        private void LabelDateAndTime_Click(object sender, EventArgs e)
        {

        }

>>>>>>> Stashed changes
    }
}
