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
        private void createInstance(int dutNumber, int divisionCalc, int referenceWidth)
        {
            // Set window position //
            int iPosX;
            int iPosY;
            Rectangle rect = SystemInformation.VirtualScreen;
            FormApp fA = new FormApp();

            if (divisionCalc == 0)
                iPosX = 0;
            else if (dutNumber == 3)
                iPosX = rect.Width / divisionCalc + rect.Width / divisionCalc;
            else if (dutNumber == 4)
                iPosX = rect.Width / divisionCalc + rect.Width / divisionCalc + rect.Width / divisionCalc;
            else
                iPosX = rect.Width / divisionCalc;

            iPosY = 0;
            fA.StartPosition = FormStartPosition.Manual;
            fA.Location = new Point(iPosX, iPosY);
            fA.Width = rect.Width / referenceWidth;
            fA.Height = rect.Height - 40;
            fA.labelSide.Text = "DUT " + dutNumber.ToString();
            fA.Show();

        }
        private void setDut(string duts)
        {
            if (duts == "1")
                createInstance(1, 0, 2);

            else if (duts == "2")
            {
                createInstance(1, 0, 2);
                createInstance(2, 2, 2);
            }
            else if (duts == "3")
            {
                createInstance(1, 0, 3);
                createInstance(2, 3, 3);
                createInstance(3, 3, 3);
            }
            else if (duts == "4")
            {
                createInstance(1, 0, 4);
                createInstance(2, 4, 4);
                createInstance(3, 4, 4);
                createInstance(4, 4, 4);
            }
        }
    }
}
