namespace Srouce_code.View
{
    partial class NhapHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_message = new System.Windows.Forms.Label();
            this.BtnLamMoi = new System.Windows.Forms.Button();
            this.lbAdminid = new System.Windows.Forms.Label();
            this.Btn_Insert_Receipt = new System.Windows.Forms.Button();
            this.dateTimeNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.Txt_IdProduct = new System.Windows.Forms.TextBox();
            this.Txt_Volume = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_out = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_Receipt_List = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt_List)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lb_message);
            this.groupBox1.Controls.Add(this.BtnLamMoi);
            this.groupBox1.Controls.Add(this.lbAdminid);
            this.groupBox1.Controls.Add(this.Btn_Insert_Receipt);
            this.groupBox1.Controls.Add(this.dateTimeNgayNhap);
            this.groupBox1.Controls.Add(this.Txt_IdProduct);
            this.groupBox1.Controls.Add(this.Txt_Volume);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(462, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_message.Location = new System.Drawing.Point(183, 161);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(64, 16);
            this.lb_message.TabIndex = 17;
            this.lb_message.Text = "message";
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLamMoi.ForeColor = System.Drawing.Color.White;
            this.BtnLamMoi.Location = new System.Drawing.Point(339, 318);
            this.BtnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamMoi.Name = "BtnLamMoi";
            this.BtnLamMoi.Size = new System.Drawing.Size(119, 35);
            this.BtnLamMoi.TabIndex = 3;
            this.BtnLamMoi.Text = "Làm mới";
            this.BtnLamMoi.UseVisualStyleBackColor = false;
            this.BtnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // lbAdminid
            // 
            this.lbAdminid.AutoSize = true;
            this.lbAdminid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminid.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbAdminid.Location = new System.Drawing.Point(178, 26);
            this.lbAdminid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminid.Name = "lbAdminid";
            this.lbAdminid.Size = new System.Drawing.Size(154, 25);
            this.lbAdminid.TabIndex = 16;
            this.lbAdminid.Text = "Mã nhân viên";
            // 
            // Btn_Insert_Receipt
            // 
            this.Btn_Insert_Receipt.BackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Insert_Receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Insert_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Insert_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Insert_Receipt.ForeColor = System.Drawing.Color.White;
            this.Btn_Insert_Receipt.Location = new System.Drawing.Point(9, 318);
            this.Btn_Insert_Receipt.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Insert_Receipt.Name = "Btn_Insert_Receipt";
            this.Btn_Insert_Receipt.Size = new System.Drawing.Size(185, 35);
            this.Btn_Insert_Receipt.TabIndex = 0;
            this.Btn_Insert_Receipt.Text = "Nhập hàng";
            this.Btn_Insert_Receipt.UseVisualStyleBackColor = false;
            this.Btn_Insert_Receipt.Click += new System.EventHandler(this.Btn_Insert_Receipt_Click);
            // 
            // dateTimeNgayNhap
            // 
            this.dateTimeNgayNhap.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimeNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayNhap.Location = new System.Drawing.Point(183, 73);
            this.dateTimeNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeNgayNhap.Name = "dateTimeNgayNhap";
            this.dateTimeNgayNhap.Size = new System.Drawing.Size(275, 29);
            this.dateTimeNgayNhap.TabIndex = 15;
            // 
            // Txt_IdProduct
            // 
            this.Txt_IdProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdProduct.Location = new System.Drawing.Point(183, 126);
            this.Txt_IdProduct.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_IdProduct.Name = "Txt_IdProduct";
            this.Txt_IdProduct.Size = new System.Drawing.Size(275, 29);
            this.Txt_IdProduct.TabIndex = 14;
            this.Txt_IdProduct.TextChanged += new System.EventHandler(this.Txt_MaSp_TextChanged);
            // 
            // Txt_Volume
            // 
            this.Txt_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Volume.Location = new System.Drawing.Point(185, 188);
            this.Txt_Volume.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Volume.Name = "Txt_Volume";
            this.Txt_Volume.Size = new System.Drawing.Size(275, 29);
            this.Txt_Volume.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(4, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Khối lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // Btn_out
            // 
            this.Btn_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_out.BackColor = System.Drawing.Color.Red;
            this.Btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_out.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_out.Location = new System.Drawing.Point(11, 615);
            this.Btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_out.Name = "Btn_out";
            this.Btn_out.Size = new System.Drawing.Size(119, 35);
            this.Btn_out.TabIndex = 4;
            this.Btn_out.Text = "Thoát";
            this.Btn_out.UseVisualStyleBackColor = false;
            this.Btn_out.Click += new System.EventHandler(this.Btn_out_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.DGV_Receipt_List);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(507, 144);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(766, 467);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu nhập";
            // 
            // DGV_Receipt_List
            // 
            this.DGV_Receipt_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Receipt_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Receipt_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Receipt_List.Location = new System.Drawing.Point(2, 21);
            this.DGV_Receipt_List.Name = "DGV_Receipt_List";
            this.DGV_Receipt_List.Size = new System.Drawing.Size(762, 444);
            this.DGV_Receipt_List.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(512, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(756, 84);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin sản phẩm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(634, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(442, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(237, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Khối lượng ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Màu sắc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên sản phẩm";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Btn_out);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhapHang";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Receipt_List)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeNgayNhap;
        private System.Windows.Forms.TextBox Txt_IdProduct;
        private System.Windows.Forms.TextBox Txt_Volume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_out;
        private System.Windows.Forms.Button BtnLamMoi;
        private System.Windows.Forms.Button Btn_Insert_Receipt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Receipt_List;
        private System.Windows.Forms.Label lbAdminid;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}