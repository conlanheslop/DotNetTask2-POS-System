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

        private readonly bool isTeamLead;

        public SalesReportScreen(bool isTeamLead)
        {
            InitializeComponent();
            isTeamLead = isTeamLead;
            StartPosition = FormStartPosition.CenterParent;


            // team leaders do not have access to full sales data, only today data.

            if (isTeamLead)
            {
                // hide date pickers for team leaders
                StartDatePicker.Visible = false;
                EndDatePicker.Visible = false;
                ButtonFilter.Visible = false;
                LabelTo.Visible = false;

                // only load today's sales data.
                LoadSalesReport(DateTime.Today, DateTime.Today.AddDays(1).AddSeconds(-1));

            }
            else
            {
                LoadSalesReport(); // load full sales report menu for managers only.
            }

        }

        private void LoadSalesReport(DateTime? startDate = null, DateTime? endDate = null)
        {

            using (var context = new AppDbContext())
            {
                var orders = context.CompletedOrders.AsQueryable();


                // date filter
                if (startDate.HasValue && endDate.HasValue)
                {
                    orders = orders.Where(o => o.Date >= startDate.Value && o.Date <= endDate.Value);
                }


                SalesListView.Items.Clear();

                foreach (var order in orders.ToList())
                {
                    var listViewItem = new ListViewItem(order.OrderID.ToString());
                    listViewItem.SubItems.Add(order.ItemIDs);
                    listViewItem.SubItems.Add(order.TotalPrice.ToString("C"));
                    listViewItem.SubItems.Add(order.Date.ToString("g"));

                    SalesListView.Items.Add(listViewItem);
                }
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value.Date;
            DateTime endDate = EndDatePicker.Value.Date;

            if (startDate > endDate)
            {
                LabelFilterError.Text = "End date must be after start date.";
                return;
            }

            // clear error text
            LabelFilterError.Text = "";


            LoadSalesReport(startDate, endDate);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}