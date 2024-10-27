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
    public partial class EftposScreen : Form
    {
        public EftposScreen()
        {
            InitializeComponent();
            StartPaymentSimulation();
        }

        private void StartPaymentSimulation()
        {
            ProgressBarEftpos.Value = 0;
            timer1.Tick += (sender, e) =>
            {
                if (ProgressBarEftpos.Value < 100)
                {
                    ProgressBarEftpos.Value += 10;
                }

                else
                {
                    timer1.Stop();
                    System.Threading.Thread.Sleep(1000); // theatre
                    MessageBox.Show("Payment Approved!", "EFTPOS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            };
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}