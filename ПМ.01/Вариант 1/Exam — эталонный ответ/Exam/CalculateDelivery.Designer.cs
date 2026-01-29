namespace Exam
{
    partial class CalculateDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.checkBoxNoElevator = new System.Windows.Forms.CheckBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.comboBoxZone = new System.Windows.Forms.ComboBox();
            this.labelZone = new System.Windows.Forms.Label();
            this.radioButtonRegion = new System.Windows.Forms.RadioButton();
            this.radioButtonCity = new System.Windows.Forms.RadioButton();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.labelDeliveryTotal = new System.Windows.Forms.Label();
            this.buttonCalculateDelivery = new System.Windows.Forms.Button();
            this.buttonResetDelivery = new System.Windows.Forms.Button();
            this.buttonAddDeliveryToOrder = new System.Windows.Forms.Button();
            this.groupBoxDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Controls.Add(this.checkBoxNoElevator);
            this.groupBoxDelivery.Controls.Add(this.textBoxFloor);
            this.groupBoxDelivery.Controls.Add(this.labelFloor);
            this.groupBoxDelivery.Controls.Add(this.textBoxDistance);
            this.groupBoxDelivery.Controls.Add(this.labelDistance);
            this.groupBoxDelivery.Controls.Add(this.comboBoxZone);
            this.groupBoxDelivery.Controls.Add(this.labelZone);
            this.groupBoxDelivery.Controls.Add(this.radioButtonRegion);
            this.groupBoxDelivery.Controls.Add(this.radioButtonCity);
            this.groupBoxDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDelivery.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(550, 180);
            this.groupBoxDelivery.TabIndex = 0;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "Параметры доставки";
            // 
            // checkBoxNoElevator
            // 
            this.checkBoxNoElevator.AutoSize = true;
            this.checkBoxNoElevator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNoElevator.Location = new System.Drawing.Point(20, 140);
            this.checkBoxNoElevator.Name = "checkBoxNoElevator";
            this.checkBoxNoElevator.Size = new System.Drawing.Size(188, 19);
            this.checkBoxNoElevator.TabIndex = 8;
            this.checkBoxNoElevator.Text = "Без лифта (ручной подъем)";
            this.checkBoxNoElevator.UseVisualStyleBackColor = true;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFloor.Location = new System.Drawing.Point(250, 138);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(80, 21);
            this.textBoxFloor.TabIndex = 7;
            this.textBoxFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFloor.Location = new System.Drawing.Point(200, 142);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(44, 15);
            this.labelFloor.TabIndex = 6;
            this.labelFloor.Text = "Этаж:";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Enabled = false;
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDistance.Location = new System.Drawing.Point(130, 85);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 21);
            this.textBoxDistance.TabIndex = 5;
            this.textBoxDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistance.Location = new System.Drawing.Point(17, 88);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(107, 15);
            this.labelDistance.TabIndex = 4;
            this.labelDistance.Text = "Расстояние (км):";
            // 
            // comboBoxZone
            // 
            this.comboBoxZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxZone.FormattingEnabled = true;
            this.comboBoxZone.Items.AddRange(new object[] {
            "Центральный",
            "Спальный район",
            "Промзона",
            "Отдаленный район"});
            this.comboBoxZone.Location = new System.Drawing.Point(130, 85);
            this.comboBoxZone.Name = "comboBoxZone";
            this.comboBoxZone.Size = new System.Drawing.Size(200, 23);
            this.comboBoxZone.TabIndex = 3;
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZone.Location = new System.Drawing.Point(17, 88);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(47, 15);
            this.labelZone.TabIndex = 2;
            this.labelZone.Text = "Район:";
            // 
            // radioButtonRegion
            // 
            this.radioButtonRegion.AutoSize = true;
            this.radioButtonRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRegion.Location = new System.Drawing.Point(20, 55);
            this.radioButtonRegion.Name = "radioButtonRegion";
            this.radioButtonRegion.Size = new System.Drawing.Size(95, 19);
            this.radioButtonRegion.TabIndex = 1;
            this.radioButtonRegion.TabStop = true;
            this.radioButtonRegion.Text = "За городом";
            this.radioButtonRegion.UseVisualStyleBackColor = true;
            // 
            // radioButtonCity
            // 
            this.radioButtonCity.AutoSize = true;
            this.radioButtonCity.Checked = true;
            this.radioButtonCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCity.Location = new System.Drawing.Point(20, 30);
            this.radioButtonCity.Name = "radioButtonCity";
            this.radioButtonCity.Size = new System.Drawing.Size(117, 19);
            this.radioButtonCity.TabIndex = 0;
            this.radioButtonCity.TabStop = true;
            this.radioButtonCity.Text = "В черте города";
            this.radioButtonCity.UseVisualStyleBackColor = true;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDetails.Location = new System.Drawing.Point(12, 210);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDetails.Size = new System.Drawing.Size(550, 150);
            this.textBoxDetails.TabIndex = 1;
            this.textBoxDetails.Text = "Детализация расчета появится здесь после нажатия кнопки \"Рассчитать\"";
            // 
            // labelDeliveryTotal
            // 
            this.labelDeliveryTotal.AutoSize = true;
            this.labelDeliveryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeliveryTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelDeliveryTotal.Location = new System.Drawing.Point(12, 380);
            this.labelDeliveryTotal.Name = "labelDeliveryTotal";
            this.labelDeliveryTotal.Size = new System.Drawing.Size(274, 24);
            this.labelDeliveryTotal.TabIndex = 2;
            this.labelDeliveryTotal.Text = "Стоимость доставки: 0.00 руб";
            // 
            // buttonCalculateDelivery
            // 
            this.buttonCalculateDelivery.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCalculateDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateDelivery.Location = new System.Drawing.Point(12, 420);
            this.buttonCalculateDelivery.Name = "buttonCalculateDelivery";
            this.buttonCalculateDelivery.Size = new System.Drawing.Size(120, 50);
            this.buttonCalculateDelivery.TabIndex = 3;
            this.buttonCalculateDelivery.Text = "Рассчитать";
            this.buttonCalculateDelivery.UseVisualStyleBackColor = false;
            this.buttonCalculateDelivery.Click += new System.EventHandler(this.buttonCalculateDelivery_Click);
            // 
            // buttonResetDelivery
            // 
            this.buttonResetDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetDelivery.Location = new System.Drawing.Point(150, 420);
            this.buttonResetDelivery.Name = "buttonResetDelivery";
            this.buttonResetDelivery.Size = new System.Drawing.Size(120, 50);
            this.buttonResetDelivery.TabIndex = 4;
            this.buttonResetDelivery.Text = "Сброс";
            this.buttonResetDelivery.UseVisualStyleBackColor = true;
            this.buttonResetDelivery.Click += new System.EventHandler(this.buttonResetDelivery_Click);
            // 
            // buttonAddDeliveryToOrder
            // 
            this.buttonAddDeliveryToOrder.Enabled = false;
            this.buttonAddDeliveryToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDeliveryToOrder.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAddDeliveryToOrder.Location = new System.Drawing.Point(400, 420);
            this.buttonAddDeliveryToOrder.Name = "buttonAddDeliveryToOrder";
            this.buttonAddDeliveryToOrder.Size = new System.Drawing.Size(162, 50);
            this.buttonAddDeliveryToOrder.TabIndex = 5;
            this.buttonAddDeliveryToOrder.Text = "Добавить к заказу";
            this.buttonAddDeliveryToOrder.UseVisualStyleBackColor = true;
            this.buttonAddDeliveryToOrder.Click += new System.EventHandler(this.buttonAddDeliveryToOrder_Click);
            // 
            // CalculateDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 484);
            this.Controls.Add(this.buttonAddDeliveryToOrder);
            this.Controls.Add(this.buttonResetDelivery);
            this.Controls.Add(this.buttonCalculateDelivery);
            this.Controls.Add(this.labelDeliveryTotal);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.groupBoxDelivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculateDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчет стоимости доставки";
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.CheckBox checkBoxNoElevator;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.ComboBox comboBoxZone;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.RadioButton radioButtonRegion;
        private System.Windows.Forms.RadioButton radioButtonCity;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Label labelDeliveryTotal;
        private System.Windows.Forms.Button buttonCalculateDelivery;
        private System.Windows.Forms.Button buttonResetDelivery;
        private System.Windows.Forms.Button buttonAddDeliveryToOrder;
    }
}