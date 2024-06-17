using System;
using System.Threading;
using System.Windows.Forms;

namespace UITest
{
    public partial class FormMultiApp : Form
    {

        static CountdownEvent countdown = new CountdownEvent(4);
        public FormMultiApp()
        {
            InitializeComponent();
        }
        private void startThreads()
        {
            for (int i = 0; i < 4; i++)
            {
                int deviceIndex = i;
                Thread deviceThread = new Thread(() => DeviceThread(deviceIndex));
                deviceThread.Start();
                Application.DoEvents();
                Thread.Sleep(1000);
            }
        }
        private void AppendTextBoxDut1(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendTextBoxDut1), new object[] { value });
                return;
            }
            textBoxDut1.Text += value + Environment.NewLine;
        }
        private void AppendTextBoxDut2(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendTextBoxDut2), new object[] { value });
                return;
            }
            textBoxDut2.Text += value + Environment.NewLine;
        }
        private void AppendTextBoxDut3(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendTextBoxDut3), new object[] { value });
                return;
            }
            textBoxDut3.Text += value + Environment.NewLine;
        }
        private void AppendTextBoxDut4(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendTextBoxDut4), new object[] { value });
                return;
            }
            textBoxDut4.Text += value + Environment.NewLine;
        }
        private void DeviceThread(int deviceIndex)
        {
            Random random = new Random();
            int targetTemperature = 100;

            while (true)
            {
                int currentTemperature = random.Next(90, 110);
                switch (deviceIndex)
                {
                    case 1:
                        AppendTextBoxDut1($"Device {deviceIndex}: Current temperature is {currentTemperature}.");
                        break;
                    case 2:
                        AppendTextBoxDut2($"Device {deviceIndex}: Current temperature is {currentTemperature}.");
                        break;
                    case 3:
                        AppendTextBoxDut3($"Device {deviceIndex}: Current temperature is {currentTemperature}.");
                        break;
                    case 0:
                        AppendTextBoxDut4($"Device {4}: Current temperature is {currentTemperature}.");
                        break;
                }
                if (currentTemperature == targetTemperature)
                {
                    switch (deviceIndex)
                    {
                        case 1:
                            AppendTextBoxDut1($"Device {deviceIndex}: Target temperature reached.");
                            break;
                        case 2:
                            AppendTextBoxDut2($"Device {deviceIndex}: Target temperature reached.");
                            break;
                        case 3:
                            AppendTextBoxDut3($"Device {deviceIndex}: Target temperature reached.");
                            break;
                        case 0:
                            AppendTextBoxDut4($"Device {4}: Target temperature reached.");
                            break;
                    }
                    countdown.Signal();
                    break;
                }

                Thread.Sleep(1000);
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            startThreads();
        }
    }
}
