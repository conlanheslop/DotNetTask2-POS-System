using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_System.Classes;
using System.Windows.Forms;

namespace POS_System.Forms
{
    public partial class SalesReportScreen : Form
    {
        public SalesReportScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            LoadSalesReport();
        }

        private void LoadSalesReport()
        {

            try
            {
                using (var context = new AppDbContext())
                {
                    var orders = context.CompletedOrders.ToList();

                    foreach (var order in orders)
                    {
                        var listViewItem = new ListViewItem(order.OrderID.ToString());
                        listViewItem.SubItems.Add(order.ItemIDs);
                        listViewItem.SubItems.Add(order.TotalPrice.ToString("C"));
                        listViewItem.SubItems.Add(order.Date.ToString("g"));

                        SalesListView.Items.Add(listViewItem);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}