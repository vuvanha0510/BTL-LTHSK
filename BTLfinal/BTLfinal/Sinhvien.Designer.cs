namespace BTLfinal
{
    partial class Sinhvien
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
            this.Btncancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvSV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btnhuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.BtnInDSSV = new System.Windows.Forms.Button();
            this.Btnsua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TBdiachi = new System.Windows.Forms.TextBox();
            this.TBTensv = new System.Windows.Forms.TextBox();
            this.TBgioitinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hienthilai = new System.Windows.Forms.Button();
            this.BtnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btncancel
            // 
            this.Btncancel.Location = new System.Drawing.Point(437, 450);
            this.Btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btncancel.Name = "Btncancel";
            this.Btncancel.Size = new System.Drawing.Size(100, 28);
            this.Btncancel.TabIndex = 25;
            this.Btncancel.Text = "Thoát";
            this.Btncancel.UseVisualStyleBackColor = true;
            this.Btncancel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSV);
            this.groupBox1.Location = new System.Drawing.Point(93, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(752, 228);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // dtgvSV
            // 
            this.dtgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSV.Location = new System.Drawing.Point(0, 38);
            this.dtgvSV.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvSV.Name = "dtgvSV";
            this.dtgvSV.RowHeadersWidth = 51;
            this.dtgvSV.Size = new System.Drawing.Size(752, 182);
            this.dtgvSV.TabIndex = 0;
            this.dtgvSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSV_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnTim);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.BtnInDSSV);
            this.groupBox3.Controls.Add(this.Btnsua);
            this.groupBox3.Controls.Add(this.BtnXoa);
            this.groupBox3.Location = new System.Drawing.Point(804, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(139, 198);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // Btnhuy
            // 
            this.Btnhuy.Location = new System.Drawing.Point(812, 473);
            this.Btnhuy.Margin = new System.Windows.Forms.Padding(4);
            this.Btnhuy.Name = "Btnhuy";
            this.Btnhuy.Size = new System.Drawing.Size(100, 28);
            this.Btnhuy.TabIndex = 19;
            this.Btnhuy.Text = "Hủy";
            this.Btnhuy.UseVisualStyleBackColor = true;
            this.Btnhuy.Visible = false;
            this.Btnhuy.Click += new System.EventHandler(this.Btnhuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // BtnInDSSV
            // 
            this.BtnInDSSV.Location = new System.Drawing.Point(8, 160);
            this.BtnInDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInDSSV.Name = "BtnInDSSV";
            this.BtnInDSSV.Size = new System.Drawing.Size(100, 28);
            this.BtnInDSSV.TabIndex = 18;
            this.BtnInDSSV.Text = "In Danh Sách";
            this.BtnInDSSV.UseVisualStyleBackColor = true;
            this.BtnInDSSV.Click += new System.EventHandler(this.BtnInDSSV_Click);
            // 
            // Btnsua
            // 
            this.Btnsua.Location = new System.Drawing.Point(8, 55);
            this.Btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.Btnsua.Name = "Btnsua";
            this.Btnsua.Size = new System.Drawing.Size(100, 28);
            this.Btnsua.TabIndex = 16;
            this.Btnsua.Text = "Sửa";
            this.Btnsua.UseVisualStyleBackColor = true;
            this.Btnsua.Click += new System.EventHandler(this.Btnsua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(8, 89);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(100, 28);
            this.BtnXoa.TabIndex = 17;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TBMaSV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TBngaysinh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TBdiachi);
            this.groupBox2.Controls.Add(this.TBTensv);
            this.groupBox2.Controls.Add(this.TBgioitinh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(93, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(688, 153);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // TBMaSV
            // 
            this.TBMaSV.BackColor = System.Drawing.Color.Cornsilk;
            this.TBMaSV.Location = new System.Drawing.Point(164, 39);
            this.TBMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.TBMaSV.Name = "TBMaSV";
            this.TBMaSV.Size = new System.Drawing.Size(132, 22);
            this.TBMaSV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // TBngaysinh
            // 
            this.TBngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TBngaysinh.Location = new System.Drawing.Point(164, 113);
            this.TBngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.TBngaysinh.Name = "TBngaysinh";
            this.TBngaysinh.Size = new System.Drawing.Size(265, 22);
            this.TBngaysinh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // TBdiachi
            // 
            this.TBdiachi.BackColor = System.Drawing.Color.Cornsilk;
            this.TBdiachi.Location = new System.Drawing.Point(457, 76);
            this.TBdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.TBdiachi.Name = "TBdiachi";
            this.TBdiachi.Size = new System.Drawing.Size(132, 22);
            this.TBdiachi.TabIndex = 11;
            // 
            // TBTensv
            // 
            this.TBTensv.BackColor = System.Drawing.Color.Cornsilk;
            this.TBTensv.Location = new System.Drawing.Point(164, 71);
            this.TBTensv.Margin = new System.Windows.Forms.Padding(4);
            this.TBTensv.Name = "TBTensv";
            this.TBTensv.Size = new System.Drawing.Size(132, 22);
            this.TBTensv.TabIndex = 7;
            // 
            // TBgioitinh
            // 
            this.TBgioitinh.BackColor = System.Drawing.Color.Cornsilk;
            this.TBgioitinh.Location = new System.Drawing.Point(457, 39);
            this.TBgioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.TBgioitinh.Name = "TBgioitinh";
            this.TBgioitinh.Size = new System.Drawing.Size(132, 22);
            this.TBgioitinh.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(305, 427);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 52);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tùy chọn";
            this.groupBox4.Visible = false;
            // 
            // hienthilai
            // 
            this.hienthilai.Location = new System.Drawing.Point(895, 70);
            this.hienthilai.Margin = new System.Windows.Forms.Padding(4);
            this.hienthilai.Name = "hienthilai";
            this.hienthilai.Size = new System.Drawing.Size(156, 28);
            this.hienthilai.TabIndex = 29;
            this.hienthilai.Text = "Hiển Thị Tất Cả";
            this.hienthilai.UseVisualStyleBackColor = true;
            this.hienthilai.Click += new System.EventHandler(this.hienthilai_Click);
            // 
            // BtnTim
            // 
            this.BtnTim.Location = new System.Drawing.Point(8, 125);
            this.BtnTim.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTim.Name = "BtnTim";
            this.BtnTim.Size = new System.Drawing.Size(100, 28);
            this.BtnTim.TabIndex = 19;
            this.BtnTim.Text = "Tìm Kiếm";
            this.BtnTim.UseVisualStyleBackColor = true;
            this.BtnTim.Click += new System.EventHandler(this.BtnTim_Click);
            // 
            // Sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Btnhuy);
            this.Controls.Add(this.hienthilai);
            this.Controls.Add(this.Btncancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sinhvien";
            this.Text = "Sinhvien";
            this.Load += new System.EventHandler(this.Sinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btncancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvSV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btnhuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button BtnInDSSV;
        private System.Windows.Forms.Button Btnsua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TBngaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBdiachi;
        private System.Windows.Forms.TextBox TBTensv;
        private System.Windows.Forms.TextBox TBgioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button hienthilai;
        private System.Windows.Forms.Button BtnTim;
    }
}