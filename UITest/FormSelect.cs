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
                FormApp fsLeft = new FormApp();
                iPosX = 0;
                iPosY = 0;
                fsLeft.StartPosition = FormStartPosition.Manual;
                fsLeft.Location = new Point(iPosX, iPosY);
                fsLeft.Width = rect.Width / 2;
                fsLeft.Height = rect.Height;
                fsLeft.labelSide.Text = "LEFT";
                fsLeft.Show();
            }
            else if(side == "2")
            {
                FormApp fsLeft = new FormApp();
                iPosX = 0;
                iPosY = 0;
                fsLeft.StartPosition = FormStartPosition.Manual;
                fsLeft.Location = new Point(iPosX, iPosY);
                fsLeft.Width = rect.Width / 2;
                fsLeft.Height = rect.Height;
                fsLeft.labelSide.Text = "LEFT";
                fsLeft.Show();

                FormApp fsRight = new FormApp();
                iPosX = rect.Width / 2;
                iPosY = 0;
                fsRight.StartPosition = FormStartPosition.Manual;
                fsRight.Location = new Point(iPosX, iPosY);
                fsRight.Width = rect.Width / 2;
                fsRight.Height = rect.Height;
                fsRight.labelSide.Text = "RIGHT";
                fsRight.Show();
            }
        }
    }
}
