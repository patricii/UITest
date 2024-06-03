using System;
using System.Drawing;
using System.Windows.Forms;

namespace UITest
{
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDut(comboBoxSelect.Text);
            Hide();
        }
        private void setDut(string side)
        {
            // Set window position //
            int iPosX;
            int iPosY;
            Rectangle rect = SystemInformation.VirtualScreen;

            if (side == "1")
            {
                FormApp fs1 = new FormApp();
                iPosX = 0;
                iPosY = 0;
                fs1.StartPosition = FormStartPosition.Manual;
                fs1.Location = new Point(iPosX, iPosY);
                fs1.Width = rect.Width / 2;
                fs1.Height = rect.Height;
                fs1.labelSide.Text = "DUT 1";
                fs1.Show();
            }
            else if(side == "2")
            {
                FormApp fs1 = new FormApp();
                iPosX = 0;
                iPosY = 0;
                fs1.StartPosition = FormStartPosition.Manual;
                fs1.Location = new Point(iPosX, iPosY);
                fs1.Width = rect.Width / 2;
                fs1.Height = rect.Height;
                fs1.labelSide.Text = "DUT 1";
                fs1.Show();

                FormApp fs2 = new FormApp();
                iPosX = rect.Width / 2;
                iPosY = 0;
                fs2.StartPosition = FormStartPosition.Manual;
                fs2.Location = new Point(iPosX, iPosY);
                fs2.Width = rect.Width / 2;
                fs2.Height = rect.Height;
                fs2.labelSide.Text = "DUT 2";
                fs2.Show();
            }
        }
    }
}
