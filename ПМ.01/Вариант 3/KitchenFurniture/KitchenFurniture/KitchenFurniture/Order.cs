using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KitchenFurniture
{
    public partial class Order : Form
    {
        public class OrderItem
        {
            public string Product { get; set; } = string.Empty;     // ✅ Инициализация
            public string Dimensions { get; set; } = string.Empty;  // ✅ Инициализация
            public string Material { get; set; } = string.Empty;    // ✅ Инициализация
            public string Options { get; set; } = string.Empty;     // ✅ Инициализация
            public double Price { get; set; }
        }


        private List<OrderItem> orderItems = new List<OrderItem>();
        private double cabinetsTotal = 0;
        private double countertopsTotal = 0;

        public Order()
        {
            InitializeComponent();
        }

        public void AddCabinetOrder(double width, double height, string material, bool hasFurniture, bool hasLighting, double price)
        {
            string options = "";
            if (hasFurniture) options += "Фурнитура ";
            if (hasLighting) options += "Подсветка";
            if (string.IsNullOrEmpty(options)) options = "Нет";

            OrderItem item = new OrderItem
            {
                Product = "Шкаф",
                Dimensions = $"{width:F2} × {height:F2}",
                Material = material,
                Options = options,
                Price = price
            };

            orderItems.Add(item);
            cabinetsTotal += price;
            RefreshOrderDisplay();
        }

        public void AddCountertopOrder(double cost)
        {
            OrderItem item = new OrderItem
            {
                Product = "Столешница",
                Dimensions = "-",
                Material = "-",
                Options = "Изготовление столешницы",
                Price = cost
            };

            orderItems.Add(item);
            countertopsTotal = cost;
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
                    item.Material,
                    item.Options,
                    item.Price.ToString("F2") + " руб"
                );
            }

            double total = cabinetsTotal + countertopsTotal;
            labelCabinetsTotal.Text = $"Стоимость шкафов: {cabinetsTotal:F2} руб";
            labelCountertopsTotal.Text = $"Стоимость столешниц: {countertopsTotal:F2} руб";
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
            saveDialog.FileName = $"Заказ_кухня_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine("=========================================");
                        writer.WriteLine("      СМЕТА НА КУХОННУЮ МЕБЕЛЬ");
                        writer.WriteLine("=========================================");
                        writer.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");
                        writer.WriteLine($"Клиент: {textBoxCustomer.Text}");
                        writer.WriteLine($"Адрес: {textBoxAddress.Text}");
                        writer.WriteLine($"Телефон: {textBoxPhone.Text}");
                        writer.WriteLine("=========================================");
                        writer.WriteLine();

                        writer.WriteLine("№ | Изделие     | Размеры    | Материал   | Опции      | Стоимость");
                        writer.WriteLine("---------------------------------------------------------------");

                        int index = 1;
                        foreach (var item in orderItems)
                        {
                            writer.WriteLine($"{index,2} | {item.Product,-10} | {item.Dimensions,-10} | {item.Material,-10} | {item.Options,-10} | {item.Price:F2} руб");
                            index++;
                        }

                        writer.WriteLine("---------------------------------------------------------------");
                        writer.WriteLine($"Стоимость шкафов:     {cabinetsTotal:F2} руб");
                        writer.WriteLine($"Стоимость столешниц:  {countertopsTotal:F2} руб");
                        writer.WriteLine("---------------------------------------------------------------");
                        writer.WriteLine($"ОБЩАЯ СУММА:          {cabinetsTotal + countertopsTotal:F2} руб");
                        writer.WriteLine("=========================================");
                        writer.WriteLine("Спасибо за заказ! КухняПрофи");
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
                string orderData = $"Заказ кухни от {DateTime.Now:dd.MM.yyyy HH:mm}\n" +
                    $"Клиент: {textBoxCustomer.Text}\n" +
                    $"Адрес: {textBoxAddress.Text}\n" +
                    $"Телефон: {textBoxPhone.Text}\n" +
                    $"Шкафы: {cabinetsTotal:F2} руб\n" +
                    $"Столешницы: {countertopsTotal:F2} руб\n" +
                    $"Сумма: {cabinetsTotal + countertopsTotal:F2} руб\n" +
                    $"Статус: Новый";

                Clipboard.SetText(orderData);

                MessageBox.Show("Данные заказа скопированы в буфер обмена!\n" +
                    "Вы можете вставить их в систему учета.", "Заказ сохранен",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cabinetsTotal = 0;
                countertopsTotal = 0;
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
