using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Exam
{
    public partial class Order : Form
    {
        public class OrderItem
        {
            public string Product { get; set; }
            public string Dimensions { get; set; }
            public string Profile { get; set; }
            public string Options { get; set; }
            public double Price { get; set; }
        }

        private List<OrderItem> orderItems = new List<OrderItem>();
        private double windowTotal = 0;
        private double deliveryTotal = 0;

        public Order()
        {
            InitializeComponent();
        }

        public void AddWindowOrder(double width, double height, string profile, bool hasSill, bool hasNet, double price)
        {
            string options = "";
            if (hasSill) options += "Подоконник ";
            if (hasNet) options += "Москитная сетка";
            if (string.IsNullOrEmpty(options)) options = "Нет";

            OrderItem item = new OrderItem
            {
                Product = "Окно",
                Dimensions = $"{width:F2} × {height:F2}",
                Profile = profile,
                Options = options,
                Price = price
            };

            orderItems.Add(item);
            windowTotal += price;
            RefreshOrderDisplay();
        }

        public void AddDeliveryOrder(double cost)
        {
            OrderItem item = new OrderItem
            {
                Product = "Доставка",
                Dimensions = "-",
                Profile = "-",
                Options = "Услуга доставки",
                Price = cost
            };

            orderItems.Add(item);
            deliveryTotal = cost;
            RefreshOrderDisplay();
        }

        private void RefreshOrderDisplay()
        {
            dataGridViewOrders.Rows.Clear();

            foreach (var item in orderItems)
            {
                dataGridViewOrders.Rows.Add(
                    item.Product,
                    item.Dimensions,
                    item.Profile,
                    item.Options,
                    item.Price.ToString("F2") + " руб"
                );
            }

            double total = windowTotal + deliveryTotal;
            labelWindowTotal.Text = $"Стоимость окон: {windowTotal:F2} руб";
            labelDeliveryTotal.Text = $"Стоимость доставки: {deliveryTotal:F2} руб";
            labelFinalTotal.Text = $"Общая сумма: {total:F2} руб";
        }

        private void Order_Load(object sender, EventArgs e)
        {
            RefreshOrderDisplay();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Заказ пуст! Добавьте товары.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            saveDialog.FileName = $"Заказ_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine("========================================");
                        writer.WriteLine("             СМЕТА НА ОКНА");
                        writer.WriteLine("========================================");
                        writer.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");
                        writer.WriteLine($"Клиент: {textBoxCustomer.Text}");
                        writer.WriteLine($"Адрес: {textBoxAddress.Text}");
                        writer.WriteLine($"Телефон: {textBoxPhone.Text}");
                        writer.WriteLine("========================================");
                        writer.WriteLine();

                        writer.WriteLine("№ | Изделие | Размеры | Профиль | Опции | Стоимость");
                        writer.WriteLine("------------------------------------------------------");

                        int index = 1;
                        foreach (var item in orderItems)
                        {
                            writer.WriteLine($"{index} | {item.Product} | {item.Dimensions} | {item.Profile} | {item.Options} | {item.Price:F2} руб");
                            index++;
                        }

                        writer.WriteLine("------------------------------------------------------");
                        writer.WriteLine($"Стоимость окон: {windowTotal:F2} руб");
                        writer.WriteLine($"Стоимость доставки: {deliveryTotal:F2} руб");
                        writer.WriteLine("------------------------------------------------------");
                        writer.WriteLine($"ОБЩАЯ СУММА: {windowTotal + deliveryTotal:F2} руб");
                        writer.WriteLine("========================================");
                        writer.WriteLine("Спасибо за заказ!");
                    }

                    MessageBox.Show($"Смета сохранена в файл:\n{saveDialog.FileName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomer.Text))
            {
                MessageBox.Show("Введите ФИО клиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCustomer.Focus();
                return;
            }

            if (orderItems.Count == 0)
            {
                MessageBox.Show("Заказ пуст! Добавьте товары.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string orderData = $"Заказ от {DateTime.Now}\n" +
                                 $"Клиент: {textBoxCustomer.Text}\n" +
                                 $"Адрес: {textBoxAddress.Text}\n" +
                                 $"Телефон: {textBoxPhone.Text}\n" +
                                 $"Сумма: {windowTotal + deliveryTotal:F2} руб\n" +
                                 $"Статус: Новый";

                Clipboard.SetText(orderData);

                MessageBox.Show("Данные заказа скопированы в буфер обмена!\n" +
                              "Вы можете вставить их в систему учета.",
                              "Заказ сохранен",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Очистить весь заказ?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                orderItems.Clear();
                windowTotal = 0;
                deliveryTotal = 0;
                textBoxCustomer.Clear();
                textBoxAddress.Clear();
                textBoxPhone.Clear();
                RefreshOrderDisplay();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }
    }
}