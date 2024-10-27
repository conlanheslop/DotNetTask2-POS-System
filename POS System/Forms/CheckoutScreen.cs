using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Classes;

namespace POS_System.Forms
{
    public partial class CheckoutScreen : Form
    {
        private readonly POSUser loggedInUser;
        private readonly Order order;
        private Boolean paymentMade = false;

        public CheckoutScreen(Order currentOrder, POSUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loggedInUser = user;
            order = currentOrder;
            LoadOrderItems();
            ButtonRefund.Visible = false;
        }


        private void LoadOrderItems()
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


        private void ButtonCashPayment_Click(object sender, EventArgs e)
        {
            if (!paymentMade)
            {

                if (decimal.TryParse(TextBoxAmountTendered.Text, out decimal amountTendered))
                {
                    decimal total = order.GetTotal();
                    if (amountTendered >= total)
                    {
                        decimal change = amountTendered - total;
                        LabelChange.Text = $"Change: {change:C}"; ;
                        paymentMade = true;
                        ButtonRefund.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Not enough cash tendered. Please double check the amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount entered. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Payment has already been made! Do not double charge the customer", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ButtonEftpos_Click(object sender, EventArgs e)
        {

            if (!paymentMade)
            {
                var eftposScreen = new EftposScreen();
                eftposScreen.ShowDialog();
                paymentMade = true;
                ButtonRefund.Visible = true;
            }
            else
            {
                MessageBox.Show("Payment has already been made! Do not double charge the customer", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            var itemMenu = new ItemMenu(loggedInUser);
            itemMenu.Show();
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ButtonCompleteOrder_Click(object sender, EventArgs e)
        {

            if (paymentMade)
            {
                SaveOrder();
                var itemMenu = new ItemMenu(loggedInUser);
                itemMenu.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Payment not taken!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void SaveOrder()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // join the item IDs and seperate them by a comma
                    string joinedItemIds = string.Join(",", order.GetItems().Select(i => i.ItemID));

                    var completedOrder = new CompletedOrder
                    {
                        ItemIDs = joinedItemIds,
                        TotalPrice = order.GetTotal(),
                        Date = DateTime.Now
                    };

                    context.CompletedOrders.Add(completedOrder);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ButtonRefund_Click(object sender, EventArgs e)
        {

            // check if manager is logged in already
            if (loggedInUser.Role != "Manager")
            {
                using (var authorisationScreen = new AuthorisationScreen())
                {
                    authorisationScreen.ShowDialog();

                    if (!authorisationScreen.IsAuthorised)
                    {
                        MessageBox.Show("Manager login failed. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }


            // if logged in user is already a manager, no need to login again
            MessageBox.Show("Refund successful. If payment was via card it will be refunded within " +
                "2 working days. Otherwise you are now authorised to return the cash " +
                "tendered.", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information);
            paymentMade = false;
            ButtonRefund.Visible = false;
            order.Clear();
        }
    }
}

