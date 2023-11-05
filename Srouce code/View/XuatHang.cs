using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using FontAwesome.Sharp;
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
        private SqlDataReader reader;

        public XuatHang()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(500);
            timer.Elapsed += TimeElapsed;
            timer.AutoReset = false;

            timer2 = new System.Timers.Timer(500);
            timer2.Elapsed += TimeElapsed2;
            timer2.AutoReset = false;

            timer2 = new System.Timers.Timer(500);
            timer2.Elapsed += TimeElapsed3;
            timer2.AutoReset = false;
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            lbAdminId.Text = AdminInfor.AdminID.ToString();
            lb_message.Invoke(new Action(() => lb_message.Text = ""));
            lb_message2.Invoke(new Action(() => lb_message2.Text = ""));
            lb_totalPrice.Invoke(new Action(() => lb_totalPrice.Text = ""));

            Btn_Print_Bill.Enabled = false;

        }

        private void Txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }


        private void txtKhoiLuong_TextChanged(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Start();
        }

        private void BtnXuatHang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaSP.Text) && !string.IsNullOrWhiteSpace(txtKhoiLuong.Text))
            {
                double price = 0;

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvHoadon);
                row.Cells[0].Value = txtMaSP.Text;
                row.Cells[1].Value = double.Parse(txtKhoiLuong.Text);

                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(txtMaSP.Text.Trim()));
                cmd.CommandText = "select ProductPrice from ProductsInfomation where IdProduct = @IdProduct";
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        double value = reader.GetDouble(0) * double.Parse(txtKhoiLuong.Text);
                        row.Cells[2].Value = value.ToString();
                        price += value;
                    }
                }

                lb_totalPrice.Invoke(new Action(() => lb_totalPrice.Text = price.ToString() + ",000 đ"));

                dgvHoadon.Rows.Add(row);
                txtMaSP.Text = "";
                txtKhoiLuong.Text = "";
            } else
            {
                BtnXuatHang.Enabled = false;
            }

        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvHoadon.Rows)
            {
                if (row.Cells["IdProduct"].Value.ToString() != null && row.Cells["IdProduct"].Value.ToString() == txtMaSP.Text)
                {
                    dgvHoadon.Rows.Remove(row);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
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
            } else
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
                        lb_message.Invoke(new Action(() => lb_message.Text = "Khác hàng đã tồn tại"));
                        lb_message.ForeColor = Color.Green;
                        txtTenKH.Invoke(new Action(() => txtTenKH.Text = reader.GetString(reader.GetOrdinal("CustomerName"))));
                        Txt_Address.Invoke(new Action(() => Txt_Address.Text = reader.GetString(reader.GetOrdinal("CustomerAddress"))));
                    }
                    else
                    {
                        lb_message.Invoke(new Action(() => lb_message.Text = "Khách hàng không tồn tại"));
                        lb_message.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lb_message.Invoke(new Action(() => lb_message.Text = ""));
            }
            if (!string.IsNullOrWhiteSpace(Txt_PhoneNumber.Text) && !string.IsNullOrWhiteSpace(txtTenKH.Text) && !string.IsNullOrWhiteSpace(Txt_Address.Text))
            {
                Btn_Print_Bill.Enabled = true;
            }
        }

        private void TimeElapsed2(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaSP.Text) && !string.IsNullOrWhiteSpace(txtKhoiLuong.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(txtMaSP.Text.Trim()));
                cmd.CommandText = "select VolumeOfProduct from ProductsInfomation where IdProduct = @IdProduct";

                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.GetDouble(0) < double.Parse(txtKhoiLuong.Text))
                        {
                            lb_message2.Invoke(new Action(() => lb_message2.Text = "Lượng hàng trong kho không đủ"));
                            lb_message2.ForeColor = Color.Red;
                        } else
                        {
                            lb_message2.Invoke(new Action(() => lb_message2.Text = ""));
                            BtnXuatHang.Enabled = false;
                            Btn_Print_Bill.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                lb_message2.Invoke(new Action(() => lb_message2.Text = ""));
            }
        }

        private void TimeElapsed3(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(txtMaSP.Text.Trim()));
                cmd.CommandText = "select * from ProductsInfomation where IdProduct = @IdProduct";

                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb_message3.Invoke(new Action(() => lb_message3.Text = "Mã sản phẩm hợp lệ"));
                        lb_message3.ForeColor = Color.Green;
                    }
                    else
                    {
                        lb_message3.Invoke(new Action(() => lb_message3.Text = "Mã sản phẩm không tồn tại"));
                        lb_message3.ForeColor = Color.Red;
                        BtnXuatHang.Enabled = false;
                        Btn_Print_Bill.Enabled = false;
                    }
                }
            }
            else
            {
                lb_message3.Invoke(new Action(() => lb_message3.Text = ""));
            }
        }

        private void InsertBill(string idBill)
        {
            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@IdBill", idBill);
            cmd.Parameters.AddWithValue("@IdAdmin", AdminInfor.AdminID);
            cmd.Parameters.AddWithValue("@DayOut", dtp_DayOut.Value);
            cmd.Parameters.AddWithValue("@PnCustomer", Txt_PhoneNumber.Text);
            cmd.Parameters.AddWithValue("@TotalBill", TotalPrice());
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

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@IdBill", idBill);
                    cmd.Parameters.AddWithValue("@IdProduct", idProduct);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@VolumeOfProduct", weight);
                    cmd.CommandText = "INSERT INTO DataBill (IdBill, IdProduct, Weight) VALUES (@IdBill, @IdProduct, @Weight)";
                    cmd.CommandText = "update ProductsInfomation set VolumeOfProduct -= @VolumeOfProduct Where IdProduct = @IdProduct";
                    cmd.ExecuteNonQuery();

                }
            }

        }

        private double TotalPrice()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvHoadon.Rows)
            {
                // Kiểm tra nếu hàng không phải là hàng header và có giá trị trong cột cần tính tổng
                if (!row.IsNewRow && row.Cells[2].Value != null)
                {
                    if (double.TryParse(row.Cells[2].Value.ToString(), out double cellValue))
                    {
                        total += cellValue;
                    }
                }
            }
            return total;
        }

        private void EmtyLabelAndText()
        {
            dgvHoadon.Rows.Clear(); // Xóa tất cả các dòng trong DataGridView
            Txt_PhoneNumber.Text = "";
            txtTenKH.Text = "";
            Txt_Address.Text = "";
            txtMaSP.Text = "";
            txtKhoiLuong.Text = "";
            lb_message.Invoke(new Action(() => lb_message.Text = ""));
            lb_message2.Invoke(new Action(() => lb_message2.Text = ""));
            lb_message3.Invoke(new Action(() => lb_message3.Text = ""));
            lb_totalPrice.Invoke(new Action(() => lb_totalPrice.Text = "0,000 đ"));
        }
    }
}
