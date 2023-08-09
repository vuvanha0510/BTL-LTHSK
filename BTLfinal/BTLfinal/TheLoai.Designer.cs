namespace BTLfinal
{
    partial class TheLoai
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
            this.hienthilai = new System.Windows.Forms.Button();
            this.TBoxTtl = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.TBoxMtl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chucnang = new System.Windows.Forms.GroupBox();
            this.bntINDtg = new System.Windows.Forms.Button();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvTheloai = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hienthilai);
            this.groupBox1.Controls.Add(this.TBoxTtl);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.TBoxMtl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(596, 234);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Thể Loại";
            // 
            // hienthilai
            // 
            this.hienthilai.Location = new System.Drawing.Point(24, 198);
            this.hienthilai.Margin = new System.Windows.Forms.Padding(4);
            this.hienthilai.Name = "hienthilai";
            this.hienthilai.Size = new System.Drawing.Size(156, 28);
            this.hienthilai.TabIndex = 17;
            this.hienthilai.Text = "Hiển Thị Tất Cả";
            this.hienthilai.UseVisualStyleBackColor = true;
            this.hienthilai.Click += new System.EventHandler(this.hienthilai_Click);
            // 
            // TBoxTtl
            // 
            this.TBoxTtl.BackColor = System.Drawing.Color.Cornsilk;
            this.TBoxTtl.Location = new System.Drawing.Point(124, 80);
            this.TBoxTtl.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxTtl.Name = "TBoxTtl";
            this.TBoxTtl.Size = new System.Drawing.Size(197, 22);
            this.TBoxTtl.TabIndex = 4;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(39, 89);
            this.c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(87, 16);
            this.c.TabIndex = 3;
            this.c.Text = "Tên Thể Loại";
            // 
            // TBoxMtl
            // 
            this.TBoxMtl.BackColor = System.Drawing.Color.Cornsilk;
            this.TBoxMtl.Location = new System.Drawing.Point(124, 48);
            this.TBoxMtl.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxMtl.Name = "TBoxMtl";
            this.TBoxMtl.Size = new System.Drawing.Size(197, 22);
            this.TBoxMtl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Thể Loại";
            // 
            // Chucnang
            // 
            this.Chucnang.Controls.Add(this.bntINDtg);
            this.Chucnang.Controls.Add(this.btnseach);
            this.Chucnang.Controls.Add(this.btnxoa);
            this.Chucnang.Controls.Add(this.btnsua);
            this.Chucnang.Controls.Add(this.btnThem);
            this.Chucnang.Location = new System.Drawing.Point(688, 26);
            this.Chucnang.Margin = new System.Windows.Forms.Padding(4);
            this.Chucnang.Name = "Chucnang";
            this.Chucnang.Padding = new System.Windows.Forms.Padding(4);
            this.Chucnang.Size = new System.Drawing.Size(280, 234);
            this.Chucnang.TabIndex = 24;
            this.Chucnang.TabStop = false;
            this.Chucnang.Text = "Chức Năng";
            // 
            // bntINDtg
            // 
            this.bntINDtg.Location = new System.Drawing.Point(47, 153);
            this.bntINDtg.Margin = new System.Windows.Forms.Padding(4);
            this.bntINDtg.Name = "bntINDtg";
            this.bntINDtg.Size = new System.Drawing.Size(123, 28);
            this.bntINDtg.TabIndex = 21;
            this.bntINDtg.Text = "in DS";
            this.bntINDtg.UseVisualStyleBackColor = true;
            this.bntINDtg.Click += new System.EventHandler(this.bntINDtg_Click);
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
            // dtgvTheloai
            // 
            this.dtgvTheloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTheloai.Location = new System.Drawing.Point(24, 267);
            this.dtgvTheloai.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTheloai.Name = "dtgvTheloai";
            this.dtgvTheloai.RowHeadersWidth = 51;
            this.dtgvTheloai.Size = new System.Drawing.Size(596, 272);
            this.dtgvTheloai.TabIndex = 25;
            this.dtgvTheloai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTheloai_CellContentClick);
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgvTheloai);
            this.Controls.Add(this.Chucnang);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TheLoai";
            this.Text = "TheLoai";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Chucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheloai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBoxTtl;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox TBoxMtl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Chucnang;
        private System.Windows.Forms.Button bntINDtg;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvTheloai;
        private System.Windows.Forms.Button hienthilai;
    }
}