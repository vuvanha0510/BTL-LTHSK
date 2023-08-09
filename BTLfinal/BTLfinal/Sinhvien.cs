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
    public partial class Sinhvien : Form
    {
        string str = @"Data Source=LAPTOP-OF6TKNB9\SQLEXPRESS;Initial Catalog=Baitaplon;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Sinhvien()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select*from SinhVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvSV.DataSource = table;
        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dtgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvSV.CurrentRow.Index;
            TBMaSV.Text = dtgvSV.Rows[i].Cells[0].Value.ToString();
            TBTensv.Text = dtgvSV.Rows[i].Cells[1].Value.ToString();
           TBngaysinh.Text = dtgvSV.Rows[i].Cells[2].Value.ToString();
            TBgioitinh.Text = dtgvSV.Rows[i].Cells[3].Value.ToString();
            TBdiachi.Text = dtgvSV.Rows[i].Cells[4].Value.ToString();
        }

        public bool KiemTraThongTin()
        {

            if (TBMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Số Sinh Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBMaSV.Focus();
                return false;
            }
            if (TBTensv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên Sinh Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBTensv.Focus();
                return false;
            }
            if (TBngaysinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Ngày Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBngaysinh.Focus();
                return false;
            }
            if (TBgioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Giới Tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBgioitinh.Focus();
                return false;
            }
            if (TBdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Địa Chỉ cho sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBdiachi.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                try
                {
                    string sqlINSERT = "INSERT INTO SinhVien(MaSV,TenSV,NgaySinh,GioiTinh,DiaChi) VALUES (@MaSV, @TenSV, @NgaySinh, @GioiTinh,@DiaChi)";

                    SqlCommand cmd = new SqlCommand(sqlINSERT, connection);
                    cmd.Parameters.AddWithValue("MaSV",  TBMaSV.Text);
                    cmd.Parameters.AddWithValue("TenSV", TBTensv.Text);
                    cmd.Parameters.AddWithValue("NgaySinh", Convert.ToDateTime(TBngaysinh.Text));
                    cmd.Parameters.AddWithValue("GioiTinh", TBgioitinh.Text);
                    cmd.Parameters.AddWithValue("DiaChi", TBdiachi.Text);
                    cmd.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Đã thêm mới nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btnsua_Click(object sender, EventArgs e)
        {
            if (TBMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBMaSV.Focus();
            }
            else if (KiemTraThongTin())
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update SinhVien set MaSV= N'" + TBMaSV.Text + "',TenSV= N'" + TBTensv.Text + "',NgaySinh= N'" + Convert.ToDateTime(TBngaysinh.Text) + "', GioiTinh= N'" + TBgioitinh.Text + "',DiaChi= N'" + TBdiachi.Text + "' where MaSV='" + TBMaSV.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Đã sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (TBMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBMaSV.Focus();
            }
            else
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "delete from  SinhVien WHERE MaSV= '" + TBMaSV.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Đã xóa học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnInDSSV_Click(object sender, EventArgs e)
        {
            string id = TBTensv.Text;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "slsinhvien";
            //command.CommandText = "select*from SinhVien";
            command.Parameters.Clear();
            //command.Parameters.AddWithValue("@tensinhvien", id);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            BaoCaoDSSV r2 = new BaoCaoDSSV();
            r2.SetDataSource(dt);
            baocaoSV bcsv = new baocaoSV();
            bcsv.crpv2.ReportSource = r2;
            bcsv.ShowDialog();
        }

        private void hienthilai_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SinhVien where MaSV like N'%" + TBMaSV.Text.Trim() + "%'";
            //command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dtgvSV.DataSource = table;
        }
    }
}
