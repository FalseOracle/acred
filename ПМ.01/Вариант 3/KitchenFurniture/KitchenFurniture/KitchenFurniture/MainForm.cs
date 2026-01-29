// MainForm.cs
using System;
using System.Linq;
using System.Windows.Forms;

namespace KitchenFurniture
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCabinets_Click(object sender, EventArgs e)
        {
            CalculateCabinets form = new CalculateCabinets();
            this.Hide();
            DialogResult result = form.ShowDialog();
            this.Show();
        }

        private void buttonCountertops_Click(object sender, EventArgs e)
        {
            using (CalculateCountertops countertopForm = new CalculateCountertops())
            {
                this.Hide();
                if (countertopForm.ShowDialog() == DialogResult.OK)
                {
                    double countertopCost = countertopForm.CountertopTotal;
                    if (countertopCost > 0)
                    {
                        Order orderForm = Application.OpenForms.OfType<Order>().FirstOrDefault();
                        if (orderForm == null)
                        {
                            orderForm = new Order();
                        }
                        orderForm.AddCountertopOrder(countertopCost);
                        orderForm.Show();
                        orderForm.Focus();
                    }
                }
                this.Show();
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order();
            this.Hide();
            DialogResult result = orderForm.ShowDialog();
            this.Show();
        }
    }
}
