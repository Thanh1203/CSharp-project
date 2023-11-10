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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;

namespace Srouce_code.View
{
    public partial class QuanLyDoanhThu : Form
    {
        public int indexSelect = 0;
        private static readonly DbConnecting DbConnect = new DbConnecting();
        private SqlConnection conn;
        private SqlCommand cmd;
        private readonly SqlDataAdapter adapter = new SqlDataAdapter();
        private readonly DataTable table = new DataTable();
        private SqlDataReader reader;
        public QuanLyDoanhThu()
        {
            InitializeComponent();
        }

        private void Btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void QuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            DbConnect.OpenConnect();
            conn = DbConnect.GetConnection();

            lb_title.Text = "Doanh thu theo tháng";
            lb_title_select.Text = "Tháng";
            indexSelect = 0;
            CbList(indexSelect);
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                CB_years.Items.Add(i);
            }
            lb_total.Text = "0,000 VND";
            myChart.Series[0].Name = "Tháng";
            //DataChart();
            ColumnProduct();
        }

        private void MenuMonthlyRevenue_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Doanh thu theo tháng";
            lb_title_select.Text = "Tháng";
            Cb_list_select.Visible = true;
            Cb_list_select.Enabled = true;
            indexSelect = 0;
            CbList(indexSelect);
            myChart.Series[0].Name = "Tháng";
        }

        private void MenuQuarterlyRevenue_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Doanh thu theo quý";
            lb_title_select.Text = "Quý";
            Cb_list_select.Visible = true;
            Cb_list_select.Enabled = true;
            indexSelect = 1;
            CbList(indexSelect);
            myChart.Series[0].Name = "Quý";
        }

        private void MenuYearRevenue_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Doanh thu theo năm";
            lb_title_select.Text = string.Empty;
            Cb_list_select.Visible = false;
            Cb_list_select.Enabled = false;
            myChart.Series[0].Name = "Năm";
            indexSelect = 2;
        }

        private void CbList(int select)
        {
            if (select == 0)
            {
                Cb_list_select.Items.Clear();
                for (int i = 1; i < 13; i++)
                {
                    Cb_list_select.Items.Add("Tháng " + i);
                }
            }
            if (select == 1)
            {
                Cb_list_select.Items.Clear();
                for (int i = 1; i < 5; i++)
                {
                    Cb_list_select.Items.Add("Quý " + i);
                }
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            object selectedItem = Cb_list_select.SelectedItem;
            object selectedYear = CB_years.SelectedItem;
            cmd = conn.CreateCommand();


            if (selectedItem == null && selectedYear == null)
            {
                MessageBox.Show("Vui lòng điền thông tin");
                return;
            }

            if (indexSelect == 0)
            {
                queryMonth(selectedItem, selectedYear);
                TopProduct(selectedItem, selectedYear);
                TopTypeProduct();
            }
            if (indexSelect == 1)
            {
                MessageBox.Show("hi1");
            }
            if (indexSelect == 2)
            {
                MessageBox.Show("hi2");
            }
        }

        private void DataChart()
        {
            // Tạo một ChartArea mới
            ChartArea chartArea1 = new ChartArea("Biểu đồ Cột");

            // Đặt tên trục Y và giới hạn tối đa trục Y
            chartArea1.AxisY.Title = "Giá trị";
            chartArea1.AxisY.Maximum = 1.2 * 5; // Giới hạn tối đa là 120% giá trị cột cao nhất (ở đây là 5)

            // Gán ChartArea cho Chart
            myChart.Series["Series1"].Points.Add(1);  // Giá trị cột 1
            myChart.Series["Series1"].Points.Add(5);  // Giá trị cột 5
            myChart.Series["Series1"].Points.Add(2);  // Giá trị cột 2
            myChart.Series["Series1"].Points.Add(3);

        }

        private string CovertDataTypeMonth(object obj)
        {
            string str = "";
            for (int i = 1; i <= 12; i++)
            {
                string strMonth = "Tháng " + i;
                if (obj.ToString() == strMonth)
                {
                    str = i.ToString();
                }
            }
            return str;
        }

        private void queryMonth(object selectedItem, object selectedYear)
        {
            string StrQueryTotalValue = "select sum(TotalBill) as TotalSum from BillInformation where ";
            bool checkCondition = false;

            if (selectedItem != null)
            {
                cmd.Parameters.AddWithValue("@Month", CovertDataTypeMonth(selectedItem));
                StrQueryTotalValue += "MONTH(DayOut) = @Month";
                checkCondition = true;
            }
            else
            {
                MessageBox.Show("Vui Lòng Không Để Trống " + lb_title_select.Text);
                return;
            }

            if (selectedYear != null)
            {
                if (checkCondition)
                {
                    StrQueryTotalValue += " and ";
                }
                cmd.Parameters.AddWithValue("@Year", selectedYear.ToString());
                StrQueryTotalValue += "YEAR(DayOut) = @Year";
            }
            else
            {
                MessageBox.Show("Vui Lòng Không Để Trống Năm");
                return;
            }

            cmd.CommandText = StrQueryTotalValue;
            object result = cmd.ExecuteScalar();
            lb_total.Invoke(new Action(() => lb_total.Text = result.ToString() + ",000 VND"));
        }

        private void TopProduct(object selectedItem, object selectedYear)
        {
            string queryString = "SELECT TOP 10 D.IdProduct, SUM(D.Weight) AS TotalWeight " +
                    "FROM BillInformation B " +
                    "JOIN DataBill D ON B.IdBill = D.IdBill " +
                    "WHERE MONTH(B.DayOut) = @MonthParam AND YEAR(B.DayOut) = @YearParam " +
                    "GROUP BY D.IdProduct " +
                    "ORDER BY TotalWeight DESC;";
            cmd.Parameters.AddWithValue("@MonthParam", CovertDataTypeMonth(selectedItem));
            cmd.Parameters.AddWithValue("@YearParam", selectedYear.ToString());
            cmd.CommandText = queryString;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Product.DataSource = table;
        }

        private void TopTypeProduct()
        {
            foreach (DataGridViewRow row in DGV_Product.Rows)
            {
                if (row.IsNewRow) continue;
                int idProduct = int.Parse(row.Cells[0].Value.ToString());

                cmd = conn.CreateCommand();
                cmd.Parameters.AddWithValue("@IdProduct", idProduct);
                cmd.CommandText = "select IdTypeProduct, NameTypeProduct from ProductInfor, ProductTypeInfor where IdTypeProduct = TypeProduct and IdProduct = @IdProduct";
                using (reader = cmd.ExecuteReader()) {

                }
                
                //using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                //{
                //    adapter.Fill(table);
                //    DGV_TypeProduct.DataSource = table;
                //}
            }
        }

        private void ColumnProduct()
        {
            DataGridViewTextBoxColumn idProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã sản phẩm",
                DataPropertyName = "IdProduct",
            };
            DGV_Product.Columns.Add(idProductColumn);

            DataGridViewTextBoxColumn nameProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Khối lượng",
                DataPropertyName = "TotalWeight",
            };
            DGV_Product.Columns.Add(nameProductColumn);
        }
    }
}
