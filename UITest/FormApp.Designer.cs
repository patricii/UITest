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
            this.textBoxtrackid = new System.Windows.Forms.TextBox();
            this.labelTrackId = new System.Windows.Forms.Label();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSide
            // 
            this.labelSide.AutoSize = true;
            this.labelSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSide.Location = new System.Drawing.Point(12, 9);
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
            // textBoxtrackid
            // 
            this.textBoxtrackid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxtrackid.Location = new System.Drawing.Point(129, 71);
            this.textBoxtrackid.Name = "textBoxtrackid";
            this.textBoxtrackid.Size = new System.Drawing.Size(208, 20);
            this.textBoxtrackid.TabIndex = 2;
            this.textBoxtrackid.TextChanged += new System.EventHandler(this.textBoxtrackid_TextChanged);
            // 
            // labelTrackId
            // 
            this.labelTrackId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackId.Location = new System.Drawing.Point(206, 55);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(61, 13);
            this.labelTrackId.TabIndex = 3;
            this.labelTrackId.Text = "TRACKID";
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.AllowDrop = true;
            this.textBoxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogs.Location = new System.Drawing.Point(16, 119);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLogs.Size = new System.Drawing.Size(435, 677);
            this.textBoxLogs.TabIndex = 4;
            this.textBoxLogs.TabStop = false;
            this.textBoxLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 917);
            this.Controls.Add(this.textBoxLogs);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxtrackid);
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
        private System.Windows.Forms.TextBox textBoxtrackid;
        private System.Windows.Forms.Label labelTrackId;
        private System.Windows.Forms.TextBox textBoxLogs;
    }
}