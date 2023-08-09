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
    public partial class TacGia : Form
    {
        public TacGia()
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
            command.CommandText = "select * from TacGia";
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvTacgia.DataSource = table;
            btnThem.Enabled = true;
        }

        private void TacGia_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //neu khong co o nao check thi nut them  bi vo hieu
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) 
            {
                btnThem.Enabled=true;
                check();
                command = connection.CreateCommand();
                command.CommandText = "insert into TacGia values('" + TBoxMtg.Text + "','" + TBoxTtg.Text + "','" + TBdiachi.Text + "','" + label2.Text +"') ";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);

            }
            else
            {
                btnThem.Enabled = false;
                MessageBox.Show("Phai chon 1 lua chon o ghi chu");
                loaddata();
            }
            
        }
        //kiem tra o duoc check
        private void check()
        {
            if (checkBox1.Checked)
            {
                label2.Text = checkBox1.Text;
                
            }
            if (checkBox2.Checked)
            {
                label2.Text= checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                label2.Text = checkBox3.Text;
            }
            if (checkBox3.Checked&&checkBox2.Checked)
            {
                label2.Text = checkBox3.Text+";"+checkBox2.Text;
            }
            if (checkBox3.Checked && checkBox1.Checked)
            {
                label2.Text = checkBox3.Text + ";" + checkBox1.Text;
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                label2.Text = checkBox1.Text + ";" + checkBox2.Text;
            }
            if(checkBox1.Checked&& checkBox2.Checked&&checkBox3.Checked)
            {
                label2.Text = checkBox1.Text + ";" + checkBox2.Text + ";" + checkBox3.Text;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update TacGia set MaTG= N'" + TBoxMtg.Text.Trim() + "',TenTG= N'" + TBoxTtg.Text + "',DiaChi= N'" + TBdiachi.Text + "' where MaTG='" + TBoxMtg.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from TacGia where MaTG='" + TBoxMtg.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void dtgvTacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dtgvTacgia.CurrentRow.Index;
            TBoxMtg.Text = dtgvTacgia.Rows[i].Cells[0].Value.ToString();
            TBoxTtg.Text = dtgvTacgia.Rows[i].Cells[1].Value.ToString();
            TBdiachi.Text = dtgvTacgia.Rows[i].Cells[2].Value.ToString();
            
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TacGia where TenTG like N'%" + TBoxTtg.Text.Trim() + "%'";
            //command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvTacgia.DataSource = table;
        }

        private void bntINDtg_Click(object sender, EventArgs e)
        {
           
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "select * from TacGia";
            command.Parameters.Clear();
            //command.Parameters.AddWithValue("@soluong", sl);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            BaoCaoTacGia tg = new BaoCaoTacGia();
            tg.SetDataSource(dt);
            baocaoTG bctg = new baocaoTG();
            bctg.ctvvTg.ReportSource = tg;
            bctg.ShowDialog();
        }

        private void hienthilai_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
