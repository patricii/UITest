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
            else if (side == "2")
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
            else if (side == "3")
            {
                FormApp fs1 = new FormApp();
                iPosX = 0;
                iPosY = 0;
                fs1.StartPosition = FormStartPosition.Manual;
                fs1.Location = new Point(iPosX, iPosY);
                fs1.Width = rect.Width / 3;
                fs1.Height = rect.Height;
                fs1.labelSide.Text = "DUT 1";
                fs1.Show();

                FormApp fs2 = new FormApp();
                iPosX = rect.Width / 3;
                iPosY = 0;
                fs2.StartPosition = FormStartPosition.Manual;
                fs2.Location = new Point(iPosX, iPosY);
                fs2.Width = rect.Width / 3;
                fs2.Height = rect.Height;
                fs2.labelSide.Text = "DUT 2";
                fs2.Show();

                FormApp fs3 = new FormApp();
                iPosX = (rect.Width / 3 + rect.Width / 3);
                iPosY = 0;
                fs3.StartPosition = FormStartPosition.Manual;
                fs3.Location = new Point(iPosX, iPosY);
                fs3.Width = rect.Width / 3;
                fs3.Height = rect.Height;
                fs3.labelSide.Text = "DUT 3";
                fs3.Show();
            }
            else if (side == "4")
            {
                FormApp fs1 = new FormApp();
                iPosX = 0;
                iPosY = 0;
                fs1.StartPosition = FormStartPosition.Manual;
                fs1.Location = new Point(iPosX, iPosY);
                fs1.Width = rect.Width / 4;
                fs1.Height = rect.Height;
                fs1.labelSide.Text = "DUT 1";
                fs1.Show();

                FormApp fs2 = new FormApp();
                iPosX = rect.Width / 4;
                iPosY = 0;
                fs2.StartPosition = FormStartPosition.Manual;
                fs2.Location = new Point(iPosX, iPosY);
                fs2.Width = rect.Width / 4;
                fs2.Height = rect.Height;
                fs2.labelSide.Text = "DUT 2";
                fs2.Show();

                FormApp fs3 = new FormApp();
                iPosX = (rect.Width / 4 + rect.Width / 4);
                iPosY = 0;
                fs3.StartPosition = FormStartPosition.Manual;
                fs3.Location = new Point(iPosX, iPosY);
                fs3.Width = rect.Width / 4;
                fs3.Height = rect.Height;
                fs3.labelSide.Text = "DUT 3";
                fs3.Show();


                FormApp fs4 = new FormApp();
                iPosX = (rect.Width / 4 + rect.Width / 4 + rect.Width / 4);
                iPosY = 0;
                fs4.StartPosition = FormStartPosition.Manual;
                fs4.Location = new Point(iPosX, iPosY);
                fs4.Width = rect.Width / 4;
                fs4.Height = rect.Height;
                fs4.labelSide.Text = "DUT 4";
                fs4.Show();
            }
        }
    }
}
