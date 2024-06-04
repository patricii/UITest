using System;
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
        private void textBoxtrackid_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxtrackid.Text.Length != 10)
            {
                //do nothing!
            }
            else
            {
                textBoxtrackid.Text = "";
                Thread thread = new Thread(() =>
                {
                    for (int i = 0; i <= 30; i++)
                    {

                        Application.DoEvents();
                        Thread.Sleep(500);
                        AppendTextBox("TESTE -> " + i.ToString());
                    }

                });
                thread.Start();
            }
        }
    }
}
