using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Srouce_code.CommonData;
using Srouce_code.DbConnect;

namespace Srouce_code.View
{
    public partial class XuatHang : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private readonly System.Timers.Timer timer;
        private readonly System.Timers.Timer timer2;
        private readonly System.Timers.Timer timer3;
        private SqlDataReader reader;
        public double TotalPrice = 0;

        public XuatHang()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(500);
            timer.Elapsed += TimeElapsed;
            timer.AutoReset = false;

            timer2 = new System.Timers.Timer(500);
            timer2.Elapsed += TimeElapsed2;
            timer2.AutoReset = false;

            timer3 = new System.Timers.Timer(500);
            timer3.Elapsed += TimeElapsed3;
            timer3.AutoReset = false;
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            lbAdminId.Text = AdminInfor.AdminID.ToString();
            lb_messageCustomer.Invoke(new Action(() => lb_messageCustomer.Text = ""));
            lb_messageWeightProduct.Invoke(new Action(() => lb_messageWeightProduct.Text = ""));
            lb_messageIdProduct.Invoke(new Action(() => lb_messageIdProduct.Text = ""));

            lb_totalPrice.Invoke(new Action(() => lb_totalPrice.Text = ""));
        }

        private void Txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void TxtKhoiLuong_TextChanged(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Start();
        }

        private void Txt_MaSP_TextChanged(object sender, EventArgs e)
        {
            timer3.Stop();
            timer3.Start();
        }

        private void BtnXuatHang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_MaSP.Text) && !string.IsNullOrWhiteSpace(TxtKhoiLuong.Text))
            {
                double value = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvHoadon);

                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_MaSP.Text.Trim()));
                cmd.Parameters.AddWithValue("@setWeight", double.Parse(TxtKhoiLuong.Text));
                cmd.CommandText = "DECLARE @myWeight FLOAT; SET @myWeight = @setWeight; select TypeProduct, IdProduct, @myWeight as MyWeight, @myWeight * PriceProduct AS totalValue from ProductInfor where IdProduct = @IdProduct";
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        row.Cells[0].Value = reader.GetString(reader.GetOrdinal("TypeProduct"));
                        row.Cells[1].Value = reader.GetInt32(reader.GetOrdinal("IdProduct"));
                        row.Cells[2].Value = reader.GetDouble(reader.GetOrdinal("MyWeight"));
                        row.Cells[3].Value = reader.GetDouble(reader.GetOrdinal("totalValue"));
                        value = reader.GetDouble(reader.GetOrdinal("totalValue"));
                    }
                }
                TotalPrice += value;
                dgvHoadon.Rows.Add(row);
                lb_totalPrice.Invoke(new Action(() => lb_totalPrice.Text = TotalPrice.ToString() + ",000 đ"));
                Txt_MaSP.Text = "";
                TxtKhoiLuong.Text = "";
            }
            else
            {
                BtnXuatHang.Enabled = false;
            }

        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHoadon.Rows)
            {
                if (row.Cells["IdProduct"].Value.ToString() != null && row.Cells["IdProduct"].Value.ToString() == Txt_MaSP.Text)
                {
                    dgvHoadon.Rows.Remove(row);
                }
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            EmtyLabelAndText();
        }

        private void Btn_Print_Bill_Click(object sender, EventArgs e)
        {
            if (dgvHoadon.RowCount - 1 != 0)
            {
                DateTime now = DateTime.Now;
                string idBill = now.ToString("yyyyMMddHHmmss") + AdminInfor.AdminID.ToString();
                InsertBill(idBill);
                InsertDataBill(idBill);
                MessageBox.Show("Xuất hóa đơn thành công");
                EmtyLabelAndText();
            }
            else
            {
                MessageBox.Show("Khong có");
            }
        }

        private void Btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void TimeElapsed(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_PhoneNumber.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@CustomerPhoneNumber", Txt_PhoneNumber.Text.Trim());
                cmd.CommandText = "select * from CustomerInformation where CustomerPhoneNumber = @CustomerPhoneNumber";

                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb_messageCustomer.Invoke(new Action(() => lb_messageCustomer.Text = "Khác hàng đã tồn tại"));
                        lb_messageCustomer.ForeColor = Color.Green;
                        txtTenKH.Invoke(new Action(() => txtTenKH.Text = reader.GetString(reader.GetOrdinal("CustomerName"))));
                        Txt_Address.Invoke(new Action(() => Txt_Address.Text = reader.GetString(reader.GetOrdinal("CustomerAddress"))));
                    }
                    else
                    {
                        lb_messageCustomer.Invoke(new Action(() => lb_messageCustomer.Text = "Khách hàng không tồn tại"));
                        lb_messageCustomer.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lb_messageCustomer.Invoke(new Action(() => lb_messageCustomer.Text = ""));
            }

        }

        private void TimeElapsed2(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_MaSP.Text) && !string.IsNullOrWhiteSpace(TxtKhoiLuong.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_MaSP.Text.Trim()));
                cmd.CommandText = "select WeightProduct from ProductInfor where IdProduct = @IdProduct";

                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.GetDouble(0) < double.Parse(TxtKhoiLuong.Text))
                        {
                            lb_messageWeightProduct.Invoke(new Action(() => lb_messageWeightProduct.Text = "Lượng hàng trong kho không đủ"));
                            lb_messageWeightProduct.ForeColor = Color.Red;
                        }
                        else
                        {
                            lb_messageWeightProduct.Invoke(new Action(() => lb_messageWeightProduct.Text = ""));
                        }
                    }
                }
            }
            else
            {
                lb_messageWeightProduct.Invoke(new Action(() => lb_messageWeightProduct.Text = ""));
            }
        }

        private void TimeElapsed3(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_MaSP.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_MaSP.Text.Trim()));
                cmd.CommandText = "select * from ProductInfor where IdProduct = @IdProduct";

                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb_messageIdProduct.Invoke(new Action(() => lb_messageIdProduct.Text = "Mã sản phẩm hợp lệ"));
                        lb_messageIdProduct.ForeColor = Color.Green;
                    }
                    else
                    {
                        lb_messageIdProduct.Invoke(new Action(() => lb_messageIdProduct.Text = "Mã sản phẩm không tồn tại"));
                        lb_messageIdProduct.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lb_messageIdProduct.Invoke(new Action(() => lb_messageIdProduct.Text = ""));
            }
        }

        private void InsertBill(string idBill)
        {
            cmd = conn.CreateCommand();

            if (lb_messageCustomer.Text == "Khách hàng không tồn tại")
            {
                cmd.Parameters.AddWithValue("@CustomerPhoneNumber", Txt_PhoneNumber.Text);
                cmd.Parameters.AddWithValue("@CustomerName", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@CustomerAddress", Txt_Address.Text);
                cmd.CommandText = "insert into CustomerInformation (CustomerPhoneNumber, CustomerName, CustomerAddress, CustomerPurchases) values (@CustomerPhoneNumber, @CustomerName, @CustomerAddress, 1)";
                cmd.ExecuteNonQuery();
            }

            cmd.Parameters.AddWithValue("@IdBill", idBill);
            cmd.Parameters.AddWithValue("@IdAdmin", AdminInfor.AdminID);
            cmd.Parameters.AddWithValue("@DayOut", dtp_DayOut.Value);
            cmd.Parameters.AddWithValue("@PnCustomer", Txt_PhoneNumber.Text);
            cmd.Parameters.AddWithValue("@TotalBill", TotalPrice);
            cmd.CommandText = "insert into BillInformation ( IdBill, IdAdmin, DayOut, PnCustomer, TotalBill) values (@IdBill, @IdAdmin, @DayOut, @PnCustomer, @TotalBill)";
            cmd.ExecuteNonQuery();
        }

        private void InsertDataBill(string idBill)
        {
            foreach (DataGridViewRow row in dgvHoadon.Rows)
            {
                if (row.IsNewRow) continue;

                int idProduct = int.Parse(row.Cells["IdProduct"].Value.ToString());
                double weight = double.Parse(row.Cells["WeightProduct"].Value.ToString());
                string typeProduct = row.Cells["TypeProduct"].Value.ToString();
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdBill", idBill);
                cmd.Parameters.AddWithValue("@IdProduct", idProduct);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@WeightProduct", weight);
                cmd.Parameters.AddWithValue("@IdTypeProduct", typeProduct);
                cmd.CommandText = "INSERT INTO DataBill ( IdTypeProduct, IdBill, IdProduct, Weight) VALUES (@IdTypeProduct, @IdBill, @IdProduct, @Weight)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update ProductInfor set WeightProduct -= @WeightProduct Where IdProduct = @IdProduct";
                cmd.ExecuteNonQuery();

                if(lb_messageCustomer.Text != "Khách hàng không tồn tại")
                {
                    cmd.Parameters.AddWithValue("@CustomerPhoneNumber", Txt_PhoneNumber.Text);
                    cmd.CommandText = "update CustomerInformation set CustomerPurchases += 1 where CustomerPhoneNumber = @CustomerPhoneNumber";
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void EmtyLabelAndText()
        {
            dgvHoadon.Rows.Clear(); // Xóa tất cả các dòng trong DataGridView
            Txt_PhoneNumber.Text = "";
            txtTenKH.Text = "";
            Txt_Address.Text = "";
            Txt_MaSP.Text = "";
            TxtKhoiLuong.Text = "";
            lb_messageCustomer.Invoke(new Action(() => lb_messageCustomer.Text = ""));
            lb_messageWeightProduct.Invoke(new Action(() => lb_messageWeightProduct.Text = ""));
            lb_messageIdProduct.Invoke(new Action(() => lb_messageIdProduct.Text = ""));
            lb_totalPrice.Invoke(new Action(() => lb_totalPrice.Text = "0,000 đ"));
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
