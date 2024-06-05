using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace UITest
{
    public partial class FormApp : Form
    {
        public static Mutex mutexDut = new Mutex();
        public FormApp()
        {
            InitializeComponent();
        }
        public void MutexMethodToCall()
        {
            mutexDut.WaitOne();
            // Anything to do!

            mutexDut.ReleaseMutex();
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBoxLogs.Text += value + Environment.NewLine;
        }
        public void CleanTextBox(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(CleanTextBox), new object[] { value });
                return;
            }
            textBoxLogs.TextAlign = HorizontalAlignment.Center;
            textBoxLogs.Text = value;
            textBoxLogs.BackColor = Color.Green;
            textBoxtrackid.Enabled = true;
        }
        private void setDefault()
        {
            textBoxtrackid.Text = "";
            textBoxLogs.Text = "";
            textBoxLogs.BackColor = Color.White;
            textBoxLogs.TextAlign = HorizontalAlignment.Left;
        }
        private void fakeResults(int i)
        {
            Random random = new Random();
            AppendTextBox(labelSide.Text + " ->TEST " + i.ToString() + " Result:" + random.Next(1200, 3900).ToString());
            Application.DoEvents();
            Thread.Sleep(300);
        }
        private void textBoxtrackid_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxtrackid.Text.Length != 10) { }
            else
            {
                textBoxtrackid.Enabled = false;
                setDefault();
                Thread thread = new Thread(() =>
                {
                    for (int i = 0; i <= 30; i++)
                    {
                        fakeResults(i);
                    }
                    CleanTextBox("PASS!!!");
                });
                thread.Start();
            }
        }
    }
}
