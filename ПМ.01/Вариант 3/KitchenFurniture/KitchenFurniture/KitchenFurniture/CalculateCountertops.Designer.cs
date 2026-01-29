// CalculateCountertops.Designer.cs
namespace KitchenFurniture
{
    partial class CalculateCountertops
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private TextBox textBoxLength;
        private TextBox textBoxWidth;
        private ComboBox comboBoxMaterial;
        private Label labelMaterial;
        private CheckBox checkBoxEdge;
        private CheckBox checkBoxSink;
        private CheckBox checkBoxCooktop;
        private Button buttonCalculate;
        private Button buttonReset;
        private Button buttonAddToOrder;
        private Label labelTotal;
        private TextBox textBoxDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBoxLength = new TextBox();
            this.textBoxWidth = new TextBox();
            this.comboBoxMaterial = new ComboBox();
            this.labelMaterial = new Label();
            this.checkBoxEdge = new CheckBox();
            this.checkBoxSink = new CheckBox();
            this.checkBoxCooktop = new CheckBox();
            this.buttonCalculate = new Button();
            this.buttonReset = new Button();
            this.buttonAddToOrder = new Button();
            this.labelTotal = new Label();
            this.textBoxDetails = new TextBox();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.label1.Location = new Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new Size(121, 20);
            this.label1.Text = "Длина столешницы:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.label2.Location = new Point(230, 25);
            this.label2.Name = "label2";
            this.label2.Size = new Size(110, 20);
            this.label2.Text = "Ширина столешницы:";

            // textBoxLength
            this.textBoxLength.Location = new Point(30, 50);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new Size(120, 27);

            // textBoxWidth
            this.textBoxWidth.Location = new Point(230, 50);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new Size(120, 27);

            // comboBoxMaterial
            this.comboBoxMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] { "Ламинат", "Гранит", "Кварц" });
            this.comboBoxMaterial.Location = new Point(30, 100);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.SelectedIndex = 0;
            this.comboBoxMaterial.Size = new Size(320, 28);

            // labelMaterial
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelMaterial.Location = new Point(30, 75);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new Size(66, 20);
            this.labelMaterial.Text = "Материал:";

            // checkBoxEdge
            this.checkBoxEdge.AutoSize = true;
            this.checkBoxEdge.Location = new Point(30, 140);
            this.checkBoxEdge.Name = "checkBoxEdge";
            this.checkBoxEdge.Size = new Size(200, 24);
            this.checkBoxEdge.Text = "Кромка по периметру (+500 руб/пог.м)";

            // checkBoxSink
            this.checkBoxSink.AutoSize = true;
            this.checkBoxSink.Location = new Point(30, 170);
            this.checkBoxSink.Name = "checkBoxSink";
            this.checkBoxSink.Size = new Size(150, 24);
            this.checkBoxSink.Text = "Врезная мойка (+2500 руб)";

            // checkBoxCooktop
            this.checkBoxCooktop.AutoSize = true;
            this.checkBoxCooktop.Location = new Point(30, 200);
            this.checkBoxCooktop.Name = "checkBoxCooktop";
            this.checkBoxCooktop.Size = new Size(250, 24);
            this.checkBoxCooktop.Text = "Вырез под варочную панель (+4000 руб)";

            // buttonCalculate
            this.buttonCalculate.BackColor = Color.Orange;
            this.buttonCalculate.Font = new Font("Arial", 12F, FontStyle.Bold);
            this.buttonCalculate.ForeColor = Color.White;
            this.buttonCalculate.Location = new Point(30, 240);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new Size(320, 50);
            this.buttonCalculate.Text = "РАССЧИТАТЬ СТОИМОСТЬ";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new EventHandler(this.buttonCalculate_Click);

            // buttonReset
            this.buttonReset.Location = new Point(30, 300);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new Size(150, 35);
            this.buttonReset.Text = "Сброс";
            this.buttonReset.Click += new EventHandler(this.buttonReset_Click);

            // buttonAddToOrder
            this.buttonAddToOrder.BackColor = Color.FromArgb(76, 175, 80);
            this.buttonAddToOrder.Enabled = false;
            this.buttonAddToOrder.ForeColor = Color.White;
            this.buttonAddToOrder.Location = new Point(200, 300);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new Size(150, 35);
            this.buttonAddToOrder.Text = "Добавить в заказ";
            this.buttonAddToOrder.UseVisualStyleBackColor = false;
            this.buttonAddToOrder.Click += new EventHandler(this.buttonAddToOrder_Click);

            // labelTotal
            this.labelTotal.BorderStyle = BorderStyle.FixedSingle;
            this.labelTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.labelTotal.Location = new Point(30, 350);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new Size(320, 60);
            this.labelTotal.Text = "Итого: 0,00 руб";
            this.labelTotal.TextAlign = ContentAlignment.MiddleCenter;

            // textBoxDetails
            this.textBoxDetails.Location = new Point(30, 420);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.ScrollBars = ScrollBars.Vertical;
            this.textBoxDetails.Size = new Size(320, 180);
            this.textBoxDetails.Text = "Детализация расчета появится здесь...";

            // CalculateCountertops
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(380, 620);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.checkBoxCooktop);
            this.Controls.Add(this.checkBoxSink);
            this.Controls.Add(this.checkBoxEdge);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculateCountertops";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Калькулятор столешниц";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
