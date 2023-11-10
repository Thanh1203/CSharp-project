namespace Srouce_code.View
{
    partial class QuanLyKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_weight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_ProductType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_ProductColor = new System.Windows.Forms.ComboBox();
            this.Btn_FilterList = new System.Windows.Forms.Button();
            this.Btn_Reload = new System.Windows.Forms.Button();
            this.DGV_ProductsContant = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Masp = new System.Windows.Forms.TextBox();
            this.Btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProductsContant)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_out
            // 
            this.Btn_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_out.BackColor = System.Drawing.Color.Red;
            this.Btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_out.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_out.Location = new System.Drawing.Point(11, 515);
            this.Btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_out.Name = "Btn_out";
            this.Btn_out.Size = new System.Drawing.Size(119, 35);
            this.Btn_out.TabIndex = 16;
            this.Btn_out.Text = "Thoát";
            this.Btn_out.UseVisualStyleBackColor = false;
            this.Btn_out.Click += new System.EventHandler(this.Btn_out_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thông tin kho hàng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(586, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tổng khối lượng hàng còn lại:";
            // 
            // lb_weight
            // 
            this.lb_weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_weight.AutoSize = true;
            this.lb_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_weight.Location = new System.Drawing.Point(1003, 482);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(35, 24);
            this.lb_weight.TabIndex = 20;
            this.lb_weight.Text = "0,0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1139, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kg";
            // 
            // CB_ProductType
            // 
            this.CB_ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ProductType.FormattingEnabled = true;
            this.CB_ProductType.Items.AddRange(new object[] {
            "CDMQH55",
            "CSMQH55",
            "GNH55"});
            this.CB_ProductType.Location = new System.Drawing.Point(157, 57);
            this.CB_ProductType.Name = "CB_ProductType";
            this.CB_ProductType.Size = new System.Drawing.Size(346, 28);
            this.CB_ProductType.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Màu sắc";
            // 
            // CB_ProductColor
            // 
            this.CB_ProductColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ProductColor.FormattingEnabled = true;
            this.CB_ProductColor.Items.AddRange(new object[] {
            "Trắng",
            "Nâu cà phê",
            "Ghi xám",
            "Đen",
            "Vân gỗ"});
            this.CB_ProductColor.Location = new System.Drawing.Point(608, 57);
            this.CB_ProductColor.Name = "CB_ProductColor";
            this.CB_ProductColor.Size = new System.Drawing.Size(243, 28);
            this.CB_ProductColor.TabIndex = 27;
            // 
            // Btn_FilterList
            // 
            this.Btn_FilterList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_FilterList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_FilterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FilterList.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_FilterList.Location = new System.Drawing.Point(863, 54);
            this.Btn_FilterList.Name = "Btn_FilterList";
            this.Btn_FilterList.Size = new System.Drawing.Size(180, 34);
            this.Btn_FilterList.TabIndex = 28;
            this.Btn_FilterList.Text = "Xem danh sách";
            this.Btn_FilterList.UseVisualStyleBackColor = false;
            this.Btn_FilterList.Click += new System.EventHandler(this.Btn_FilterList_Click);
            // 
            // Btn_Reload
            // 
            this.Btn_Reload.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reload.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_Reload.Location = new System.Drawing.Point(1055, 54);
            this.Btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(116, 34);
            this.Btn_Reload.TabIndex = 35;
            this.Btn_Reload.Text = "Làm mới";
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.Btn_Reload_Click);
            // 
            // DGV_ProductsContant
            // 
            this.DGV_ProductsContant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ProductsContant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ProductsContant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ProductsContant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ProductsContant.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_ProductsContant.Location = new System.Drawing.Point(12, 183);
            this.DGV_ProductsContant.Name = "DGV_ProductsContant";
            this.DGV_ProductsContant.RowHeadersWidth = 50;
            this.DGV_ProductsContant.Size = new System.Drawing.Size(1160, 290);
            this.DGV_ProductsContant.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mã sản phẩm";
            // 
            // Txt_Masp
            // 
            this.Txt_Masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Masp.Location = new System.Drawing.Point(157, 106);
            this.Txt_Masp.Name = "Txt_Masp";
            this.Txt_Masp.Size = new System.Drawing.Size(346, 26);
            this.Txt_Masp.TabIndex = 33;
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_search.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_search.Location = new System.Drawing.Point(519, 102);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(116, 34);
            this.Btn_search.TabIndex = 34;
            this.Btn_search.Text = "Tìm kiếm";
            this.Btn_search.UseVisualStyleBackColor = false;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.Txt_Masp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV_ProductsContant);
            this.Controls.Add(this.Btn_Reload);
            this.Controls.Add(this.Btn_FilterList);
            this.Controls.Add(this.CB_ProductColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_ProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_out);
            this.Name = "QuanLyKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProductsContant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_ProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_FilterList;
        private System.Windows.Forms.Button Btn_Reload;
        private System.Windows.Forms.ComboBox CB_ProductColor;
        private System.Windows.Forms.DataGridView DGV_ProductsContant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Masp;
        private System.Windows.Forms.Button Btn_search;
    }
}