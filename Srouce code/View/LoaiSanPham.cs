using Srouce_code.DbConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srouce_code.View
{
    public partial class LoaiSanPham : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private readonly SqlDataAdapter adapter = new SqlDataAdapter();
        private readonly DataTable table = new DataTable();
        //private int stateSelected = 0;

        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            DGV_Type.RowTemplate.Height = 40;
            Btn_update.Visible = false;
            Btn_delete.Visible = false;

            LoadData();
        }

        private void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ProductTypeInfor";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Type.DataSource = table;
        }

        private void Btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();    
        }

        private void Btn_inset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_idtypeproduct.Text) && (!string.IsNullOrWhiteSpace(Txt_nameproduct.Text)))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdTypeProduct", Txt_idtypeproduct.Text);
                cmd.Parameters.AddWithValue("@NameTypeProduct", Txt_nameproduct.Text);
                cmd.CommandText = "insert into ProductTypeInfor (IdTypeProduct, NameTypeProduct) values (@IdTypeProduct, @NameTypeProduct)";
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
            if (!string.IsNullOrWhiteSpace(Txt_idtypeproduct.Text) && (!string.IsNullOrWhiteSpace(Txt_nameproduct.Text)))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdTypeProduct", Txt_idtypeproduct.Text);
                cmd.Parameters.AddWithValue("@NameTypeProduct", Txt_nameproduct.Text);
                cmd.CommandText = "update ProductTypeInfor set NameTypeProduct = @NameTypeProduct where @IdTypeProduct = IdTypeProduct";
                cmd.ExecuteNonQuery();
                LoadData();

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_idtypeproduct.Text))
            {
                DialogResult result = MessageBox.Show("Nếu xóa loại sản phẩm các sản phẩm của loại này cũng sẽ bị xóa", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cmd = conn.CreateCommand();
                    cmd.Parameters.AddWithValue("@IdTypeProduct", Txt_idtypeproduct.Text);
                    cmd.CommandText = "delete from ProductTypeInfor where @IdTypeProduct = IdTypeProduct";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "delete from ProductInfor where @IdTypeProduct = TypeProduct";
                    cmd.ExecuteNonQuery();

                    
                    LoadData();
                }
                else return;
                
            } else
            {
                MessageBox.Show("Vui lòng nhập mã loại sản phẩm");

            }
        }

        private void Btn_reload_Click(object sender, EventArgs e)
        {
            Txt_idtypeproduct.Text = string.Empty;
            Txt_nameproduct.Text = string.Empty;
            LoadData();
        }

        private void MenuInsertTypeProduct_Click(object sender, EventArgs e)
        {
            Btn_inset.Visible = true;
            Btn_update.Visible = false;
            Btn_delete.Visible = false;
            label3.Visible = true;
            Txt_nameproduct.Visible = true;
        }

        private void MenuUpdateTypeProduct_Click(object sender, EventArgs e)
        {
            Btn_inset.Visible = false;
            Btn_update.Visible = true;
            Btn_delete.Visible = false;
            label3.Visible = true;
            Txt_nameproduct.Visible = true;
        }

        private void MenuDeleteTypeProduct_Click(object sender, EventArgs e)
        {
            Btn_inset.Visible = false;
            Btn_update.Visible = false;
            Btn_delete.Visible = true;
            label3.Visible = false;
            Txt_nameproduct.Visible = false;
        }
    }
}
