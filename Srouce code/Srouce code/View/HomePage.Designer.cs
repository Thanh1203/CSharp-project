namespace Srouce_code.View
{
    partial class HomePage
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
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuanLyHangHoa = new System.Windows.Forms.Button();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btnQuanLyDoanhThu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.Silver;
            this.iconUser.FlatAppearance.BorderSize = 0;
            this.iconUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUser.IconColor = System.Drawing.Color.Black;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 300;
            this.iconUser.Location = new System.Drawing.Point(37, 38);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(296, 308);
            this.iconUser.TabIndex = 0;
            this.iconUser.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // btnQuanLyHangHoa
            // 
            this.btnQuanLyHangHoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuanLyHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyHangHoa.FlatAppearance.BorderSize = 0;
            this.btnQuanLyHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHangHoa.Location = new System.Drawing.Point(404, 70);
            this.btnQuanLyHangHoa.Name = "btnQuanLyHangHoa";
            this.btnQuanLyHangHoa.Size = new System.Drawing.Size(314, 51);
            this.btnQuanLyHangHoa.TabIndex = 2;
            this.btnQuanLyHangHoa.Text = "QUẢN LÝ HÀNG HÓA";
            this.btnQuanLyHangHoa.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuanLyKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(404, 167);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(314, 50);
            this.btnQuanLyKhachHang.TabIndex = 3;
            this.btnQuanLyKhachHang.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyDoanhThu
            // 
            this.btnQuanLyDoanhThu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuanLyDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDoanhThu.Location = new System.Drawing.Point(404, 263);
            this.btnQuanLyDoanhThu.Name = "btnQuanLyDoanhThu";
            this.btnQuanLyDoanhThu.Size = new System.Drawing.Size(314, 50);
            this.btnQuanLyDoanhThu.TabIndex = 4;
            this.btnQuanLyDoanhThu.Text = "QUẢN LÝ DOANH THU";
            this.btnQuanLyDoanhThu.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(288, 389);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(203, 51);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(757, 477);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnQuanLyDoanhThu);
            this.Controls.Add(this.btnQuanLyKhachHang);
            this.Controls.Add(this.btnQuanLyHangHoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconUser);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuanLyHangHoa;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private System.Windows.Forms.Button btnQuanLyDoanhThu;
        private System.Windows.Forms.Button btnLogOut;
    }
}