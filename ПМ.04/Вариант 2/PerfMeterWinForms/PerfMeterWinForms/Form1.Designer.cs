namespace PerfMeterWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TableLayoutPanel tableSettings;
        private System.Windows.Forms.Label lblCpuMs;
        private System.Windows.Forms.NumericUpDown nudCpuMs;
        private System.Windows.Forms.Label lblMemMb;
        private System.Windows.Forms.NumericUpDown nudMemMb;

        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.FlowLayoutPanel flowActions;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnCpu;
        private System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnFreeMem;

        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tableSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lblCpuMs = new System.Windows.Forms.Label();
            this.nudCpuMs = new System.Windows.Forms.NumericUpDown();
            this.lblMemMb = new System.Windows.Forms.Label();
            this.nudMemMb = new System.Windows.Forms.NumericUpDown();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.flowActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnCpu = new System.Windows.Forms.Button();
            this.btnMem = new System.Windows.Forms.Button();
            this.btnFreeMem = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tableMain.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.tableSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCpuMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemMb)).BeginInit();
            this.gbActions.SuspendLayout();
            this.flowActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableMain.Controls.Add(this.lblTitle, 0, 0);
            this.tableMain.Controls.Add(this.gbSettings, 0, 1);
            this.tableMain.Controls.Add(this.gbActions, 1, 1);
            this.tableMain.Controls.Add(this.lblResult, 0, 2);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.Size = new System.Drawing.Size(588, 300);
            this.tableMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.tableMain.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTitle.Location = new System.Drawing.Point(11, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(566, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Измерение характеристик ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.tableSettings);
            this.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSettings.Location = new System.Drawing.Point(11, 31);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSettings.Size = new System.Drawing.Size(338, 220);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Параметры тестов";
            // 
            // tableSettings
            // 
            this.tableSettings.AutoSize = true;
            this.tableSettings.ColumnCount = 2;
            this.tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableSettings.Controls.Add(this.lblCpuMs, 0, 0);
            this.tableSettings.Controls.Add(this.nudCpuMs, 1, 0);
            this.tableSettings.Controls.Add(this.lblMemMb, 0, 1);
            this.tableSettings.Controls.Add(this.nudMemMb, 1, 1);
            this.tableSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSettings.Location = new System.Drawing.Point(2, 15);
            this.tableSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableSettings.Name = "tableSettings";
            this.tableSettings.RowCount = 2;
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSettings.Size = new System.Drawing.Size(334, 48);
            this.tableSettings.TabIndex = 0;
            // 
            // lblCpuMs
            // 
            this.lblCpuMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCpuMs.Location = new System.Drawing.Point(2, 0);
            this.lblCpuMs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpuMs.Name = "lblCpuMs";
            this.lblCpuMs.Size = new System.Drawing.Size(179, 24);
            this.lblCpuMs.TabIndex = 0;
            this.lblCpuMs.Text = "CPU нагрузка, мс:";
            this.lblCpuMs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCpuMs
            // 
            this.nudCpuMs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCpuMs.Location = new System.Drawing.Point(185, 2);
            this.nudCpuMs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCpuMs.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCpuMs.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCpuMs.Name = "nudCpuMs";
            this.nudCpuMs.Size = new System.Drawing.Size(147, 20);
            this.nudCpuMs.TabIndex = 1;
            this.nudCpuMs.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblMemMb
            // 
            this.lblMemMb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMemMb.Location = new System.Drawing.Point(2, 24);
            this.lblMemMb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemMb.Name = "lblMemMb";
            this.lblMemMb.Size = new System.Drawing.Size(179, 24);
            this.lblMemMb.TabIndex = 2;
            this.lblMemMb.Text = "Память, МБ:";
            this.lblMemMb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMemMb
            // 
            this.nudMemMb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMemMb.Location = new System.Drawing.Point(185, 26);
            this.nudMemMb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudMemMb.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMemMb.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMemMb.Name = "nudMemMb";
            this.nudMemMb.Size = new System.Drawing.Size(147, 20);
            this.nudMemMb.TabIndex = 3;
            this.nudMemMb.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.flowActions);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbActions.Location = new System.Drawing.Point(353, 31);
            this.gbActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbActions.Name = "gbActions";
            this.gbActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbActions.Size = new System.Drawing.Size(224, 220);
            this.gbActions.TabIndex = 2;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Действия";
            // 
            // flowActions
            // 
            this.flowActions.Controls.Add(this.btnQuick);
            this.flowActions.Controls.Add(this.btnCpu);
            this.flowActions.Controls.Add(this.btnMem);
            this.flowActions.Controls.Add(this.btnFreeMem);
            this.flowActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowActions.Location = new System.Drawing.Point(2, 15);
            this.flowActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowActions.Name = "flowActions";
            this.flowActions.Size = new System.Drawing.Size(220, 203);
            this.flowActions.TabIndex = 0;
            this.flowActions.WrapContents = false;
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(4, 4);
            this.btnQuick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(195, 26);
            this.btnQuick.TabIndex = 0;
            this.btnQuick.Text = "Быстрый тест";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnCpu
            // 
            this.btnCpu.Location = new System.Drawing.Point(4, 38);
            this.btnCpu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(195, 26);
            this.btnCpu.TabIndex = 1;
            this.btnCpu.Text = "Нагрузочный тест (CPU)";
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnMem
            // 
            this.btnMem.Location = new System.Drawing.Point(4, 72);
            this.btnMem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(195, 26);
            this.btnMem.TabIndex = 2;
            this.btnMem.Text = "Выделить память";
            this.btnMem.UseVisualStyleBackColor = true;
            this.btnMem.Click += new System.EventHandler(this.btnMem_Click);
            // 
            // btnFreeMem
            // 
            this.btnFreeMem.Location = new System.Drawing.Point(4, 106);
            this.btnFreeMem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFreeMem.Name = "btnFreeMem";
            this.btnFreeMem.Size = new System.Drawing.Size(195, 26);
            this.btnFreeMem.TabIndex = 3;
            this.btnFreeMem.Text = "Освободить память";
            this.btnFreeMem.UseVisualStyleBackColor = true;
            this.btnFreeMem.Click += new System.EventHandler(this.btnFreeMem_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableMain.SetColumnSpan(this.lblResult, 2);
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Location = new System.Drawing.Point(11, 258);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(566, 34);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Готово к измерениям.";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 300);
            this.Controls.Add(this.tableMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(394, 248);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfMeterWinForms";
            this.tableMain.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.tableSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCpuMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemMb)).EndInit();
            this.gbActions.ResumeLayout(false);
            this.flowActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
