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
        public void DisplayMessageMutex()
        {
            mutexDut.WaitOne();
            labelTextMutex.Text = "TEST MUTEX";
            Thread.Sleep(2000);
            mutexDut.ReleaseMutex();
        }
    }
}
