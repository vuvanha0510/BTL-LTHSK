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
    public partial class menuchinh : Form
    {
        public menuchinh()
        {
            InitializeComponent();
        }


        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach f = new Sach();
            Addform(f);
        }

        private void menuchinh_Load(object sender, EventArgs e)
        {

            
        }
        private Form currentFormChild;
        private void Addform(Form f)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = f;
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sinhvien f = new Sinhvien();
            Addform(f);
        }

       

        private void tacgiaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TacGia f = new TacGia();
            Addform(f);
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLoai f = new TheLoai();
            Addform(f);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có Muốn Thoát Không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
        }

        private void thẻMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheMuon f = new TheMuon();
            Addform(f);
        }
    }
}
