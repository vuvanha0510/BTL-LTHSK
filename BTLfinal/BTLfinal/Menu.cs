using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLfinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void openchildForm( Form childForm)
        {
            if(currentFormChild!= null)
            {
                currentFormChild.Close();
            }
            currentFormChild= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Sach_Click(object sender, EventArgs e)
        {
            openchildForm(new Sach());
            textBox1.Text=Sach.Text;
        }

        private void sinhvien_Click(object sender, EventArgs e)
        {
            openchildForm(new Sinhvien());
            textBox1.Text = sinhvien.Text;
        }

        private void theloai_Click(object sender, EventArgs e)
        {
            openchildForm(new TheLoai());
            textBox1.Text = theloai.Text;
        }

        private void tacgia_Click(object sender, EventArgs e)
        {
            openchildForm(new TacGia());
            textBox1.Text = tacgia.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            textBox1.Text = "Quản Lý Thư Viện";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ret= MessageBox.Show("Bạn có Muốn Thoát Không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
            
        }

        private void themuon_Click(object sender, EventArgs e)
        {
            openchildForm(new TheMuon());
            textBox1.Text = themuon.Text;
        }
    }
}
