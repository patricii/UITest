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
        public void CleanTextBox(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(CleanTextBox), new object[] { value });
                return;
            }
            textBoxLogs.Text = value;
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
                        AppendTextBox("TESTE -> " + i.ToString() + " -> " + labelSide.Text);
                    }
                    MessageBox.Show(labelSide.Text + " : Finished!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CleanTextBox("PASS!!!");

                });
                thread.Start();
            }
        }
    }
}
