using System;
using System.Drawing;
using System.Windows.Forms;

namespace KitchenFurniture  
{
    public partial class CalculateCabinets : Form
    {
        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtWidth;
        private TextBox txtHeight;

        private GroupBox grpProfile;
        private RadioButton radioEconom;
        private RadioButton radioPremium;

        private GroupBox grpOptions;
        private CheckBox chkFurniture;
        private CheckBox chkLighting;

        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;

        public CalculateCabinets()
        {
            // Настройка окна
            this.Text = "Калькулятор шкафов (КухняПрофи)";
            this.Size = new Size(450, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // 1. Блок ввода размеров
            lblWidth = new Label() { Text = "Ширина шкафа (м):", Location = new Point(30, 20), AutoSize = true };
            txtWidth = new TextBox() { Location = new Point(30, 45), Size = new Size(150, 25) };

            lblHeight = new Label() { Text = "Высота шкафа (м):", Location = new Point(220, 20), AutoSize = true };
            txtHeight = new TextBox() { Location = new Point(220, 45), Size = new Size(150, 25) };

            // 2. Выбор корпуса (RadioButton)
            grpProfile = new GroupBox() { Text = "Тип корпуса", Location = new Point(30, 90), Size = new Size(370, 80) };

            radioEconom = new RadioButton() { Text = "Эконом (2500 руб/м²)", Location = new Point(20, 30), AutoSize = true, Checked = true };
            radioPremium = new RadioButton() { Text = "Премиум (4500 руб/м²)", Location = new Point(200, 30), AutoSize = true };

            grpProfile.Controls.Add(radioEconom);
            grpProfile.Controls.Add(radioPremium);

            // 3. Дополнительные опции (CheckBox)
            grpOptions = new GroupBox() { Text = "Дополнительно", Location = new Point(30, 190), Size = new Size(370, 90) };

            chkFurniture = new CheckBox() { Text = "Фурнитура (+2000 руб)", Location = new Point(20, 30), AutoSize = true };
            chkLighting = new CheckBox() { Text = "Подсветка (+1500 руб)", Location = new Point(20, 60), AutoSize = true };

            grpOptions.Controls.Add(chkFurniture);
            grpOptions.Controls.Add(chkLighting);

            // 4. Кнопка Расчета
            btnCalculate = new Button();
            btnCalculate.Text = "РАССЧИТАТЬ СТОИМОСТЬ";
            btnCalculate.Location = new Point(30, 310);
            btnCalculate.Size = new Size(370, 50);
            btnCalculate.BackColor = Color.Orange;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Arial", 12, FontStyle.Bold);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.Click += BtnCalculate_Click;

            // 5. Кнопка Сброса
            btnClear = new Button();
            btnClear.Text = "Очистить форму";
            btnClear.Location = new Point(30, 370);
            btnClear.Size = new Size(370, 30);
            btnClear.Click += BtnClear_Click;

            // 6. Вывод результата
            lblResult = new Label();
            lblResult.Text = "Итого: 0,00 руб.";
            lblResult.Location = new Point(30, 430);
            lblResult.Size = new Size(370, 60);
            lblResult.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.BorderStyle = BorderStyle.FixedSingle;

            // Добавление на форму
            this.Controls.AddRange(new Control[] {
                lblWidth, txtWidth, lblHeight, txtHeight,
                grpProfile, grpOptions,
                btnCalculate, btnClear, lblResult
            });
        }

        // Код обработчика события нажатия кнопки "Рассчитать стоимость"
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Проверяем ширину
            double width;
            if (!double.TryParse(txtWidth.Text, out width) || width <= 0 || width > 3)
            {
                MessageBox.Show("Ширина должна быть от 0.01 до 3 метров!", "Ошибка");
                txtWidth.Focus();
                return;
            }

            // 2. Проверяем высоту
            double height;
            if (!double.TryParse(txtHeight.Text, out height) || height <= 0 || height > 3)
            {
                MessageBox.Show("Высота должна быть от 0.01 до 3 метров!", "Ошибка");
                txtHeight.Focus();
                return;
            }

            // 3. Считаем площадь
            double ploshad = width * height;

            // 4. Цена за 1 м²
            double cena = radioEconom.Checked ? 2500 : 4500;

            // 5. Базовая стоимость
            double osnova = ploshad * cena;

            // 6. Опции
            double dop = 0;
            if (chkFurniture.Checked) dop += 2000;
            if (chkLighting.Checked) dop += 1500;

            // 7. Итого
            double itog = osnova + dop;

            // 8. Показываем результат
            lblResult.Text = "Итого: " + itog.ToString("F2") + " руб.";
        }


        // Код метода/события для очистки полей формы
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtWidth.Clear();
            txtHeight.Clear();
            radioEconom.Checked = true;
            chkFurniture.Checked = false;
            chkLighting.Checked = false;
            lblResult.Text = "Итого: 0,00 руб.";
            txtWidth.Focus();
        }


    }
}
