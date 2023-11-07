namespace Srouce_code.View
{
    partial class QuanLyKhachHang
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.Btn_out = new System.Windows.Forms.Button();
            this.lb_phonenumber = new System.Windows.Forms.Label();
            this.Txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_CustomerInformation = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.Btn_ResetData = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.Txt_CustomerName = new System.Windows.Forms.TextBox();
            this.lb_Fullname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerInformation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Black;
            this.lb_Title.Location = new System.Drawing.Point(11, 60);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(362, 33);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_out
            // 
            this.Btn_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_out.BackColor = System.Drawing.Color.Red;
            this.Btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_out.ForeColor = System.Drawing.Color.White;
            this.Btn_out.Location = new System.Drawing.Point(11, 516);
            this.Btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_out.Name = "Btn_out";
            this.Btn_out.Size = new System.Drawing.Size(116, 34);
            this.Btn_out.TabIndex = 20;
            this.Btn_out.Text = "Thoát";
            this.Btn_out.UseVisualStyleBackColor = false;
            this.Btn_out.Click += new System.EventHandler(this.Btn_out_Click);
            // 
            // lb_phonenumber
            // 
            this.lb_phonenumber.AutoSize = true;
            this.lb_phonenumber.BackColor = System.Drawing.Color.Transparent;
            this.lb_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phonenumber.Location = new System.Drawing.Point(12, 129);
            this.lb_phonenumber.Name = "lb_phonenumber";
            this.lb_phonenumber.Size = new System.Drawing.Size(151, 25);
            this.lb_phonenumber.TabIndex = 21;
            this.lb_phonenumber.Text = "Số điện thoại";
            // 
            // Txt_PhoneNumber
            // 
            this.Txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PhoneNumber.Location = new System.Drawing.Point(209, 127);
            this.Txt_PhoneNumber.Name = "Txt_PhoneNumber";
            this.Txt_PhoneNumber.Size = new System.Drawing.Size(291, 29);
            this.Txt_PhoneNumber.TabIndex = 24;
            this.Txt_PhoneNumber.TextChanged += new System.EventHandler(this.Txt_PhoneNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(518, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Danh sách khách hàng";
            // 
            // Dgv_CustomerInformation
            // 
            this.Dgv_CustomerInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_CustomerInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_CustomerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CustomerInformation.Location = new System.Drawing.Point(523, 129);
            this.Dgv_CustomerInformation.Name = "Dgv_CustomerInformation";
            this.Dgv_CustomerInformation.Size = new System.Drawing.Size(649, 421);
            this.Dgv_CustomerInformation.TabIndex = 23;
            this.Dgv_CustomerInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CustomerInformation_CellContentClick);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(17, 309);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(281, 34);
            this.Btn_Update.TabIndex = 28;
            this.Btn_Update.Text = "Sửa thông tin khách hàng";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_DeleteCustomer
            // 
            this.Btn_DeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.Btn_DeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DeleteCustomer.Enabled = false;
            this.Btn_DeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_DeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteCustomer.Location = new System.Drawing.Point(17, 309);
            this.Btn_DeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DeleteCustomer.Name = "Btn_DeleteCustomer";
            this.Btn_DeleteCustomer.Size = new System.Drawing.Size(281, 34);
            this.Btn_DeleteCustomer.TabIndex = 29;
            this.Btn_DeleteCustomer.Text = "Xóa Thông tin khách hàng";
            this.Btn_DeleteCustomer.UseVisualStyleBackColor = false;
            this.Btn_DeleteCustomer.Visible = false;
            this.Btn_DeleteCustomer.Click += new System.EventHandler(this.Btn_DeleteCustomer_Click);
            // 
            // Btn_ResetData
            // 
            this.Btn_ResetData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_ResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ResetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetData.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_ResetData.Location = new System.Drawing.Point(384, 309);
            this.Btn_ResetData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ResetData.Name = "Btn_ResetData";
            this.Btn_ResetData.Size = new System.Drawing.Size(116, 34);
            this.Btn_ResetData.TabIndex = 30;
            this.Btn_ResetData.Text = "Làm mới";
            this.Btn_ResetData.UseVisualStyleBackColor = false;
            this.Btn_ResetData.Click += new System.EventHandler(this.Btn_ResetData_Click);
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.ForeColor = System.Drawing.Color.Red;
            this.lb_message.Location = new System.Drawing.Point(206, 159);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(35, 13);
            this.lb_message.TabIndex = 31;
            this.lb_message.Text = "label6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUpdateCustomer,
            this.MenuDeleteCustomer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 33);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuUpdateCustomer
            // 
            this.MenuUpdateCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUpdateCustomer.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuUpdateCustomer.Name = "MenuUpdateCustomer";
            this.MenuUpdateCustomer.Size = new System.Drawing.Size(244, 29);
            this.MenuUpdateCustomer.Text = "Sửa thông tin khách hàng";
            this.MenuUpdateCustomer.Click += new System.EventHandler(this.MenuUpdateCustomer_Click);
            // 
            // MenuDeleteCustomer
            // 
            this.MenuDeleteCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDeleteCustomer.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuDeleteCustomer.Name = "MenuDeleteCustomer";
            this.MenuDeleteCustomer.Size = new System.Drawing.Size(161, 29);
            this.MenuDeleteCustomer.Text = "Xóa khách hàng";
            this.MenuDeleteCustomer.Click += new System.EventHandler(this.MenuDeleteCustomer_Click);
            // 
            // Txt_CustomerAddress
            // 
            this.Txt_CustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CustomerAddress.Location = new System.Drawing.Point(209, 245);
            this.Txt_CustomerAddress.Name = "Txt_CustomerAddress";
            this.Txt_CustomerAddress.Size = new System.Drawing.Size(291, 29);
            this.Txt_CustomerAddress.TabIndex = 26;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.BackColor = System.Drawing.Color.Transparent;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(12, 247);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(85, 25);
            this.lb_Address.TabIndex = 23;
            this.lb_Address.Text = "Địa chỉ";
            // 
            // Txt_CustomerName
            // 
            this.Txt_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CustomerName.Location = new System.Drawing.Point(209, 186);
            this.Txt_CustomerName.Name = "Txt_CustomerName";
            this.Txt_CustomerName.Size = new System.Drawing.Size(291, 29);
            this.Txt_CustomerName.TabIndex = 25;
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.BackColor = System.Drawing.Color.Transparent;
            this.lb_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fullname.Location = new System.Drawing.Point(12, 188);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(113, 25);
            this.lb_Fullname.TabIndex = 22;
            this.lb_Fullname.Text = "Họ và tên";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.Btn_ResetData);
            this.Controls.Add(this.Btn_DeleteCustomer);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Dgv_CustomerInformation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_CustomerAddress);
            this.Controls.Add(this.Txt_CustomerName);
            this.Controls.Add(this.Txt_PhoneNumber);
            this.Controls.Add(this.Btn_out);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lb_Fullname);
            this.Controls.Add(this.lb_phonenumber);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerInformation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button Btn_out;
        private System.Windows.Forms.Label lb_phonenumber;
        private System.Windows.Forms.TextBox Txt_PhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_CustomerInformation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_DeleteCustomer;
        private System.Windows.Forms.Button Btn_ResetData;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteCustomer;
        private System.Windows.Forms.TextBox Txt_CustomerAddress;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox Txt_CustomerName;
        private System.Windows.Forms.Label lb_Fullname;
    }
}