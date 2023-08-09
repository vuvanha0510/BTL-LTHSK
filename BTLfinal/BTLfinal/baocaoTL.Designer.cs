namespace BTLfinal
{
    partial class baocaoTL
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
            this.ctvvTL = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ctvvTL
            // 
            this.ctvvTL.ActiveViewIndex = -1;
            this.ctvvTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctvvTL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctvvTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctvvTL.Location = new System.Drawing.Point(0, 0);
            this.ctvvTL.Name = "ctvvTL";
            this.ctvvTL.Size = new System.Drawing.Size(800, 450);
            this.ctvvTL.TabIndex = 0;
            // 
            // baocaoTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctvvTL);
            this.Name = "baocaoTL";
            this.Text = "baocaoTL";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctvvTL;
    }
}