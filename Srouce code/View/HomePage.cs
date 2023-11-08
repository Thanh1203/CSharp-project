using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Srouce_code.DbConnect;
using Srouce_code.View;
using Srouce_code.CommonData;

namespace Srouce_code.View
{
    public partial class HomePage : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from AdminsInformation where AdminId = @AdminId";
            cmd.Parameters.AddWithValue("@AdminId", AdminInfor.AdminID);
            using (reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    AdminInfor.AdminID = reader.GetInt32(reader.GetOrdinal("AdminId"));
                    lbFullname.Text = reader.GetString(reader.GetOrdinal("AdName"));
                    lbAge.Text = reader.GetInt32(reader.GetOrdinal("AdAge")).ToString();
                    DateTime adDate = reader.GetDateTime(reader.GetOrdinal("AdBirth"));
                    lbBirth.Text = adDate.ToString("dd-MM-yyy");
                    lbAddress.Text = reader.GetString(reader.GetOrdinal("AdAddress"));
                }
            }
        }

        private void Btn_goInformationProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            ThongTinSanPham ttsp = new ThongTinSanPham();
            ttsp.Show();

        }

        private void Btn_Receipt_Click(object sender, EventArgs e)
        {
            this.Close();
            NhapHang nhapHang = new NhapHang();
            nhapHang.Show();
        }

        private void Btn_Release_Click(object sender, EventArgs e)
        {
            this.Close();
            XuatHang xuatHang = new XuatHang();
            xuatHang.Show();
        }

        private void Btn_Customer__Information_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.Show();
        }

        private void Btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            AdminInfor.AdminID = 0;
        }

        private void Btn_QuanLyKhoHang_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyKho quanLyKho = new QuanLyKho();
            quanLyKho.Show();
        }

        private void Btn_QuanlyDoanhThu_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyDoanhThu quanlydoanhthu = new QuanLyDoanhThu();
            quanlydoanhthu.Show();
        }

        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
    }
}
