namespace BTLfinal
{
    partial class Menu
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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tacgia = new System.Windows.Forms.Button();
            this.theloai = new System.Windows.Forms.Button();
            this.themuon = new System.Windows.Forms.Button();
            this.sinhvien = new System.Windows.Forms.Button();
            this.Sach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Left.Controls.Add(this.button1);
            this.panel_Left.Controls.Add(this.tacgia);
            this.panel_Left.Controls.Add(this.theloai);
            this.panel_Left.Controls.Add(this.themuon);
            this.panel_Left.Controls.Add(this.sinhvien);
            this.panel_Left.Controls.Add(this.Sach);
            this.panel_Left.Controls.Add(this.pictureBox1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(144, 450);
            this.panel_Left.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tacgia
            // 
            this.tacgia.Location = new System.Drawing.Point(12, 307);
            this.tacgia.Name = "tacgia";
            this.tacgia.Size = new System.Drawing.Size(116, 40);
            this.tacgia.TabIndex = 5;
            this.tacgia.Text = "Tác Giả";
            this.tacgia.UseVisualStyleBackColor = true;
            this.tacgia.Click += new System.EventHandler(this.tacgia_Click);
            // 
            // theloai
            // 
            this.theloai.Location = new System.Drawing.Point(12, 261);
            this.theloai.Name = "theloai";
            this.theloai.Size = new System.Drawing.Size(116, 40);
            this.theloai.TabIndex = 4;
            this.theloai.Text = "Thể Loại";
            this.theloai.UseVisualStyleBackColor = true;
            this.theloai.Click += new System.EventHandler(this.theloai_Click);
            // 
            // themuon
            // 
            this.themuon.Location = new System.Drawing.Point(12, 215);
            this.themuon.Name = "themuon";
            this.themuon.Size = new System.Drawing.Size(116, 40);
            this.themuon.TabIndex = 3;
            this.themuon.Text = "Thẻ Mượn";
            this.themuon.UseVisualStyleBackColor = true;
            this.themuon.Click += new System.EventHandler(this.themuon_Click);
            // 
            // sinhvien
            // 
            this.sinhvien.Location = new System.Drawing.Point(12, 169);
            this.sinhvien.Name = "sinhvien";
            this.sinhvien.Size = new System.Drawing.Size(116, 40);
            this.sinhvien.TabIndex = 2;
            this.sinhvien.Text = "Sinh Viên";
            this.sinhvien.UseVisualStyleBackColor = true;
            this.sinhvien.Click += new System.EventHandler(this.sinhvien_Click);
            // 
            // Sach
            // 
            this.Sach.Location = new System.Drawing.Point(12, 123);
            this.Sach.Name = "Sach";
            this.Sach.Size = new System.Drawing.Size(116, 40);
            this.Sach.TabIndex = 1;
            this.Sach.Text = "Sách";
            this.Sach.UseVisualStyleBackColor = true;
            this.Sach.Click += new System.EventHandler(this.Sach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTLfinal.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Top.Controls.Add(this.textBox1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(144, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(656, 63);
            this.panel_Top.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(3, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Quản Lý Thư Viện";
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(144, 63);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(656, 387);
            this.panel_body.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tacgia;
        private System.Windows.Forms.Button theloai;
        private System.Windows.Forms.Button themuon;
        private System.Windows.Forms.Button sinhvien;
        private System.Windows.Forms.Button Sach;
        private System.Windows.Forms.Button button1;
    }
}