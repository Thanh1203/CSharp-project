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
            cmd.CommandText = "select IdProduct, NameProduct, KindOfProduct, ColorOfProduct, VolumeOfProduct from ProductsInfomation";
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

            DataGridViewTextBoxColumn kindOfProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Loại sản phẩm",
                DataPropertyName = "KindOfProduct",
            };
            DGV_ProductsContant.Columns.Add(kindOfProductColumn);

            DataGridViewTextBoxColumn colorOfProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Màu sắc",
                DataPropertyName = "ColorOfProduct",
            };
            DGV_ProductsContant.Columns.Add(colorOfProductColumn);

            DataGridViewTextBoxColumn VolumeOfProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Khối lượng",
                DataPropertyName = "VolumeOfProduct",
            };
            DGV_ProductsContant.Columns.Add(VolumeOfProductColumn);

        }

        public void TotalWeight()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select sum(VolumeOfProduct) as TotalSum from ProductsInfomation";
            object result = cmd.ExecuteScalar();
            lb_weight.Invoke(new Action(() => lb_weight.Text = result.ToString()));
        }

        private void Btn_FilterList_Click(object sender, EventArgs e)
        {
            object selectedType = CB_ProductType.SelectedItem;
            object selectedColor = CB_ProductColor.SelectedItem;
            bool checkCondition = false;
            string queryStr = "select IdProduct, NameProduct, KindOfProduct, ColorOfProduct, VolumeOfProduct from ProductsInfomation where ";
            string totalWeightQueryStr = "";
            cmd = conn.CreateCommand();

            if (selectedType == null && selectedColor == null)
            {
                MessageBox.Show("Vui lòng điền thông tin");
                return;
            }

            if (selectedType != null)
            {
                cmd.Parameters.AddWithValue("@KindOfProduct", selectedType.ToString());
                queryStr += "@KindOfProduct = KindOfProduct";
                totalWeightQueryStr += "@KindOfProduct = KindOfProduct";
                checkCondition = true;
            }

            if (selectedColor != null)
            {
                if (checkCondition) 
                {
                    queryStr += " and ";
                    totalWeightQueryStr += " and ";
                };
                cmd.Parameters.AddWithValue("@ColorOfProduct", selectedColor.ToString());
                queryStr += "@ColorOfProduct = ColorOfProduct";
                totalWeightQueryStr += "@ColorOfProduct = ColorOfProduct";
            }
            cmd.CommandText = "select sum(VolumeOfProduct) as TotalSum from ProductsInfomation where " + totalWeightQueryStr;
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
 
            LoadData();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_Masp.Text))
            {
                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", int.Parse(Txt_Masp.Text));
                cmd.CommandText = "select IdProduct, NameProduct, KindOfProduct, ColorOfProduct, VolumeOfProduct from ProductsInfomation where @IdProduct = IdProduct";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DGV_ProductsContant.DataSource = table;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
            }
        }
    }
}
