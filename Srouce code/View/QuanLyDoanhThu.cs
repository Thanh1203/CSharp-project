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
        private readonly SqlDataAdapter adapter2 = new SqlDataAdapter();
        private readonly DataTable table2 = new DataTable();
        //private SqlDataReader reader;
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
            ColumnProduct();
            ColumnTypeProduct();
        }

        private void MenuMonthlyRevenue_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Doanh thu theo tháng";
            lb_title_select.Text = "Tháng";
            Cb_list_select.Visible = true;
            Cb_list_select.Enabled = true;
            indexSelect = 0;
            CbList(indexSelect);
        }

        private void MenuQuarterlyRevenue_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Doanh thu theo quý";
            lb_title_select.Text = "Quý";
            Cb_list_select.Visible = true;
            Cb_list_select.Enabled = true;
            indexSelect = 1;
            CbList(indexSelect);
        }

        private void MenuYearRevenue_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Doanh thu theo năm";
            lb_title_select.Text = string.Empty;
            Cb_list_select.Visible = false;
            Cb_list_select.Enabled = false;
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
                QueryTotalValue(selectedItem, selectedYear, indexSelect);
                TopProduct(selectedItem, selectedYear);
                TopTypeProduct(selectedItem, selectedYear);
            }
            if (indexSelect == 1)
            {
                QueryTotalValue(selectedItem, selectedYear, indexSelect);
                TopProductQuarterly(selectedItem, selectedYear);
                TopTypeProductQuarterly(selectedItem, selectedYear);
            }
            if (indexSelect == 2)
            {
                QueryTotalValue(selectedItem, selectedYear, indexSelect);
                TopProductYear(selectedYear);
                TopTypeProductYear(selectedYear);
            }
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

        private int CovertDataTypeQuarterly(object  obj)
        {
            int index = 0;
            for (int i = 1; i <= 4; i++)
            {
                string strMonth = "Quý " + i;
                if (obj.ToString() == strMonth)
                {
                    index = i;
                }
            }
            return index;
        }

        private void QueryTotalValue(object selectedItem, object selectedYear, int index)
        {
            string StrQueryTotalValue = "select sum(TotalBill) as TotalSum from BillInformation where ";
            bool checkCondition = false;
            if (index != 2)
            {
                if (selectedItem != null)
                {
                    if (index == 0)
                    {
                        cmd.Parameters.AddWithValue("@Month", CovertDataTypeMonth(selectedItem));
                        StrQueryTotalValue += "MONTH(DayOut) = @Month";
                        checkCondition = true;
                    }
                    if (index == 1)
                    {
                        cmd.Parameters.AddWithValue("@Quarter", CovertDataTypeQuarterly(selectedItem));
                        StrQueryTotalValue += "DATEPART(QUARTER, DayOut) = @Quarter";
                        checkCondition = true;
                    }
                }
                else
                {
                    MessageBox.Show("Vui Lòng Không Để Trống " + lb_title_select.Text);
                    return;
                }
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
            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@MonthParam", CovertDataTypeMonth(selectedItem));
            cmd.Parameters.AddWithValue("@YearParam", selectedYear.ToString());
            cmd.CommandText = queryString;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Product.DataSource = table;
        }

        private void TopProductQuarterly(object selectedItem, object selectedYear)
        {
            string queryString = "SELECT TOP 10 D.IdProduct, SUM(D.Weight) AS TotalWeight " +
                    "FROM BillInformation B " +
                    "JOIN DataBill D ON B.IdBill = D.IdBill " +
                    "WHERE DATEPART(QUARTER, B.DayOut) = @QuarterParam AND YEAR(B.DayOut) = @YearParam " +
                    "GROUP BY D.IdProduct " +
                    "ORDER BY TotalWeight DESC;";
            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@QuarterParam", CovertDataTypeQuarterly(selectedItem));
            cmd.Parameters.AddWithValue("@YearParam", selectedYear.ToString());
            cmd.CommandText = queryString;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Product.DataSource = table;
        }

        private void TopProductYear(object selectedYear)
        {
            string queryString = "SELECT TOP 10 D.IdProduct, SUM(D.Weight) AS TotalWeight " +
                     "FROM BillInformation B " +
                     "JOIN DataBill D ON B.IdBill = D.IdBill " +
                     "WHERE YEAR(B.DayOut) = @YearParam " +
                     "GROUP BY D.IdProduct " +
                     "ORDER BY TotalWeight DESC;";
            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@YearParam", selectedYear.ToString());
            cmd.CommandText = queryString;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_Product.DataSource = table;
        }

        private void TopTypeProduct(object selectedItem, object selectedYear)
        {
            string queryString = "WITH TopProducts AS (" +
            "SELECT DB.IdProduct, PIF.IdTypeProduct, SUM(DB.Weight) AS TotalWeight, ROW_NUMBER() OVER (PARTITION BY PIF.IdTypeProduct ORDER BY SUM(DB.Weight) DESC) AS RowNum " +
            "FROM DataBill DB " +
            "INNER JOIN BillInformation BI ON DB.IdBill = BI.IdBill " +
            "INNER JOIN ProductTypeInfor AS PIF ON DB.IdTypeProduct = PIF.IdTypeProduct " +
            "WHERE MONTH(BI.DayOut) = @MonthValue AND YEAR(BI.DayOut) = @YearValue " +
            "GROUP BY DB.IdProduct, PIF.IdTypeProduct) " +
            "SELECT DISTINCT TP.IdTypeProduct, PTI.NameTypeProduct " +
            "FROM TopProducts AS TP INNER JOIN ProductTypeInfor AS PTI ON TP.IdTypeProduct = PTI.IdTypeProduct " +
            "WHERE TP.RowNum = 1";

            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@MonthValue", CovertDataTypeMonth(selectedItem));
            cmd.Parameters.AddWithValue("@YearValue", selectedYear.ToString());
            cmd.CommandText= queryString;
            adapter2.SelectCommand = cmd;
            table2.Clear();
            adapter2.Fill(table2);
            DGV_TypeProduct.DataSource = table2;
        }

        private void TopTypeProductQuarterly(object selectedItem, object selectedYear)
        {
            string queryString = "WITH TopProducts AS (" +
            "SELECT DB.IdProduct, PIF.IdTypeProduct, SUM(DB.Weight) AS TotalWeight, ROW_NUMBER() OVER (PARTITION BY PIF.IdTypeProduct ORDER BY SUM(DB.Weight) DESC) AS RowNum " +
            "FROM DataBill DB " +
            "INNER JOIN BillInformation BI ON DB.IdBill = BI.IdBill " +
            "INNER JOIN ProductTypeInfor AS PIF ON DB.IdTypeProduct = PIF.IdTypeProduct " +
            "WHERE DATEPART(QUARTER, BI.DayOut) = @QuarterValue AND YEAR(BI.DayOut) = @YearValue " +
            "GROUP BY DB.IdProduct, PIF.IdTypeProduct) " +
            "SELECT DISTINCT TP.IdTypeProduct, PTI.NameTypeProduct " +
            "FROM TopProducts AS TP INNER JOIN ProductTypeInfor AS PTI ON TP.IdTypeProduct = PTI.IdTypeProduct " +
            "WHERE TP.RowNum = 1";

            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@QuarterValue", CovertDataTypeQuarterly(selectedItem));
            cmd.Parameters.AddWithValue("@YearValue", selectedYear.ToString());
            cmd.CommandText = queryString;
            adapter2.SelectCommand = cmd;
            table2.Clear();
            adapter2.Fill(table2);
            DGV_TypeProduct.DataSource = table2;
        }

        private void TopTypeProductYear(object selectedYear)
        {
            string queryString = "WITH TopProducts AS (" +
            "SELECT DB.IdProduct, PIF.IdTypeProduct, SUM(DB.Weight) AS TotalWeight, ROW_NUMBER() OVER (PARTITION BY PIF.IdTypeProduct ORDER BY SUM(DB.Weight) DESC) AS RowNum " +
            "FROM DataBill DB " +
            "INNER JOIN BillInformation BI ON DB.IdBill = BI.IdBill " +
            "INNER JOIN ProductTypeInfor AS PIF ON DB.IdTypeProduct = PIF.IdTypeProduct " +
            "WHERE YEAR(BI.DayOut) = @YearValue " +
            "GROUP BY DB.IdProduct, PIF.IdTypeProduct) " +
            "SELECT DISTINCT TP.IdTypeProduct, PTI.NameTypeProduct " +
            "FROM TopProducts AS TP INNER JOIN ProductTypeInfor AS PTI ON TP.IdTypeProduct = PTI.IdTypeProduct " +
            "WHERE TP.RowNum = 1";

            cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@YearValue", selectedYear.ToString());
            cmd.CommandText = queryString;
            adapter2.SelectCommand = cmd;
            table2.Clear();
            adapter2.Fill(table2);
            DGV_TypeProduct.DataSource = table2;
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


        private void ColumnTypeProduct()
        {
            DataGridViewTextBoxColumn idProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã loại sản phẩm",
                DataPropertyName = "IdTypeProduct",
            };
            DGV_TypeProduct.Columns.Add(idProductColumn);

            DataGridViewTextBoxColumn nameProductColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên loại sản phẩm",
                DataPropertyName = "NameTypeProduct",
            };
            DGV_TypeProduct.Columns.Add(nameProductColumn);
        }
    }
}
