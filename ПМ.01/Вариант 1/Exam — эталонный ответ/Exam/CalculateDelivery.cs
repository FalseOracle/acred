using System;
using System.Windows.Forms;

namespace Exam
{
    public partial class CalculateDelivery : Form
    {
        // Тарифы
        private const double BASE_CITY_COST = 1200;
        private const double KM_COST = 50;
        private const double FLOOR_COST = 100;

        // Множители для районов
        private readonly double[] zoneMultipliers = { 1.0, 1.0, 1.1, 1.15 };

        // Для передачи результата в основную форму
        public double DeliveryTotal { get; private set; }

        public CalculateDelivery()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Настройка начального состояния
            comboBoxZone.SelectedIndex = 0; // Выбираем первый район по умолчанию
            textBoxDistance.Enabled = false;
            buttonAddDeliveryToOrder.Enabled = false;

            // Обработчики событий для RadioButtons
            radioButtonCity.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRegion.CheckedChanged += RadioButton_CheckedChanged;

            // Обработчики для валидации ввода
            textBoxDistance.KeyPress += TextBoxDistance_KeyPress;
            textBoxFloor.KeyPress += TextBoxFloor_KeyPress;
        }

        // Обработчик изменения типа доставки
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCity.Checked)
            {
                comboBoxZone.Enabled = true;
                textBoxDistance.Enabled = false;
                textBoxDistance.Clear();
                labelZone.Visible = true;
                comboBoxZone.Visible = true;
                labelDistance.Visible = false;
                textBoxDistance.Visible = false;
            }
            else if (radioButtonRegion.Checked)
            {
                comboBoxZone.Enabled = false;
                comboBoxZone.SelectedIndex = -1;
                textBoxDistance.Enabled = true;
                textBoxDistance.Focus();
                labelZone.Visible = false;
                comboBoxZone.Visible = false;
                labelDistance.Visible = true;
                textBoxDistance.Visible = true;
            }
        }

        // Валидация ввода для расстояния (только цифры и запятая)
        private void TextBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Проверка на одну запятую
            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        // Валидация ввода для этажа (только цифры)
        private void TextBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Кнопка "Рассчитать" - обработчик события
        private void buttonCalculateDelivery_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            CalculateDeliveryCost();
            buttonAddDeliveryToOrder.Enabled = true;
        }

        // Валидация ввода
        private bool ValidateInput()
        {
            // Проверка расстояния для загородной доставки
            if (radioButtonRegion.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBoxDistance.Text))
                {
                    MessageBox.Show("Введите расстояние для загородной доставки!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxDistance.Focus();
                    return false;
                }

                if (!double.TryParse(textBoxDistance.Text, out double distance) || distance <= 0 || distance > 200)
                {
                    MessageBox.Show("Введите корректное расстояние (0-200 км)!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxDistance.Focus();
                    textBoxDistance.SelectAll();
                    return false;
                }
            }

            // Проверка этажа (если заполнено)
            if (!string.IsNullOrWhiteSpace(textBoxFloor.Text))
            {
                if (!int.TryParse(textBoxFloor.Text, out int floor) || floor < 1 || floor > 25)
                {
                    MessageBox.Show("Введите корректный этаж (1-25)!",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxFloor.Focus();
                    textBoxFloor.SelectAll();
                    return false;
                }
            }

            return true;
        }

        // Основной расчет стоимости доставки
        private void CalculateDeliveryCost()
        {
            double total = 0;
            textBoxDetails.Clear();
            string details = "ДЕТАЛИЗАЦИЯ РАСЧЕТА:\r\n";
            details += "------------------------\r\n";

            // Расчет базовой стоимости
            if (radioButtonCity.Checked)
            {
                double baseCost = BASE_CITY_COST;
                int zoneIndex = comboBoxZone.SelectedIndex;

                if (zoneIndex >= 0 && zoneIndex < zoneMultipliers.Length)
                {
                    double multiplier = zoneMultipliers[zoneIndex];
                    double zoneCost = baseCost * multiplier;

                    total += zoneCost;
                    details += $"• Базовая доставка: {baseCost:F2} руб\r\n";

                    if (multiplier > 1.0)
                    {
                        double extra = zoneCost - baseCost;
                        details += $"• Надбавка за район ({comboBoxZone.Text}): {extra:F2} руб\r\n";
                    }
                }
            }
            else // За городом
            {
                double distance = double.Parse(textBoxDistance.Text);
                double baseCost = BASE_CITY_COST;
                double distanceCost = distance * KM_COST;

                total += baseCost + distanceCost;
                details += $"• Базовая доставка: {baseCost:F2} руб\r\n";
                details += $"• За {distance:F1} км × {KM_COST} руб/км: {distanceCost:F2} руб\r\n";
            }

            // Расчет стоимости подъема
            if (checkBoxNoElevator.Checked && !string.IsNullOrWhiteSpace(textBoxFloor.Text))
            {
                int floor = int.Parse(textBoxFloor.Text);
                if (floor > 1)
                {
                    double floorCost = (floor - 1) * FLOOR_COST;
                    total += floorCost;
                    details += $"• Подъем на {floor} этаж без лифта: {floorCost:F2} руб\r\n";
                }
            }

            // Итог
            details += "------------------------\r\n";
            details += $"ИТОГО: {total:F2} руб";

            textBoxDetails.Text = details;
            DeliveryTotal = total;
            labelDeliveryTotal.Text = $"Стоимость доставки: {total:F2} руб";
        }

        // Кнопка "Сброс" - обработчик события
        private void buttonResetDelivery_Click(object sender, EventArgs e)
        {
            radioButtonCity.Checked = true;
            comboBoxZone.SelectedIndex = 0;
            textBoxDistance.Clear();
            textBoxFloor.Clear();
            checkBoxNoElevator.Checked = false;
            textBoxDetails.Text = "Детализация расчета появится здесь после нажатия кнопки \"Рассчитать\"";
            labelDeliveryTotal.Text = "Стоимость доставки: 0.00 руб";
            buttonAddDeliveryToOrder.Enabled = false;
            DeliveryTotal = 0;

            // Восстанавливаем видимость элементов для городской доставки
            labelZone.Visible = true;
            comboBoxZone.Visible = true;
            labelDistance.Visible = false;
            textBoxDistance.Visible = false;
        }

        // Кнопка "Добавить к заказу" - обработчик события
        private void buttonAddDeliveryToOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Добавить стоимость доставки {DeliveryTotal:F2} руб к заказу?",
                          "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Устанавливаем результат формы в OK, чтобы главная форма знала, что данные добавлены
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // Для удобства - обработка нажатия Enter в текстовых полях
        private void textBoxDistance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCalculateDelivery_Click(sender, e);
                e.SuppressKeyPress = true; // Предотвращаем звуковой сигнал
            }
        }

        private void textBoxFloor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCalculateDelivery_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}