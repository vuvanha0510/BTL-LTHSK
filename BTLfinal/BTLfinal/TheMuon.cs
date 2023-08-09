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
    public partial class TheMuon : Form
    {
        public TheMuon()
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
            command.CommandText = "select * from TheMuon";
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvThemuon.DataSource = table;
        }

        private void TheMuon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into TheMuon values('" + TBsothe.Text + "','" + TBmasv.Text + "','" + Convert.ToDateTime(ngaymuon.Text)+ "','" + TBmasach.Text + "','" + Convert.ToDateTime(ngaytra.Text) + "') ";//,'" + TBsoluong.Text + "'
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void dtgvThemuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dtgvThemuon.CurrentRow.Index;
            TBsothe.Text = dtgvThemuon.Rows[i].Cells[0].Value.ToString();
            TBmasv.Text = dtgvThemuon.Rows[i].Cells[1].Value.ToString();
            ngaymuon.Text = dtgvThemuon.Rows[i].Cells[2].Value.ToString();
            TBmasach.Text = dtgvThemuon.Rows[i].Cells[3].Value.ToString();
            ngaytra.Text = dtgvThemuon.Rows[i].Cells[4].Value.ToString();
            //TBsoluong.Text = dtgvThemuon.Rows[i].Cells[5].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update TheMuon set SoThe= N'" + TBsothe.Text.Trim() + "',MaSV= N'" + TBmasv.Text + "',NgayMuon= N'" + Convert.ToDateTime(ngaymuon.Text) + "', MaSach= N'" + TBmasach.Text + "',NgayHenTra= N'" +Convert.ToDateTime(ngaytra.Text) + "' where SoThe='" + TBsothe.Text + "'";//"',SoLuong= N'" + TBsoluong.Text + 
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from TheMuon where SoThe='" + TBsothe.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnseach_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            command.CommandText = "select * from TheMuon where MaSV like N'%" + TBmasv.Text.Trim() + "%'";
            //command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvThemuon.DataSource = table;
        }

        private void hienthilai_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bntINDS_Click(object sender, EventArgs e)
        {
            string id = TBmasv.Text;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ctphieumuon";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@masv", id);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            BaoCaoTheMuon tm = new BaoCaoTheMuon();
            tm.SetDataSource(dt);
            BaocaoTM bctm = new BaocaoTM();
            bctm.ctvvTM.ReportSource = tm;
            bctm.ShowDialog();
        }
    }
}
