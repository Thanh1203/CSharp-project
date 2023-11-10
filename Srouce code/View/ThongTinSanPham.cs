using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Srouce_code.DbConnect;
using System.Data;

namespace Srouce_code.View
{
    public partial class ThongTinSanPham : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private readonly SqlDataAdapter adapter = new SqlDataAdapter();
        private readonly DataTable table = new DataTable();

        public ThongTinSanPham()
        {
            InitializeComponent();
        }

        private void ThongTinSanPham_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            DGV_Product_Information.RowTemplate.Height = 50;
            DataGridViewTextBoxColumn idProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã sản phẩm",
                DataPropertyName = "IdProduct",
            };
            DGV_Product_Information.Columns.Add(idProductColumn);

            DataGridViewTextBoxColumn nameProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "NameProduct",
            };
            DGV_Product_Information.Columns.Add(nameProductColumn);

            DataGridViewTextBoxColumn TypeProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Loại sản phẩm",
                DataPropertyName = "TypeProduct",
            };
            DGV_Product_Information.Columns.Add(TypeProductColumn);

            DataGridViewTextBoxColumn ColorProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Màu sắc",
                DataPropertyName = "ColorProduct",
            };
            DGV_Product_Information.Columns.Add(ColorProductColumn);

            LoadData();
        }

        private void Btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage homepage = new HomePage();
            homepage.Show();
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Price.Text) && !string.IsNullOrWhiteSpace(Txt_TypeProduct.Text) && !string.IsNullOrWhiteSpace(Txt_ColorProduct.Text))
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into ProductInfor (NameProduct, TypeProduct, ColorProduct, WeightProduct, PriceProduct) VALUES (@NameProduct, @TypeProduct, @ColorProduct, 0, @PriceProduct)";
                cmd.Parameters.AddWithValue("@NameProduct", Txt_NameProduct.Text);
                cmd.Parameters.AddWithValue("@TypeProduct", Txt_TypeProduct.Text);
                cmd.Parameters.AddWithValue("@ColorProduct", Txt_ColorProduct.Text);
                cmd.Parameters.AddWithValue("@PriceProduct", double.Parse(txt_Price.Text));
                cmd.ExecuteNonQuery();
                LoadData();

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_IdProduct.Text))
            {
                using (cmd = new SqlCommand("UpdateProduct", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_IdProduct.Text.Trim()));
                    cmd.Parameters.AddWithValue("@NameProduct", Txt_NameProduct.Text);
                    cmd.Parameters.AddWithValue("@TypeProduct", Txt_TypeProduct.Text);
                    cmd.Parameters.AddWithValue("@ColorProduct", Txt_ColorProduct.Text);
                    cmd.Parameters.AddWithValue("@PriceProduct", double.Parse(txt_Price.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền mã sản phẩm");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_IdProduct.Text))
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from ProductInfor where IdProduct = @IdProduct";
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_IdProduct.Text.Trim()));
                cmd.ExecuteNonQuery();
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng điền mã sản phẩm");
            }
        }

        private void Btn_Sreach_Click(object sender, EventArgs e)
        {
            if (IsAnyField())
            {
                bool checkFieldBefore = false;
                string strQuery = "select IdProduct, NameProduct, TypeProduct, ColorProduct, PriceProduct from ProductInfor where";
                cmd = conn.CreateCommand();
                if (!string.IsNullOrWhiteSpace(Txt_IdProduct.Text.Trim()))
                {
                    strQuery += " IdProduct = @IdProduct";
                    checkFieldBefore = true;
                    cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_IdProduct.Text.Trim()));
                }
                if (!string.IsNullOrWhiteSpace(Txt_NameProduct.Text))
                {
                    if (checkFieldBefore)
                    {
                        strQuery += " and NameProduct = @NameProduct";
                    }
                    else
                    {
                        strQuery += " NameProduct like @NameProduct";
                        checkFieldBefore = true;
                    }
                    cmd.Parameters.AddWithValue("@NameProduct", "%" + Txt_NameProduct.Text + "%");
                }
                if (!string.IsNullOrWhiteSpace(Txt_TypeProduct.Text))
                {
                    if (checkFieldBefore)
                    {
                        strQuery += " and TypeProduct = @TypeProduct";
                    }
                    else
                    {
                        strQuery += " TypeProduct = @TypeProduct";
                        checkFieldBefore = true;
                    }
                    cmd.Parameters.AddWithValue("@TypeProduct", "%" + Txt_TypeProduct.Text + "%");
                }
                if (!string.IsNullOrWhiteSpace(Txt_ColorProduct.Text))
                {
                    if (checkFieldBefore)
                    {
                        strQuery += " and ColorProduct = @ColorProduct";
                    }
                    else
                    {
                        strQuery += " ColorProduct = @ColorProduct";
                        checkFieldBefore = true;
                    }
                    cmd.Parameters.AddWithValue("@ColorProduct", "%" + Txt_ColorProduct.Text + "%");
                }
                if (!string.IsNullOrWhiteSpace(txt_Price.Text.Trim()))
                {
                    if (checkFieldBefore)
                    {
                        strQuery += " and PriceProduct = @PriceProduct";
                    }
                    else
                    {
                        strQuery += " PriceProduct = @PriceProduct";
                    }
                    cmd.Parameters.AddWithValue("@PriceProduct", "%" + double.Parse(txt_Price.Text.Trim()) + "%");
                }
                cmd.CommandText = strQuery;
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DGV_Product_Information.DataSource = table;
            }
            else
            {
                MessageBox.Show("Vui lòng điền mã sản phẩm");
            }
        }

        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
            Txt_IdProduct.Text = string.Empty;
            Txt_NameProduct.Text = string.Empty;
            Txt_TypeProduct.Text = string.Empty;
            Txt_ColorProduct.Text = string.Empty;
        }

        public void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select IdProduct, NameProduct, TypeProduct, ColorProduct, PriceProduct from ProductInfor";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Product_Information.DataSource = table;
        }

        public bool IsAnyField()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && !string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void DGV_Product_Information_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGV_Product_Information.CurrentRow.Index;
            Txt_IdProduct.Text = DGV_Product_Information.Rows[i].Cells[0].Value.ToString();
            Txt_NameProduct.Text = DGV_Product_Information.Rows[i].Cells[1].Value.ToString();
            Txt_TypeProduct.Text = DGV_Product_Information.Rows[i].Cells[2].Value.ToString();
            Txt_ColorProduct.Text = DGV_Product_Information.Rows[i].Cells[3].Value.ToString();
            txt_Price.Text = DGV_Product_Information.Rows[i].Cells[4].Value.ToString();
        }

        private void MenuInsertProduct_Click(object sender, EventArgs e)
        {
            Btn_update.Enabled = false;
            Btn_update.Visible = false;

            Btn_Delete.Enabled = false;
            Btn_Delete.Visible = false;

            Btn_Insert.Enabled = true;
            Btn_Insert.Visible = true;

            lb_title.Text = "Thêm thông tin sản phẩm";

            Txt_NameProduct.Visible = true;
            Txt_TypeProduct.Visible = true;
            Txt_ColorProduct.Visible = true;
            txt_Price.Visible = true;
        }

        private void MenuUpdateProduct_Click(object sender, EventArgs e)
        {
            Btn_update.Enabled = true;
            Btn_update.Visible = true;

            Btn_Delete.Enabled = false;
            Btn_Delete.Visible = false;

            Btn_Insert.Enabled = false;
            Btn_Insert.Visible = false;

            lb_title.Text = "Sửa thông tin sản phẩm";

            Txt_NameProduct.Visible = true;
            Txt_TypeProduct.Visible = true;
            Txt_ColorProduct.Visible = true;
            txt_Price.Visible = true;

        }

        private void MenuDeleteProduct_Click(object sender, EventArgs e)
        {
            Btn_update.Enabled = false;
            Btn_update.Visible = false;

            Btn_Delete.Enabled = true;
            Btn_Delete.Visible = true;

            Btn_Insert.Enabled = false;
            Btn_Insert.Visible = false;

            lb_title.Text = "Xóa thông tin sản phẩm";

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            Txt_NameProduct.Visible = false;
            Txt_TypeProduct.Visible = false;
            Txt_ColorProduct.Visible = false;
            txt_Price.Visible = false;
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


