
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLfinal
{
    public partial class DangNhap : Form
    {

        string connectionString = @"Data Source=LAPTOP-OF6TKNB9\SQLEXPRESS;Initial Catalog=Baitaplon;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        /*public string TenDN()
        {
            string s = txtUserName.Text;
            return s;
        }*/

        int i = 0;//Đăng nhập sai 3 lần thì khóa không cho đăng nhập nữa . 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtUserName.Text;
            string mk = txtPassWord.Text;
            bool kt = false;
            //int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "proc_DangNhap";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taikhoan", tk);
                    command.Parameters.AddWithValue("@matkhau", mk);
                    connection.Open();
                    SqlDataReader data = command.ExecuteReader();

                    if (data.Read() == true)
                    {
                        this.Hide();
                        Menu home = new Menu();
                        home.ShowDialog();
                        kt = true;
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại !!");
                        txtUserName.Text = "";
                        txtPassWord.Text = "";
                        txtUserName.Focus();
                        /*i++;
                            if (i >= 3)
                            {
                                btnDangNhap.Enabled = false;
                                MessageBox.Show("Bạn đã bị khóa vì đăng nhập quá 3 lần ");
                            }*/
                    }
                    connection.Close();
                }
            }
            if (kt == true)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy dk = new DangKy();
            dk.ShowDialog();

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
                errDN.SetError(txtUserName, "Tên Tài Khoản không được để trống");
            }
            else if (checkTK(tentk) == false)
            {
                e.Cancel = true;
                txtUserName.Focus();
                errDN.SetError(txtUserName, "không chứa ký tự đặc biệt, đủ độ dài 4 đến 24 ký tự   ");
            }
            else
            {
                e.Cancel = false;
                errDN.SetError(txtUserName, null);
            }
        }

        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            string mk = txtPassWord.Text;
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {
                e.Cancel = true;
                txtPassWord.Focus();
                errDN.SetError(txtPassWord, "Không được để trống và mật khẩu chỉ được nhập số ");
            }
            else if (checkMK(mk) == false)
            {
                e.Cancel = true;
                txtUserName.Focus();
                errDN.SetError(txtPassWord, "Chỉ được nhập số , phải  đủ độ dài 6 đến 24 ký tự   ");
            }
            else
            {
                e.Cancel = false;
                errDN.SetError(txtPassWord, null);
            }
        }
    }
}
