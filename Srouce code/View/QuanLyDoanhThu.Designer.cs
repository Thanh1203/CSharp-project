namespace Srouce_code.View
{
    partial class QuanLyDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_out = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMonthlyRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuarterlyRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuYearRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_title = new System.Windows.Forms.Label();
            this.Cb_list_select = new System.Windows.Forms.ComboBox();
            this.lb_title_select = new System.Windows.Forms.Label();
            this.Btn_ResetData = new System.Windows.Forms.Button();
            this.Btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.CB_years = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_TypeProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TypeProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý doanh thu";
            // 
            // Btn_out
            // 
            this.Btn_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_out.BackColor = System.Drawing.Color.Red;
            this.Btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_out.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_out.Location = new System.Drawing.Point(11, 815);
            this.Btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_out.Name = "Btn_out";
            this.Btn_out.Size = new System.Drawing.Size(119, 35);
            this.Btn_out.TabIndex = 16;
            this.Btn_out.Text = "Thoát";
            this.Btn_out.UseVisualStyleBackColor = false;
            this.Btn_out.Click += new System.EventHandler(this.Btn_out_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMonthlyRevenue,
            this.MenuQuarterlyRevenue,
            this.MenuYearRevenue});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMonthlyRevenue
            // 
            this.MenuMonthlyRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMonthlyRevenue.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuMonthlyRevenue.Name = "MenuMonthlyRevenue";
            this.MenuMonthlyRevenue.Size = new System.Drawing.Size(170, 29);
            this.MenuMonthlyRevenue.Text = "Doanh thu tháng";
            this.MenuMonthlyRevenue.Click += new System.EventHandler(this.MenuMonthlyRevenue_Click);
            // 
            // MenuQuarterlyRevenue
            // 
            this.MenuQuarterlyRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQuarterlyRevenue.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuQuarterlyRevenue.Name = "MenuQuarterlyRevenue";
            this.MenuQuarterlyRevenue.Size = new System.Drawing.Size(152, 29);
            this.MenuQuarterlyRevenue.Text = "Doanh thu quý";
            this.MenuQuarterlyRevenue.Click += new System.EventHandler(this.MenuQuarterlyRevenue_Click);
            // 
            // MenuYearRevenue
            // 
            this.MenuYearRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuYearRevenue.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuYearRevenue.Name = "MenuYearRevenue";
            this.MenuYearRevenue.Size = new System.Drawing.Size(158, 29);
            this.MenuYearRevenue.Text = "Doanh thu năm";
            this.MenuYearRevenue.Click += new System.EventHandler(this.MenuYearRevenue_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_title.Location = new System.Drawing.Point(14, 95);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(55, 20);
            this.lb_title.TabIndex = 18;
            this.lb_title.Text = "lb_title";
            // 
            // Cb_list_select
            // 
            this.Cb_list_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_list_select.FormattingEnabled = true;
            this.Cb_list_select.Location = new System.Drawing.Point(133, 137);
            this.Cb_list_select.Name = "Cb_list_select";
            this.Cb_list_select.Size = new System.Drawing.Size(364, 32);
            this.Cb_list_select.TabIndex = 19;
            // 
            // lb_title_select
            // 
            this.lb_title_select.AutoSize = true;
            this.lb_title_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_select.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_title_select.Location = new System.Drawing.Point(14, 141);
            this.lb_title_select.Name = "lb_title_select";
            this.lb_title_select.Size = new System.Drawing.Size(107, 25);
            this.lb_title_select.TabIndex = 20;
            this.lb_title_select.Text = "lb_select";
            // 
            // Btn_ResetData
            // 
            this.Btn_ResetData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_ResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ResetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetData.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_ResetData.Location = new System.Drawing.Point(381, 253);
            this.Btn_ResetData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ResetData.Name = "Btn_ResetData";
            this.Btn_ResetData.Size = new System.Drawing.Size(116, 34);
            this.Btn_ResetData.TabIndex = 31;
            this.Btn_ResetData.Text = "Làm mới";
            this.Btn_ResetData.UseVisualStyleBackColor = false;
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_search.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_search.Location = new System.Drawing.Point(133, 253);
            this.Btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(116, 34);
            this.Btn_search.TabIndex = 32;
            this.Btn_search.Text = "Tìm kiếm";
            this.Btn_search.UseVisualStyleBackColor = false;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_total.Location = new System.Drawing.Point(714, 317);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(69, 20);
            this.lb_total.TabIndex = 35;
            this.lb_total.Text = "lb_total";
            // 
            // CB_years
            // 
            this.CB_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_years.FormattingEnabled = true;
            this.CB_years.Location = new System.Drawing.Point(133, 199);
            this.CB_years.Name = "CB_years";
            this.CB_years.Size = new System.Drawing.Size(364, 32);
            this.CB_years.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.DGV_TypeProduct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 455);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại sản phẩm bán chạy";
            // 
            // DGV_TypeProduct
            // 
            this.DGV_TypeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_TypeProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TypeProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TypeProduct.Location = new System.Drawing.Point(6, 25);
            this.DGV_TypeProduct.Name = "DGV_TypeProduct";
            this.DGV_TypeProduct.Size = new System.Drawing.Size(386, 424);
            this.DGV_TypeProduct.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.DGV_Product);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(489, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 455);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm bán chạy";
            // 
            // DGV_Product
            // 
            this.DGV_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.Location = new System.Drawing.Point(6, 25);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.Size = new System.Drawing.Size(383, 604);
            this.DGV_Product.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Năm";
            // 
            // QuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(934, 861);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CB_years);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.Btn_ResetData);
            this.Controls.Add(this.lb_title_select);
            this.Controls.Add(this.Cb_list_select);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.Btn_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDoanhThu";
            this.Load += new System.EventHandler(this.QuanLyDoanhThu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TypeProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_out;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuMonthlyRevenue;
        private System.Windows.Forms.ToolStripMenuItem MenuQuarterlyRevenue;
        private System.Windows.Forms.ToolStripMenuItem MenuYearRevenue;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ComboBox Cb_list_select;
        private System.Windows.Forms.Label lb_title_select;
        private System.Windows.Forms.Button Btn_ResetData;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.ComboBox CB_years;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_TypeProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.Label label3;
    }
}