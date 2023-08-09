using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLfinal
{
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;

        string str = @"Data Source=LAPTOP-OF6TKNB9\SQLEXPRESS;Initial Catalog=Baitaplon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TheLoaiSach";
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvTheloai.DataSource = table;
        }
        private void dtgvTheloai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dtgvTheloai.CurrentRow.Index;
            TBoxMtl.Text = dtgvTheloai.Rows[i].Cells[0].Value.ToString();
            TBoxTtl.Text = dtgvTheloai.Rows[i].Cells[1].Value.ToString();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into TheLoaiSach values('" + TBoxMtl.Text + "','" + TBoxTtl.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update TheLoaiSach set MaLoai= N'" + TBoxMtl.Text.Trim() + "',TenTheLoai= N'" + TBoxTtl.Text +  "' where MaLoai='" + TBoxMtl.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from TheLoaiSach where MaLoai='" + TBoxMtl.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TheLoaiSach where TenTheLoai like N'%" + TBoxTtl.Text.Trim() + "%'";
            //command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvTheloai.DataSource = table;
        }

        private void bntINDtg_Click(object sender, EventArgs e)
        {
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "select * from TheLoaiSach";
            command.Parameters.Clear();
            //command.Parameters.AddWithValue("@soluong", sl);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            BaocaoTheLoai tl= new BaocaoTheLoai();
            tl.SetDataSource(dt);
            baocaoTL bctl = new baocaoTL();
            bctl.ctvvTL.ReportSource = tl;
            bctl.ShowDialog();
        }

        private void hienthilai_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
