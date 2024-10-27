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
    public partial class CheckoutScreen : Form
    {
        private readonly POSUser loggedInUser;
        private readonly Order order;
        private Boolean paymentMade = false;

        public CheckoutScreen(Order currentOrder, POSUser user)
        {
            InitializeComponent();
            loggedInUser = user;
            order = currentOrder;
            LoadOrderItems();
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
            if (decimal.TryParse(TextBoxAmountTendered.Text, out decimal amountTendered))
            {

                if (!paymentMade)
                {
                    decimal total = order.GetTotal();
                    if (amountTendered >= total)
                    {
                        decimal change = amountTendered - total;
                        LabelChange.Text = $"Change: {change:C}"; ;
                        paymentMade = true;
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
            }
            else
            {
                MessageBox.Show("Payment has already been made! Do not double charge the customer", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void ButtomCompleteOrder_Click(object sender, EventArgs e)
        {
            var itemMenu = new ItemMenu(loggedInUser);
            itemMenu.Show();
            this.Close();
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

        private void ButtonCompletePayment_Click(object sender, EventArgs e)
        {

            if (paymentMade)
            {
                var itemMenu = new ItemMenu(loggedInUser);
                itemMenu.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Payment not taken!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
