using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 form = new Form1();
            this.Hide();
            DialogResult result = form.ShowDialog();

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CalculateDelivery deliveryForm = new CalculateDelivery())
            {
                this.Hide();

                if (deliveryForm.ShowDialog() == DialogResult.OK)
                {
                    double deliveryCost = deliveryForm.DeliveryTotal;

                    if (deliveryCost > 0)
                    {
                        Order orderForm = Application.OpenForms.OfType<Order>().FirstOrDefault();

                        if (orderForm == null)
                        {
                            orderForm = new Order();
                        }

                        orderForm.AddDeliveryOrder(deliveryCost);
                        orderForm.Show();
                        orderForm.Focus();
                    }
                }

                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order();
            this.Hide();
            DialogResult result = orderForm.ShowDialog(); 
            
            this.Show();
        }
    }
}
