namespace Exam
{
    partial class Order
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelWindowTotal = new System.Windows.Forms.Label();
            this.labelDeliveryTotal = new System.Windows.Forms.Label();
            this.labelFinalTotal = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewOrders
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduct,
            this.ColumnDimensions,
            this.ColumnProfile,
            this.ColumnOptions,
            this.ColumnPrice});
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewOrders.TabIndex = 0;

            // ColumnProduct
            this.ColumnProduct.HeaderText = "Изделие";
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.ReadOnly = true;
            this.ColumnProduct.Width = 150;

            // ColumnDimensions
            this.ColumnDimensions.HeaderText = "Размеры (м)";
            this.ColumnDimensions.Name = "ColumnDimensions";
            this.ColumnDimensions.ReadOnly = true;

            // ColumnProfile
            this.ColumnProfile.HeaderText = "Профиль";
            this.ColumnProfile.Name = "ColumnProfile";
            this.ColumnProfile.ReadOnly = true;

            // ColumnOptions
            this.ColumnOptions.HeaderText = "Опции";
            this.ColumnOptions.Name = "ColumnOptions";
            this.ColumnOptions.ReadOnly = true;
            this.ColumnOptions.Width = 200;

            // ColumnPrice
            this.ColumnPrice.HeaderText = "Стоимость";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;

            // labelWindowTotal
            this.labelWindowTotal.AutoSize = true;
            this.labelWindowTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindowTotal.Location = new System.Drawing.Point(12, 275);
            this.labelWindowTotal.Name = "labelWindowTotal";
            this.labelWindowTotal.Size = new System.Drawing.Size(174, 17);
            this.labelWindowTotal.TabIndex = 1;
            this.labelWindowTotal.Text = "Стоимость окон: 0.00 руб";

            // labelDeliveryTotal
            this.labelDeliveryTotal.AutoSize = true;
            this.labelDeliveryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeliveryTotal.Location = new System.Drawing.Point(12, 300);
            this.labelDeliveryTotal.Name = "labelDeliveryTotal";
            this.labelDeliveryTotal.Size = new System.Drawing.Size(185, 17);
            this.labelDeliveryTotal.TabIndex = 2;
            this.labelDeliveryTotal.Text = "Стоимость доставки: 0.00 руб";

            // labelFinalTotal
            this.labelFinalTotal.AutoSize = true;
            this.labelFinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalTotal.ForeColor = System.Drawing.Color.Green;
            this.labelFinalTotal.Location = new System.Drawing.Point(12, 330);
            this.labelFinalTotal.Name = "labelFinalTotal";
            this.labelFinalTotal.Size = new System.Drawing.Size(226, 24);
            this.labelFinalTotal.TabIndex = 3;
            this.labelFinalTotal.Text = "Общая сумма: 0.00 руб";

            // buttonPrint
            this.buttonPrint.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(12, 370);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(120, 50);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Печать сметы";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);

            // buttonSave
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(150, 370);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 50);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // buttonClear
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(288, 370);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 50);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить заказ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            // groupBoxCustomer
            this.groupBoxCustomer.Controls.Add(this.textBoxPhone);
            this.groupBoxCustomer.Controls.Add(this.labelPhone);
            this.groupBoxCustomer.Controls.Add(this.textBoxAddress);
            this.groupBoxCustomer.Controls.Add(this.labelAddress);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomer);
            this.groupBoxCustomer.Controls.Add(this.labelCustomer);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(450, 268);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(338, 152);
            this.groupBoxCustomer.TabIndex = 7;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Данные клиента";

            // textBoxPhone
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(100, 100);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 21);
            this.textBoxPhone.TabIndex = 5;

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(20, 103);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(68, 15);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Телефон:";

            // textBoxAddress
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(100, 60);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 21);
            this.textBoxAddress.TabIndex = 3;

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(20, 63);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 15);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Адрес:";

            // textBoxCustomer
            this.textBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCustomer.Location = new System.Drawing.Point(100, 25);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(200, 21);
            this.textBoxCustomer.TabIndex = 1;

            // labelCustomer
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.Location = new System.Drawing.Point(20, 28);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(39, 15);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "ФИО:";

            // buttonClose
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(668, 370);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 50);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);

            // Order
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelFinalTotal);
            this.Controls.Add(this.labelDeliveryTotal);
            this.Controls.Add(this.labelWindowTotal);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.Label labelWindowTotal;
        private System.Windows.Forms.Label labelDeliveryTotal;
        private System.Windows.Forms.Label labelFinalTotal;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Button buttonClose;
    }
}