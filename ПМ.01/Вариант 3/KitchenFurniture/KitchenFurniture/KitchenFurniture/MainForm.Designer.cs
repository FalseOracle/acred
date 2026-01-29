// MainForm.Designer.cs
namespace KitchenFurniture
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonCabinets;
        private Button buttonCountertops;
        private Button buttonOrder;
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
            this.buttonCabinets = new Button();
            this.buttonCountertops = new Button();
            this.buttonOrder = new Button();
            this.labelTitle = new Label();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.labelTitle.Location = new Point(100, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(300, 46);
            this.labelTitle.Text = "КУХНЯПРОФИ";
            this.labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // buttonCabinets
            this.buttonCabinets.BackColor = Color.FromArgb(46, 125, 50);
            this.buttonCabinets.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.buttonCabinets.ForeColor = Color.White;
            this.buttonCabinets.Location = new Point(50, 120);
            this.buttonCabinets.Name = "buttonCabinets";
            this.buttonCabinets.Size = new Size(400, 60);
            this.buttonCabinets.TabIndex = 0;
            this.buttonCabinets.Text = "🗄️ Калькулятор шкафов";
            this.buttonCabinets.UseVisualStyleBackColor = false;
            this.buttonCabinets.Click += new EventHandler(this.buttonCabinets_Click);

            // buttonCountertops
            this.buttonCountertops.BackColor = Color.FromArgb(255, 152, 0);
            this.buttonCountertops.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.buttonCountertops.ForeColor = Color.White;
            this.buttonCountertops.Location = new Point(50, 200);
            this.buttonCountertops.Name = "buttonCountertops";
            this.buttonCountertops.Size = new Size(400, 60);
            this.buttonCountertops.TabIndex = 1;
            this.buttonCountertops.Text = "🪵 Калькулятор столешниц";
            this.buttonCountertops.UseVisualStyleBackColor = false;
            this.buttonCountertops.Click += new EventHandler(this.buttonCountertops_Click);

            // buttonOrder
            this.buttonOrder.BackColor = Color.FromArgb(33, 150, 243);
            this.buttonOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.buttonOrder.ForeColor = Color.White;
            this.buttonOrder.Location = new Point(50, 280);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new Size(400, 60);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "📋 Форма заказа";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new EventHandler(this.buttonOrder_Click);

            // MainForm
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.ClientSize = new Size(500, 400);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonCountertops);
            this.Controls.Add(this.buttonCabinets);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Калькулятор кухонной мебели - КухняПрофи";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
