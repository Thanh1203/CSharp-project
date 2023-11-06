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
    public partial class QuanLyKhachHang : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private readonly DataTable table = new DataTable();
        private readonly System.Timers.Timer timer;
        private readonly System.Timers.Timer timer2;
        private SqlDataReader reader;

        public QuanLyKhachHang()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(500);
            timer.Elapsed += TimeElapsed;
            timer.AutoReset = false;

        }

        private void QuanLyKhachHang_Load_1(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            lb_message.Text = "";

            ColumnCustomer();
            LoadData();
        }

        private void MenuUpdateCustomer_Click(object sender, EventArgs e)
        {
            Btn_DeleteCustomer.Visible = false;
            Btn_DeleteCustomer.Enabled = false;
            Btn_Update.Visible = true;
            Btn_Update.Enabled = true;
        }

        private void MenuDeleteCustomer_Click(object sender, EventArgs e)
        {
            Btn_Update.Visible = false;
            Btn_Update.Enabled = false;
            Btn_DeleteCustomer.Visible = true;
            Btn_DeleteCustomer.Enabled = true;
        }

        private void Txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_PhoneNumber.Text))
            {
                using (cmd = new SqlCommand("UpdateCustomer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerPhoneNumber", Txt_PhoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@CustomerName", Txt_CustomerName.Text);
                    cmd.Parameters.AddWithValue("@CustomerAddress", Txt_CustomerAddress.Text);
                    using (reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Cập nhật thất bại hãy nhập đầy đủ số điện thoại");
                        }
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền mã sản phẩm");
            }
        }

        private void Btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@CustomerPhoneNumber", Txt_PhoneNumber.Text.Trim());
            cmd.CommandText = "delete from CustomerInformation where CustomerPhoneNumber = @CustomerPhoneNumber";
            using (reader = cmd.ExecuteReader())
            {
                if (!reader.Read())
                {
                    MessageBox.Show("Xóa thất bại hãy nhập đầy đủ số điện thoại");
                }
            }

            ResetData();
        }

        private void Btn_ResetData_Click(object sender, EventArgs e)
        {
            ResetData();
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
            cmd.CommandText = "select * from CustomerInformation";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            Dgv_CustomerInformation.Invoke(new Action(() => Dgv_CustomerInformation.DataSource = table));
        }

        private void ColumnCustomer()
        {
            DataGridViewTextBoxColumn PNCustomer = new DataGridViewTextBoxColumn
            {
                HeaderText = "Số điện thoại",
                DataPropertyName = "CustomerPhoneNumber",
            };
            Dgv_CustomerInformation.Columns.Add(PNCustomer);
            DataGridViewTextBoxColumn CustomerName = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên khách hàng",
                DataPropertyName = "CustomerName",
            };
            Dgv_CustomerInformation.Columns.Add(CustomerName);
            DataGridViewTextBoxColumn CustomerAddress = new DataGridViewTextBoxColumn
            {
                HeaderText = "Địa chỉ",
                DataPropertyName = "CustomerAddress",
            };
            Dgv_CustomerInformation.Columns.Add(CustomerAddress);
            DataGridViewTextBoxColumn CustomerPurchases = new DataGridViewTextBoxColumn
            {
                HeaderText = "Số lần mua hàng",
                DataPropertyName = "CustomerPurchases",
            };
            Dgv_CustomerInformation.Columns.Add(CustomerPurchases);
        }

        private void TimeElapsed(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_PhoneNumber.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@CustomerPhoneNumber",Txt_PhoneNumber.Text.Trim() + "%");
                cmd.CommandText = "select * from CustomerInformation where CustomerPhoneNumber like @CustomerPhoneNumber";

                using (adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        Dgv_CustomerInformation.Invoke(new Action(() => Dgv_CustomerInformation.DataSource = table));
                        lb_message.Invoke(new Action(() => lb_message.Text = ""));
                    }
                    else
                    {
                        lb_message.Invoke(new Action(() => lb_message.Text = "Khách hàng không tồn tại!"));
                    }
                }
            }
            else
            {
                lb_message.Invoke(new Action(() => lb_message.Text = ""));
                LoadData();
            }
        }

        private void TimeElapsed2(object sender, ElapsedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_PhoneNumber.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@CustomerPhoneNumber", Txt_PhoneNumber.Text.Trim() + "%");
                cmd.CommandText = "select * from CustomerInformation where CustomerPhoneNumber like @CustomerPhoneNumber";

                using (adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        Dgv_CustomerInformation.Invoke(new Action(() => Dgv_CustomerInformation.DataSource = table));
                        lb_message.Invoke(new Action(() => lb_message.Text = ""));
                    }
                    else
                    {
                        lb_message.Invoke(new Action(() => lb_message.Text = "Khách hàng không tồn tại!"));
                    }
                }
            }
            else
            {
                lb_message.Invoke(new Action(() => lb_message.Text = ""));
                LoadData();
            }
        }

        private void ResetData()
        {
            lb_message.Invoke(new Action(() => lb_message.Text = ""));

            Txt_PhoneNumber.Text = string.Empty;
            Txt_CustomerName.Text = string.Empty;
            Txt_CustomerAddress.Text = string.Empty;

            LoadData();
        }

        private void Dgv_CustomerInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Dgv_CustomerInformation.CurrentRow.Index;
            Txt_PhoneNumber.Text = Dgv_CustomerInformation.Rows[i].Cells[0].Value.ToString();
            Txt_CustomerName.Text = Dgv_CustomerInformation.Rows[i].Cells[1].Value.ToString();
            Txt_CustomerAddress.Text = Dgv_CustomerInformation.Rows[i].Cells[2].Value.ToString();
        }
    }
}
