namespace BTLfinal
{
    partial class baocaoSV
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
            this.crpv2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpv2
            // 
            this.crpv2.ActiveViewIndex = -1;
            this.crpv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpv2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpv2.Location = new System.Drawing.Point(0, 0);
            this.crpv2.Name = "crpv2";
            this.crpv2.Size = new System.Drawing.Size(800, 450);
            this.crpv2.TabIndex = 0;
            // 
            // baocaoSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crpv2);
            this.Name = "baocaoSV";
            this.Text = "baocaoSV";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crpv2;
    }
}