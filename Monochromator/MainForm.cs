using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Monochromator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetPorts();
            // Регистрация обработчика получения точки
            getDataPoint += Plot;
        }

        private void GetPorts()
        {
            var ports = Port.GetPortNames();
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(ports);
            try
            {
                comboBoxPort.Text = ports[0];
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Нет портов",
                    "Ошибка ввода/вывода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetPorts();
        }

        private void EnableControls(bool enabled)
        {
            textBoxA0.Enabled = enabled;
            textBoxEncoderStep.Enabled = enabled;
            textBoxL0.Enabled = enabled;
            textBoxL1.Enabled = enabled;
            buttonStart.Enabled = enabled;
            comboBoxPort.Enabled = enabled;
            buttonRefresh.Enabled = enabled;
            buttonSaveImage.Enabled = enabled;
            buttonSaveData.Enabled = enabled;
        }

        private delegate void GetDataPointHandler(double wl, double d);
        private event GetDataPointHandler getDataPoint;

        private struct Pair { public double X, Y; };
        private List<Pair> data;
        private void GetDataFromPort(string portName, double wl0, double wl1, double a0, double astep)
        {
            var a_begin = WaveLength.ToDegrees(wl0);    // Начальный измеряемый угол
            var a_end = WaveLength.ToDegrees(wl1);      // Конечный измеряемый угол

            data = new List<Pair>();
            double wl, d;

            using (var port = new Port(portName)) {
                for (var a = a0; a <= a_end; a += astep)
                {
                    d = port.GetData();
                    if (a > a_begin)
                    {
                        wl = WaveLength.FromDegrees(a);
                        // Добавляем данные в список
                        data.Add(new Pair{X=wl, Y=d});
                        // Генерация события
                        getDataPoint?.Invoke(wl, d);
                    }
                }
            }
        }
        
        private void Plot(double wl, double d)
        {
            Invoke((MethodInvoker)delegate () {
                chart.Series[0].Points.AddXY(wl, d);
            });
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            double 
                wl0,    // Начальная длина волны
                wl1,    // Конечная длина волны
                astep,  // Шаг угла энкодера
                a0;     // Начальный угол

            // Получение параметров
            try
            {
                wl0 = double.Parse(textBoxL0.Text);
                wl1 = double.Parse(textBoxL1.Text);
                astep = double.Parse(textBoxEncoderStep.Text);
                a0 = double.Parse(textBoxA0.Text);
            } catch (FormatException)
            {
                MessageBox.Show(
                    "Неверный формат чисел",
                    "Неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на корректность
            if (wl0 < WaveLength.Min || wl0 > WaveLength.Max ||
                wl1 < WaveLength.Min || wl1 > WaveLength.Max)
            {
                MessageBox.Show(string.Format(
                    "Длины волн должны быть в диапазоне {0}..{1}", 
                    WaveLength.Min,
                    WaveLength.Max
                    ), "Неверный диапазон", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Блокировка элементов управления
            EnableControls(false);

            // Очиска формы
            chart.Series[0].Points.Clear();
            // Диапазон по оси абсцисс
            chart.ChartAreas[0].AxisX.Minimum = wl0;
            chart.ChartAreas[0].AxisX.Maximum = wl1;

            // Асинхронный запрос данных
            var portName = comboBoxPort.SelectedItem as string;
            await Task.Run(()=>GetDataFromPort(portName, wl0, wl1, a0, astep));
            
            // Разблокировка элементов управления
            EnableControls(true);
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            saveImage.ShowDialog();
            chart.SaveImage(saveImage.FileName, ChartImageFormat.Png);
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            saveData.ShowDialog();
            using (var f = File.CreateText(saveData.FileName))
                foreach (var d in data)
                    f.WriteLine("{0};{1}", d.X, d.Y);
        }
    }
}
