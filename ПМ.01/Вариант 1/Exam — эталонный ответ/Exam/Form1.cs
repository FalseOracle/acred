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
    public partial class Form1 : Form
    {
        // Объявление элементов управления (контролов)
        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtWidth;
        private TextBox txtHeight;

        private GroupBox grpProfile;
        private RadioButton radioEconom;
        private RadioButton radioPremium;

        private GroupBox grpOptions;
        private CheckBox chkPodokonnik;
        private CheckBox chkSetka;

        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;
        public Form1()
        {
            // Настройка окна
            this.Text = "Калькулятор окон (СтройКомплект)";
            this.Size = new Size(450, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Фиксированный размер
            this.MaximizeBox = false;

            InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {
            // 1. Блок ввода размеров
            lblWidth = new Label() { Text = "Ширина окна (м):", Location = new Point(30, 20), AutoSize = true };
            txtWidth = new TextBox() { Location = new Point(30, 45), Size = new Size(150, 25) };

            lblHeight = new Label() { Text = "Высота окна (м):", Location = new Point(220, 20), AutoSize = true };
            txtHeight = new TextBox() { Location = new Point(220, 45), Size = new Size(150, 25) };

            // 2. Выбор профиля (RadioButton)
            grpProfile = new GroupBox() { Text = "Тип профиля", Location = new Point(30, 90), Size = new Size(370, 80) };

            radioEconom = new RadioButton() { Text = "Эконом (3000 руб/м²)", Location = new Point(20, 30), AutoSize = true, Checked = true };
            radioPremium = new RadioButton() { Text = "Премиум (5500 руб/м²)", Location = new Point(200, 30), AutoSize = true };

            grpProfile.Controls.Add(radioEconom);
            grpProfile.Controls.Add(radioPremium);

            // 3. Дополнительные опции (CheckBox)
            grpOptions = new GroupBox() { Text = "Дополнительно", Location = new Point(30, 190), Size = new Size(370, 90) };

            chkPodokonnik = new CheckBox() { Text = "Подоконник (+1500 руб)", Location = new Point(20, 30), AutoSize = true };
            chkSetka = new CheckBox() { Text = "Москитная сетка (+800 руб)", Location = new Point(20, 60), AutoSize = true };

            grpOptions.Controls.Add(chkPodokonnik);
            grpOptions.Controls.Add(chkSetka);

            // 4. Кнопка Расчета (Требование Маркетинга: Ярко-зеленая)
            btnCalculate = new Button();
            btnCalculate.Text = "РАССЧИТАТЬ СТОИМОСТЬ";
            btnCalculate.Location = new Point(30, 310);
            btnCalculate.Size = new Size(370, 50);
            btnCalculate.BackColor = Color.LimeGreen; // "Зеленый цвет успеха"
            btnCalculate.ForeColor = Color.White;
            btnCalculate.FlatStyle = FlatStyle.Flat; // Чтобы цвет был ярче
            btnCalculate.Font = new Font("Arial", 12, FontStyle.Bold);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.Click += BtnCalculate_Click; // Подписка на событие

            // 5. Кнопка Сброса
            btnClear = new Button();
            btnClear.Text = "Очистить форму";
            btnClear.Location = new Point(30, 370);
            btnClear.Size = new Size(370, 30);
            btnClear.Click += BtnClear_Click; // Подписка на событие

            // 6. Вывод результата (Требование Маркетинга: Крупно и жирно)
            lblResult = new Label();
            lblResult.Text = "Итого: 0,00 руб.";
            lblResult.Location = new Point(30, 430);
            lblResult.Size = new Size(370, 60);
            lblResult.Font = new Font("Segoe UI", 18, FontStyle.Bold); // Крупный жирный шрифт
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.BorderStyle = BorderStyle.FixedSingle;

            // Добавление на форму
            this.Controls.AddRange(new Control[] {
                lblWidth, txtWidth, lblHeight, txtHeight,
                grpProfile, grpOptions,
                btnCalculate, btnClear, lblResult
            });
        }

        //код обработчика события нажатия кнопки «Рассчитать»
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //парсим значения
            if (!TryParseSize(txtWidth.Text, "ширины", out double width) ||
                !TryParseSize(txtHeight.Text, "высоты", out double height))
            {
                return;
            }

            //проверка максимального значения
            if (!CheckMaxSize(width, height))
            {
                return;
            }

            //базовая стоимость
            double basePricePerUnit = radioEconom.Checked ? 3000 : 5500;
            double baseCost = width * height * basePricePerUnit;

            //дополнительные опции
            double additionalCost = 0;

            additionalCost += chkPodokonnik.Checked ? 1500 : 0;
            additionalCost += chkSetka.Checked ? 800 : 0;

            //итог
            double totalCost = baseCost + additionalCost;
            lblResult.Text = $"Итого: {totalCost:N2} руб.";
        }

        private bool TryParseSize(string text, string name, out double value)
        {
            if (!double.TryParse(text, out value) || value <= 0)
            {
                MessageBox.Show(
                    $"Пожалуйста, введите корректное значение {name} (положительное число)",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            return true;
        }

        private bool CheckMaxSize(double width, double height)
        {
            if (width > 3)
            {
                MessageBox.Show(
                    "Ширина не может превышать 3 метра. Пожалуйста, введите значение от 0 до 3 метров.",
                    "Ошибка: превышение размера",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (height > 3)
            {
                MessageBox.Show(
                    "Высота не может превышать 3 метра. Пожалуйста, введите значение от 0 до 3 метров.",
                    "Ошибка: превышение размера",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }

        private void ClearAllFields()
        {
            txtWidth.Clear();
            txtHeight.Clear();

            chkPodokonnik.Checked = false;
            chkSetka.Checked = false;

            lblResult.Text = "Итого: 0,00 руб.";
        }


        // Код метода/события для очистки полей формы 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }

}

