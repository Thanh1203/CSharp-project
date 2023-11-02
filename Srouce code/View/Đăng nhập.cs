using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Srouce_code.DbConnect;
using Srouce_code.View;
using Srouce_code.CommonData;

namespace Srouce_code
{
    public partial class DangNhap : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        public DangNhap()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();
        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from AccountsAdmin where CAST(AdUsername AS nvarchar(max))=@Username and CAST(AdPassword AS nvarchar(max))=@Password";
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue ("@Password", txtPassword.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    AdminInfor.AdminID = reader.GetInt32(reader.GetOrdinal("AdminId"));
                    this.Hide();
                    HomePage homepage = new HomePage();
                    homepage.Show();
                } else
                {
                    MessageBox.Show("Dang nhap that bai!");
                }
            }
        }
    }
}
