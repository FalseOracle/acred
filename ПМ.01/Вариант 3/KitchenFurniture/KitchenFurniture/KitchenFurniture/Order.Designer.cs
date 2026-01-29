namespace KitchenFurniture
{
    partial class Order
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewOrders;
        private TextBox textBoxCustomer;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private Label labelCustomer;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelCabinetsTotal;
        private Label labelCountertopsTotal;
        private Label labelFinalTotal;
        private Button buttonPrint;
        private Button buttonSave;
        private Button buttonClear;
        private Button buttonClose;
        private Label labelTitle;

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
            this.dataGridViewOrders = new DataGridView();
            this.textBoxCustomer = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxPhone = new TextBox();
            this.labelCustomer = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelCabinetsTotal = new Label();
            this.labelCountertopsTotal = new Label();
            this.labelFinalTotal = new Label();
            this.buttonPrint = new Button();
            this.buttonSave = new Button();
            this.buttonClear = new Button();
            this.buttonClose = new Button();
            this.labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();

            // dataGridViewOrders
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new Point(20, 120);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.RowTemplate.Height = 29;
            this.dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new Size(760, 250);
            this.dataGridViewOrders.TabIndex = 0;

            // Настройка колонок
            this.dataGridViewOrders.Columns.Add("Product", "Изделие");
            this.dataGridViewOrders.Columns.Add("Dimensions", "Размеры");
            this.dataGridViewOrders.Columns.Add("Material", "Материал");
            this.dataGridViewOrders.Columns.Add("Options", "Опции");
            this.dataGridViewOrders.Columns.Add("Price", "Стоимость");
            this.dataGridViewOrders.Columns["Product"].Width = 100;
            this.dataGridViewOrders.Columns["Dimensions"].Width = 100;
            this.dataGridViewOrders.Columns["Material"].Width = 120;
            this.dataGridViewOrders.Columns["Options"].Width = 150;
            this.dataGridViewOrders.Columns["Price"].Width = 120;

            // textBoxCustomer
            this.textBoxCustomer.Location = new Point(150, 25);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new Size(300, 27);
            this.textBoxCustomer.TabIndex = 1;

            // textBoxAddress
            this.textBoxAddress.Location = new Point(150, 55);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(300, 27);
            this.textBoxAddress.TabIndex = 2;

            // textBoxPhone
            this.textBoxPhone.Location = new Point(150, 85);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(200, 27);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.KeyPress += new KeyPressEventHandler(this.textBoxPhone_KeyPress);

            // labelCustomer
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelCustomer.Location = new Point(20, 28);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new Size(35, 20);
            this.labelCustomer.Text = "Клиент:";

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelAddress.Location = new Point(20, 58);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new Size(52, 20);
            this.labelAddress.Text = "Адрес:";

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelPhone.Location = new Point(20, 88);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(64, 20);
            this.labelPhone.Text = "Телефон:";

            // labelCabinetsTotal
            this.labelCabinetsTotal.AutoSize = true;
            this.labelCabinetsTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelCabinetsTotal.Location = new Point(20, 390);
            this.labelCabinetsTotal.Name = "labelCabinetsTotal";
            this.labelCabinetsTotal.Size = new Size(200, 23);
            this.labelCabinetsTotal.Text = "Стоимость шкафов: 0,00 руб";

            // labelCountertopsTotal
            this.labelCountertopsTotal.AutoSize = true;
            this.labelCountertopsTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelCountertopsTotal.Location = new Point(20, 420);
            this.labelCountertopsTotal.Name = "labelCountertopsTotal";
            this.labelCountertopsTotal.Size = new Size(240, 23);
            this.labelCountertopsTotal.Text = "Стоимость столешниц: 0,00 руб";

            // labelFinalTotal
            this.labelFinalTotal.AutoSize = true;
            this.labelFinalTotal.BackColor = Color.FromArgb(255, 235, 59);
            this.labelFinalTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.labelFinalTotal.Location = new Point(20, 450);
            this.labelFinalTotal.Name = "labelFinalTotal";
            this.labelFinalTotal.Size = new Size(180, 32);
            this.labelFinalTotal.Text = "Общая сумма: 0,00 руб";

            // buttonPrint
            this.buttonPrint.BackColor = Color.FromArgb(76, 175, 80);
            this.buttonPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonPrint.ForeColor = Color.White;
            this.buttonPrint.Location = new Point(20, 500);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(140, 40);
            this.buttonPrint.Text = "🖨️ Печать сметы";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new EventHandler(this.buttonPrint_Click);

            // buttonSave
            this.buttonSave.BackColor = Color.FromArgb(33, 150, 243);
            this.buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonSave.ForeColor = Color.White;
            this.buttonSave.Location = new Point(170, 500);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(140, 40);
            this.buttonSave.Text = "💾 Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);

            // buttonClear
            this.buttonClear.BackColor = Color.FromArgb(244, 67, 54);
            this.buttonClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonClear.ForeColor = Color.White;
            this.buttonClear.Location = new Point(320, 500);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new Size(100, 40);
            this.buttonClear.Text = "🗑️ Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new EventHandler(this.buttonClear_Click);

            // buttonClose
            this.buttonClose.BackColor = Color.Gray;
            this.buttonClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonClose.ForeColor = Color.White;
            this.buttonClose.Location = new Point(640, 500);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(140, 40);
            this.buttonClose.Text = "❌ Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.labelTitle.Location = new Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(250, 41);
            this.labelTitle.Text = "📋 ФОРМА ЗАКАЗА";

            // Order
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 560);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelFinalTotal);
            this.Controls.Add(this.labelCountertopsTotal);
            this.Controls.Add(this.labelCabinetsTotal);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Заказ кухонной мебели - КухняПрофи";
            this.Load += new EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
