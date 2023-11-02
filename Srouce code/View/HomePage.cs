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
            using (SqlDataReader reader = cmd.ExecuteReader())
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
    }
}
