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

            DataGridViewTextBoxColumn kindOfProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Chủng loại",
                DataPropertyName = "KindOfProduct",
            };
            DGV_Product_Information.Columns.Add(kindOfProductColumn);

            DataGridViewTextBoxColumn colorOfProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Màu sắc",
                DataPropertyName = "ColorOfProduct",
            };
            DGV_Product_Information.Columns.Add(colorOfProductColumn);
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
            if (Txt_NameProduct.Text != null && Txt_KindOfProduct != null && Txt_ColorOfProduct != null)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into ProductsInfomation (NameProduct, KindOfProduct, ColorOfProduct, ColorOfProduct) VALUES (@NameProduct, @KindOfProduct, @ColorOfProduct, 0)";
                cmd.Parameters.AddWithValue("@NameProduct", Txt_NameProduct.Text);
                cmd.Parameters.AddWithValue("@KindOfProduct", Txt_KindOfProduct.Text);
                cmd.Parameters.AddWithValue("@ColorOfProduct", Txt_ColorOfProduct.Text);
                cmd.ExecuteNonQuery();
                LoadData();

            } else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_IdProduct.Text))
            {
                using(SqlCommand cmd = new SqlCommand("UpdateProduct", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_IdProduct.Text.Trim()));
                    cmd.Parameters.AddWithValue("@NameProduct", Txt_NameProduct.Text);
                    cmd.Parameters.AddWithValue("@KindOfProduct", Txt_KindOfProduct.Text);
                    cmd.Parameters.AddWithValue("@ColorOfProduct", Txt_ColorOfProduct.Text);
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
                cmd.CommandText = "delete from ProductsInfomation where IdProduct = @IdProduct";
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
            if (!string.IsNullOrWhiteSpace(Txt_IdProduct.Text))
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "select IdProduct, NameProduct, KindOfProduct, ColorOfProduct from ProductsInfomation where IdProduct = @IdProduct";
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_IdProduct.Text.Trim()));
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
            Txt_KindOfProduct.Text = string.Empty;
            Txt_ColorOfProduct.Text = string.Empty;
        }
        public void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select IdProduct, NameProduct, KindOfProduct, ColorOfProduct from ProductsInfomation";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Product_Information.DataSource = table;
        }


    }
}


