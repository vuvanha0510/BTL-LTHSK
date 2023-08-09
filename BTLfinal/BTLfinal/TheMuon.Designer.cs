namespace BTLfinal
{
    partial class TheMuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.hienthilai = new System.Windows.Forms.Button();
            this.TBmasach = new System.Windows.Forms.TextBox();
            this.TBsoluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBmasv = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.TBsothe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntINDS = new System.Windows.Forms.Button();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvThemuon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngaytra);
            this.groupBox1.Controls.Add(this.ngaymuon);
            this.groupBox1.Controls.Add(this.hienthilai);
            this.groupBox1.Controls.Add(this.TBmasach);
            this.groupBox1.Controls.Add(this.TBsoluong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBmasv);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.TBsothe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(717, 234);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Thẻ Mượn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ngaytra
            // 
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaytra.Location = new System.Drawing.Point(515, 52);
            this.ngaytra.Margin = new System.Windows.Forms.Padding(4);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(197, 22);
            this.ngaytra.TabIndex = 18;
            // 
            // ngaymuon
            // 
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaymuon.Location = new System.Drawing.Point(124, 121);
            this.ngaymuon.Margin = new System.Windows.Forms.Padding(4);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(197, 22);
            this.ngaymuon.TabIndex = 17;
            // 
            // hienthilai
            // 
            this.hienthilai.Location = new System.Drawing.Point(8, 198);
            this.hienthilai.Margin = new System.Windows.Forms.Padding(4);
            this.hienthilai.Name = "hienthilai";
            this.hienthilai.Size = new System.Drawing.Size(156, 28);
            this.hienthilai.TabIndex = 16;
            this.hienthilai.Text = "Hiển Thị Tất Cả";
            this.hienthilai.UseVisualStyleBackColor = true;
            this.hienthilai.Click += new System.EventHandler(this.hienthilai_Click);
            // 
            // TBmasach
            // 
            this.TBmasach.BackColor = System.Drawing.Color.Cornsilk;
            this.TBmasach.Location = new System.Drawing.Point(124, 153);
            this.TBmasach.Margin = new System.Windows.Forms.Padding(4);
            this.TBmasach.Multiline = true;
            this.TBmasach.Name = "TBmasach";
            this.TBmasach.Size = new System.Drawing.Size(197, 24);
            this.TBmasach.TabIndex = 15;
            // 
            // TBsoluong
            // 
            this.TBsoluong.BackColor = System.Drawing.Color.Cornsilk;
            this.TBsoluong.Location = new System.Drawing.Point(515, 89);
            this.TBsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.TBsoluong.Name = "TBsoluong";
            this.TBsoluong.Size = new System.Drawing.Size(197, 22);
            this.TBsoluong.TabIndex = 12;
            this.TBsoluong.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số Lượng";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Hẹn Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Mượn";
            // 
            // TBmasv
            // 
            this.TBmasv.BackColor = System.Drawing.Color.Cornsilk;
            this.TBmasv.Location = new System.Drawing.Point(124, 80);
            this.TBmasv.Margin = new System.Windows.Forms.Padding(4);
            this.TBmasv.Name = "TBmasv";
            this.TBmasv.Size = new System.Drawing.Size(197, 22);
            this.TBmasv.TabIndex = 4;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(17, 84);
            this.c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(85, 16);
            this.c.TabIndex = 3;
            this.c.Text = "Mã Sinh Viên";
            // 
            // TBsothe
            // 
            this.TBsothe.BackColor = System.Drawing.Color.Cornsilk;
            this.TBsothe.Location = new System.Drawing.Point(124, 48);
            this.TBsothe.Margin = new System.Windows.Forms.Padding(4);
            this.TBsothe.Name = "TBsothe";
            this.TBsothe.Size = new System.Drawing.Size(197, 22);
            this.TBsothe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Thẻ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntINDS);
            this.groupBox2.Controls.Add(this.btnseach);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(771, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(280, 234);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // bntINDS
            // 
            this.bntINDS.Location = new System.Drawing.Point(47, 153);
            this.bntINDS.Margin = new System.Windows.Forms.Padding(4);
            this.bntINDS.Name = "bntINDS";
            this.bntINDS.Size = new System.Drawing.Size(123, 28);
            this.bntINDS.TabIndex = 21;
            this.bntINDS.Text = "in DS";
            this.bntINDS.UseVisualStyleBackColor = true;
            this.bntINDS.Click += new System.EventHandler(this.bntINDS_Click);
            // 
            // btnseach
            // 
            this.btnseach.Location = new System.Drawing.Point(47, 119);
            this.btnseach.Margin = new System.Windows.Forms.Padding(4);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(123, 26);
            this.btnseach.TabIndex = 20;
            this.btnseach.Text = "tìm kiếm";
            this.btnseach.UseVisualStyleBackColor = true;
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(47, 86);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(123, 26);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(47, 49);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 26);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(47, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 26);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvThemuon
            // 
            this.dtgvThemuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThemuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThemuon.Location = new System.Drawing.Point(16, 270);
            this.dtgvThemuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvThemuon.Name = "dtgvThemuon";
            this.dtgvThemuon.RowHeadersWidth = 51;
            this.dtgvThemuon.Size = new System.Drawing.Size(1033, 294);
            this.dtgvThemuon.TabIndex = 23;
            this.dtgvThemuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThemuon_CellContentClick);
            // 
            // TheMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 582);
            this.Controls.Add(this.dtgvThemuon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TheMuon";
            this.Text = "TheMuon";
            this.Load += new System.EventHandler(this.TheMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hienthilai;
        private System.Windows.Forms.TextBox TBmasach;
        private System.Windows.Forms.TextBox TBsoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBmasv;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox TBsothe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntINDS;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvThemuon;
    }
}