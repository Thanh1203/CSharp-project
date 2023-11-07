using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Srouce_code.DbConnect;
using System.Data;
using Srouce_code.CommonData;
using System.Timers;
using System.Drawing;
using System.Windows.Documents;
using System.Net;

namespace Srouce_code.View
{
    public partial class NhapHang : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private readonly SqlDataAdapter adapter = new SqlDataAdapter();
        private readonly DataTable table = new DataTable();
        private readonly System.Timers.Timer timer;
        private SqlDataReader reader;
        public NhapHang()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(500);
            timer.Elapsed += TimeElapsed;
            timer.AutoReset = false;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            lbAdminid.Text = AdminInfor.AdminID.ToString();
            lb_message.Invoke(new Action(() => lb_message.Text = ""));
            EmtyLabel();

            ColumnRecipt();

            LoadData();
        }
        private void Txt_MaSp_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void Btn_Insert_Receipt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_IdProduct.Text) && !string.IsNullOrWhiteSpace(Txt_Volume.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_IdProduct.Text.Trim()));
                cmd.Parameters.AddWithValue("@VolumeOfProduct", float.Parse(Txt_Volume.Text.Trim()));
                cmd.CommandText = "update ProductsInfomation set VolumeOfProduct += @VolumeOfProduct Where IdProduct = @IdProduct";
                cmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue("@AdminId", int.Parse(lbAdminid.Text));
                cmd.Parameters.AddWithValue("@DayIn", dateTimeNgayNhap.Value);
                cmd.CommandText = "insert into Receipt (Adminid, IdProduct, VolumeOfProduct, DayIn) values (@AdminId, @IdProduct, @VolumeOfProduct, @DayIn)";
                cmd.ExecuteNonQuery();

                EmtyLabel();
                LoadData();
            } else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }

        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            Txt_IdProduct.Text = "";
            Txt_Volume.Text = "";
            EmtyLabel();
            LoadData();
        }

        private void Btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Receipt";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Receipt_List.DataSource = table;
        }

        private void TimeElapsed(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_IdProduct.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_IdProduct.Text.Trim()));
                cmd.CommandText = "select * from ProductsInfomation where IdProduct = @IdProduct";

                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb_message.Invoke(new Action(() => lb_message.Text = "Mã sản phẩm hợp lệ"));
                        lb_message.ForeColor = Color.Green;

                        label11.Invoke(new Action(() => label11.Text = reader.GetString(reader.GetOrdinal("NameProduct"))));
                        label12.Invoke(new Action(() => label12.Text = reader.GetString(reader.GetOrdinal("KindOfProduct"))));
                        label13.Invoke(new Action(() => label13.Text = reader.GetString(reader.GetOrdinal("ColorOfProduct"))));
                        label14.Invoke(new Action(() => label14.Text = reader.GetDouble(reader.GetOrdinal("VolumeOfProduct")).ToString()));
                    }
                    else
                    {
                        lb_message.Invoke(new Action(() => lb_message.Text = "Mã sản phẩm không tồn tại"));
                        lb_message.ForeColor = Color.Red;

                        EmtyLabel();
                    }
                }
            }
            else
            {
                lb_message.Invoke(new Action(() => lb_message.Text = ""));

                EmtyLabel();
            }
        }

        public void EmtyLabel()
        {
            label11.Invoke(new Action(() => label11.Text = ""));
            label12.Invoke(new Action(() => label12.Text = ""));
            label13.Invoke(new Action(() => label13.Text = ""));
            label14.Invoke(new Action(() => label14.Text = ""));
        }

        public void ColumnRecipt()
        {
            DataGridViewTextBoxColumn idReceiptColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã phiếu nhập",
                DataPropertyName = "IdReceipt",
            };
            DGV_Receipt_List.Columns.Add(idReceiptColumn);

            DataGridViewTextBoxColumn adminIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã nhân viên",
                DataPropertyName = "AdminId",
            };
            DGV_Receipt_List.Columns.Add(adminIdColumn);

            DataGridViewTextBoxColumn idProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã sản phẩm",
                DataPropertyName = "IdProduct",
            };
            DGV_Receipt_List.Columns.Add(idProductColumn);

            DataGridViewTextBoxColumn volumeOfProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Khối lượng",
                DataPropertyName = "VolumeOfProduct",
            };
            DGV_Receipt_List.Columns.Add(volumeOfProductColumn);

            DataGridViewTextBoxColumn dayInColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày nhập",
                DataPropertyName = "DayIn",
            };
            DGV_Receipt_List.Columns.Add(dayInColumn);
        }

        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }
    }
}
