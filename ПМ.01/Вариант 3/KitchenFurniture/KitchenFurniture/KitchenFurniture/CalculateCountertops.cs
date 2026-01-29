using System;
using System.Windows.Forms;

namespace KitchenFurniture
{
    public partial class CalculateCountertops : Form
    {
        private const double GRANITE_PRICE = 8500;
        private const double QUARTZ_PRICE = 12000;
        private const double LAMINATE_PRICE = 3500;
        private const double EDGE_PRICE = 500;
        private const double SINK_PRICE = 2500;      // ✅ Исправлено
        private const double COOKTOP_PRICE = 4000;   // ✅ Исправлено

        public double CountertopTotal { get; private set; }

        public CalculateCountertops()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            CalculateCountertopCost();
            buttonAddToOrder.Enabled = true;
        }

        private bool ValidateInput()
        {
            if (!double.TryParse(textBoxLength.Text, out double length) || length <= 0 || length > 10)
            {
                MessageBox.Show("Введите корректную длину (0.1-10 м)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLength.Focus();
                return false;
            }

            if (!double.TryParse(textBoxWidth.Text, out double width) || width <= 0 || width > 3)
            {
                MessageBox.Show("Введите корректную ширину (0.1-3 м)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxWidth.Focus();
                return false;
            }
            return true;
        }

        private void CalculateCountertopCost()
        {
            double length = double.Parse(textBoxLength.Text);
            double width = double.Parse(textBoxWidth.Text);
            double area = length * width;
            double total = 0;

            string? material = comboBoxMaterial.SelectedItem?.ToString(); // ✅ Nullable string
            double materialPrice = material switch
            {
                "Гранит" => GRANITE_PRICE,
                "Кварц" => QUARTZ_PRICE,
                _ => LAMINATE_PRICE
            };

            total += area * materialPrice;
            textBoxDetails.Text = $"Площадь: {area:F2} м² × {materialPrice} руб/м² = {area * materialPrice:F2} руб\r\n";

            if (checkBoxEdge.Checked)
            {
                double edgeCost = length * 2 * EDGE_PRICE;
                total += edgeCost;
                textBoxDetails.Text += $"Кромка по периметру: {edgeCost:F2} руб\r\n";
            }

            if (checkBoxSink.Checked)
            {
                total += SINK_PRICE;
                textBoxDetails.Text += $"Врезная мойка: {SINK_PRICE} руб\r\n";
            }

            if (checkBoxCooktop.Checked)
            {
                total += COOKTOP_PRICE;
                textBoxDetails.Text += $"Вырез под варочную панель: {COOKTOP_PRICE} руб\r\n";
            }

            textBoxDetails.Text += $"------------------------\r\nИТОГО: {total:F2} руб";
            CountertopTotal = total;
            labelTotal.Text = $"Итого: {total:F2} руб";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxLength.Clear();
            textBoxWidth.Clear();
            comboBoxMaterial.SelectedIndex = 0;
            checkBoxEdge.Checked = false;
            checkBoxSink.Checked = false;
            checkBoxCooktop.Checked = false;
            textBoxDetails.Clear();
            textBoxDetails.Text = "Детализация расчета появится здесь...";
            labelTotal.Text = "Итого: 0,00 руб";
            buttonAddToOrder.Enabled = false;
            CountertopTotal = 0;
            textBoxLength.Focus();
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (CountertopTotal > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
