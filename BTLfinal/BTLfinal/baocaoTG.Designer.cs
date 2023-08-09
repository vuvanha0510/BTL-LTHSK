namespace BTLfinal
{
    partial class baocaoTG
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
            this.ctvvTg = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ctvvTg
            // 
            this.ctvvTg.ActiveViewIndex = -1;
            this.ctvvTg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctvvTg.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctvvTg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctvvTg.Location = new System.Drawing.Point(0, 0);
            this.ctvvTg.Name = "ctvvTg";
            this.ctvvTg.Size = new System.Drawing.Size(800, 450);
            this.ctvvTg.TabIndex = 0;
            // 
            // baocaoTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctvvTg);
            this.Name = "baocaoTG";
            this.Text = "baocaoTG";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctvvTg;
    }
}