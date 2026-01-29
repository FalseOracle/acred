using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PerfMeterWinForms
{
    public partial class Form1 : Form
    {
        private byte[] _memoryBlock;

        public Form1()
        {
            InitializeComponent();
            Text = "PerfMeterWinForms";
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();
            // Лёгкая операция
            lblResult.Text = "Готово";
            double limit = 1000000;
            double iter = 0;
            for (int i = 0; i < limit; i++)
            {
                iter++;
            }
                sw.Stop();
            lblResult.Text = $"Быстрый тест: время выполнения:{sw.ElapsedMilliseconds} ms | Количество операций в мс:{limit/sw.ElapsedMilliseconds}";
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            int ms = (int)nudCpuMs.Value;

            var sw = Stopwatch.StartNew();
            var cpuSw = Stopwatch.StartNew();

            double x = 0;
            while (cpuSw.ElapsedMilliseconds < ms)
            {
                // намеренная CPU-нагрузка
                x += Math.Sqrt(12345.6789) * Math.Sin(x + 0.1);
            }

            sw.Stop();
            lblResult.Text = $"CPU тест: целевое {ms} ms, фактически {sw.ElapsedMilliseconds} ms";
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            int mb = (int)nudMemMb.Value;
            _memoryBlock = new byte[mb * 1024 * 1024];

            // Чтобы память реально занялась (touch pages)
            for (int i = 0; i < _memoryBlock.Length; i += 4096)
                _memoryBlock[i] = 1;

            lblResult.Text = $"Память выделена: {mb} MB";
        }

        private void btnFreeMem_Click(object sender, EventArgs e)
        {
            _memoryBlock = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            lblResult.Text = "Память освобождена (GC выполнен)";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
