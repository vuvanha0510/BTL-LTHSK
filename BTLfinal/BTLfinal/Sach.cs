using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;            

namespace BTLfinal
{
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
      
        string str= "Data Source=LAPTOP-OF6TKNB9\\SQLEXPRESS;Initial Catalog=Baitaplon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table= new DataTable();
        
        void loaddata()
        {
            command =connection.CreateCommand();
            command.CommandText = "select * from Sach";
            adapter.SelectCommand= command;
            table.Clear();

            adapter.Fill(table);
            dtgvSach.DataSource = table;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
            command = connection.CreateCommand();
            command.CommandText= "insert into SACH values('" +TBoxMs.Text + "','" + TBoxTs.Text + "','" + TBNxb.Text + "','" + TBnamXb.Text + "','" + TBSL.Text + "','" +TBML.Text + "','" + TBTg.Text + "') ";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm Thành Công","Thông Báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra!! "+ex);
            }
            
        }

        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
           
            i = dtgvSach.CurrentRow.Index;
            TBoxMs.Text = dtgvSach.Rows[i].Cells[0].Value.ToString();
            TBoxTs.Text = dtgvSach.Rows[i].Cells[1].Value.ToString();
            TBNxb.Text = dtgvSach.Rows[i].Cells[2].Value.ToString();
            TBnamXb.Text = dtgvSach.Rows[i].Cells[3].Value.ToString();
            TBSL.Text = dtgvSach.Rows[i].Cells[4].Value.ToString();
            TBML.Text = dtgvSach.Rows[i].Cells[5].Value.ToString();
            TBTg.Text = dtgvSach.Rows[i].Cells[6].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from SACH where MaSach='" + TBoxMs.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update SACH set MaSach= N'" + TBoxMs.Text.Trim() + "',TenSach= N'" + TBoxTs.Text + "',NXB= N'" + TBNxb.Text + "', NamXB= N'" + TBnamXb.Text + "',SoLuong= N'" + TBSL.Text + "',MaLoai= N'" + TBML.Text + "',MaTG= N'" + TBTg.Text + "' where MaSach='" + TBoxMs.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void bntINDS_Click(object sender, EventArgs e)
        {
            //string id = TBSL.Text;
            //int sl = Convert.ToInt32(id);
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = "slsachton";
            //command.Parameters.Clear();

            command.CommandText = "Select * from SACH ";
            command.Parameters.Clear();
            //command.Parameters.AddWithValue("@soluong", sl);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            Baocaosoluong r = new Baocaosoluong();
            r.SetDataSource(dt);
            Baocaosach bcs = new Baocaosach();
            bcs.crpv1.ReportSource = r;
            bcs.ShowDialog();
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Sach where TenSach like N'%"+TBoxTs.Text.Trim()+ "%'";           
            //command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvSach.DataSource = table;
            //loaddata();
            //MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
            
        }

        private void hienthilai_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /*private void TBoxTs_TextChanged(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Sach where TenSach like '%"+TBoxTs.Text+ "%'";           
            //command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvSach.DataSource = table;
        }*/

    }

}
