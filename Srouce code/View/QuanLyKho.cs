using Srouce_code.DbConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Srouce_code.View
{
    public partial class QuanLyKho : Form
    {
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private readonly SqlDataAdapter adapter = new SqlDataAdapter();
        private readonly DataTable table = new DataTable();
        //private SqlDataReader reader;


        public QuanLyKho()
        {
            InitializeComponent();
        }

        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            DGV_ProductsContant.RowTemplate.Height = 50;

            TotalWeight();
            NameColumn();
            LoadData();
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

        private void Btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
        }

        public void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select IdProduct, NameProduct, TypeProduct, ColorProduct, WeightProduct from ProductInfor";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_ProductsContant.DataSource = table;
        }

        public void NameColumn()
        {
            DataGridViewTextBoxColumn idProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã sản phẩm",
                DataPropertyName = "IdProduct",
            };
            DGV_ProductsContant.Columns.Add(idProductColumn);

            DataGridViewTextBoxColumn nameProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "NameProduct",
            };
            DGV_ProductsContant.Columns.Add(nameProductColumn);

            DataGridViewTextBoxColumn TypeProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Loại sản phẩm",
                DataPropertyName = "TypeProduct",
            };
            DGV_ProductsContant.Columns.Add(TypeProductColumn);

            DataGridViewTextBoxColumn ColorProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Màu sắc",
                DataPropertyName = "ColorProduct",
            };
            DGV_ProductsContant.Columns.Add(ColorProductColumn);

            DataGridViewTextBoxColumn WeightProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Khối lượng",
                DataPropertyName = "WeightProduct",
            };
            DGV_ProductsContant.Columns.Add(WeightProductColumn);

        }

        public void TotalWeight()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select sum(WeightProduct) as TotalSum from ProductInfor";
            object result = cmd.ExecuteScalar();
            lb_weight.Invoke(new Action(() => lb_weight.Text = result.ToString()));
        }

        private void Btn_FilterList_Click(object sender, EventArgs e)
        {
            object selectedType = CB_ProductType.SelectedItem;
            object selectedColor = CB_ProductColor.SelectedItem;
            bool checkCondition = false;
            string queryStr = "select IdProduct, NameProduct, TypeProduct, ColorProduct, WeightProduct from ProductInfor where ";
            string totalWeightQueryStr = "";
            cmd = conn.CreateCommand();

            if (selectedType == null && selectedColor == null)
            {
                MessageBox.Show("Vui lòng điền thông tin");
                return;
            }

            if (selectedType != null)
            {
                cmd.Parameters.AddWithValue("@TypeProduct", selectedType.ToString());
                queryStr += "@TypeProduct = TypeProduct";
                totalWeightQueryStr += "@TypeProduct = TypeProduct";
                checkCondition = true;
            }

            if (selectedColor != null)
            {
                if (checkCondition)
                {
                    queryStr += " and ";
                    totalWeightQueryStr += " and ";
                };
                cmd.Parameters.AddWithValue("@ColorProduct", selectedColor.ToString());
                queryStr += "@ColorProduct = ColorProduct";
                totalWeightQueryStr += "@ColorProduct = ColorProduct";
            }
            cmd.CommandText = "select sum(WeightProduct) as TotalSum from ProductInfor where " + totalWeightQueryStr;
            object result = cmd.ExecuteScalar();
            lb_weight.Invoke(new Action(() => lb_weight.Text = result.ToString()));
            cmd.CommandText = queryStr;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_ProductsContant.DataSource = table;
        }

        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            CB_ProductType.SelectedItem = null;
            CB_ProductColor.SelectedItem = null;
            Txt_Masp.Text = string.Empty;
            TotalWeight();
            LoadData();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_Masp.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_Masp.Text));
                cmd.CommandText = "select IdProduct, NameProduct, TypeProduct, ColorProduct, WeightProduct from ProductInfor where @IdProduct = IdProduct";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DGV_ProductsContant.DataSource = table;

                cmd.CommandText = "select WeightProduct from ProductInfor where @IdProduct = IdProduct";
                object result = cmd.ExecuteScalar();
                lb_weight.Invoke(new Action(() => lb_weight.Text = result.ToString()));
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
            }
        }
    }
}
