namespace UITest
{
    partial class FormMultiApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxDut1 = new System.Windows.Forms.TextBox();
            this.textBoxDut2 = new System.Windows.Forms.TextBox();
            this.textBoxDut3 = new System.Windows.Forms.TextBox();
            this.textBoxDut4 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.Controls.Add(this.textBoxDut1);
            this.flowLayoutPanel1.Controls.Add(this.textBoxDut2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxDut3);
            this.flowLayoutPanel1.Controls.Add(this.textBoxDut4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1403, 572);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBoxDut1
            // 
            this.textBoxDut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDut1.Location = new System.Drawing.Point(3, 3);
            this.textBoxDut1.Multiline = true;
            this.textBoxDut1.Name = "textBoxDut1";
            this.textBoxDut1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDut1.Size = new System.Drawing.Size(344, 559);
            this.textBoxDut1.TabIndex = 0;
            // 
            // textBoxDut2
            // 
            this.textBoxDut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDut2.Location = new System.Drawing.Point(353, 3);
            this.textBoxDut2.Multiline = true;
            this.textBoxDut2.Name = "textBoxDut2";
            this.textBoxDut2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDut2.Size = new System.Drawing.Size(344, 559);
            this.textBoxDut2.TabIndex = 1;
            // 
            // textBoxDut3
            // 
            this.textBoxDut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDut3.Location = new System.Drawing.Point(703, 3);
            this.textBoxDut3.Multiline = true;
            this.textBoxDut3.Name = "textBoxDut3";
            this.textBoxDut3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDut3.Size = new System.Drawing.Size(344, 559);
            this.textBoxDut3.TabIndex = 2;
            // 
            // textBoxDut4
            // 
            this.textBoxDut4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDut4.Location = new System.Drawing.Point(1053, 3);
            this.textBoxDut4.Multiline = true;
            this.textBoxDut4.Name = "textBoxDut4";
            this.textBoxDut4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDut4.Size = new System.Drawing.Size(344, 559);
            this.textBoxDut4.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(15, 34);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormMultiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 656);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormMultiApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMultiApp";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDut1;
        private System.Windows.Forms.TextBox textBoxDut2;
        private System.Windows.Forms.TextBox textBoxDut3;
        private System.Windows.Forms.TextBox textBoxDut4;
        private System.Windows.Forms.Button buttonStart;
    }
}