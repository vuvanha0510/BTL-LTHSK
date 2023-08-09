using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;


namespace BTLfinal
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (h == DialogResult.OK)
                Application.Exit();

        }

        public bool checkTK(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{4,24}$");
        }

        public bool checkMK(string mk)
        {
            return Regex.IsMatch(mk, "^[0-9]{6,24}$");
        }
       

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            string tentk = txtUserName.Text;
            
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                checkDK.SetError(txtUserName, "Tên Tài Khoản không được để trống");
            }
            else if (checkTK(tentk)==false)
            {
                e.Cancel = true;
                txtUserName.Focus();
                checkDK.SetError(txtUserName, "không chứa ký tự đặc biệt, đủ độ dài 6 đến 24 ký tự   ");
            }
            else
            {
                e.Cancel = false;
                checkDK.SetError(txtUserName, null);
            }           
        }

        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            string mk = txtPassWord.Text;
            if (string.IsNullOrEmpty(txtPassWord.Text) )
            {
                e.Cancel = true;
                txtPassWord.Focus();
                checkDK.SetError(txtPassWord, "Không được để trống và mật khẩu chỉ được nhập số ");
            }
            else if (checkMK(mk) == false)
            {
                e.Cancel = true;
                txtUserName.Focus();
                checkDK.SetError(txtPassWord, "Chỉ được nhập số , phải  đủ độ dài 6 đến 24 ký tự   ");
            }
            else
            {
                e.Cancel = false;
                checkDK.SetError(txtPassWord, null);
            }
        }

        private void txtRePassWord_Validating(object sender, CancelEventArgs e)
        {
            string mk = txtPassWord.Text;
            string rmk = txtRePassWord.Text;
            if (mk != rmk)
            {
                e.Cancel = true;
                txtPassWord.Focus();
                checkDK.SetError(txtRePassWord, "Mật khẩu phải trùng với mật khẩu bạn đã nhập ở trên ");
            }
            else
            {
                e.Cancel = false;
                checkDK.SetError(txtRePassWord, null);
                btnRegister.Enabled = true;
            }
        }

        private bool KT_User()
        {
            bool kt = false;
            string ten = txtUserName.Text;
            string constr = @"Data Source=LAPTOP-OF6TKNB9\SQLEXPRESS;Initial Catalog=Baitaplon;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from TaiKhoan", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (ten == dr.GetString(0))
                {
                    kt = true;
                    break;
                }
            }
            con.Close();
            return kt;
        }

        public void AddUser()
        {
            string constr = @"Data Source=LAPTOP-OF6TKNB9\SQLEXPRESS;Initial Catalog=Baitaplon;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(constr);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            if (KT_User() == false)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_themTK";
                cmd.Parameters.Add("@taikhoan", SqlDbType.NVarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = txtPassWord.Text;
                cnn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    
                    DialogResult h = MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập ngay ?", "Thông báo? ", MessageBoxButtons.OKCancel);
                    if (h == DialogResult.OK)
                    {
                        this.Hide();
                        Menu home = new Menu();
                        home.ShowDialog();
                    }
                }    
                else MessageBox.Show("Đăng ký thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
            }
            else MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }
    }
}
