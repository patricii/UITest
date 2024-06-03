namespace UITest
{
    partial class FormApp
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
            this.labelSide = new System.Windows.Forms.Label();
            this.labelTextMutex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSide
            // 
            this.labelSide.AutoSize = true;
            this.labelSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSide.Location = new System.Drawing.Point(17, 9);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(0, 20);
            this.labelSide.TabIndex = 0;
            this.labelSide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTextMutex
            // 
            this.labelTextMutex.AutoSize = true;
            this.labelTextMutex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextMutex.Location = new System.Drawing.Point(94, 188);
            this.labelTextMutex.Name = "labelTextMutex";
            this.labelTextMutex.Size = new System.Drawing.Size(0, 25);
            this.labelTextMutex.TabIndex = 1;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 490);
            this.Controls.Add(this.labelTextMutex);
            this.Controls.Add(this.labelSide);
            this.Name = "FormApp";
            this.Text = "UIApplication v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelSide;
        private System.Windows.Forms.Label labelTextMutex;
    }
}