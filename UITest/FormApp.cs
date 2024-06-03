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
    }
}
