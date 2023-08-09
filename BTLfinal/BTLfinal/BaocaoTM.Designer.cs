namespace BTLfinal
{
    partial class BaocaoTM
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
            this.ctvvTM = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ctvvTM
            // 
            this.ctvvTM.ActiveViewIndex = -1;
            this.ctvvTM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctvvTM.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctvvTM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctvvTM.Location = new System.Drawing.Point(0, 0);
            this.ctvvTM.Name = "ctvvTM";
            this.ctvvTM.Size = new System.Drawing.Size(800, 450);
            this.ctvvTM.TabIndex = 0;
            // 
            // BaocaoTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctvvTM);
            this.Name = "BaocaoTM";
            this.Text = "BaocaoTM";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctvvTM;
    }
}