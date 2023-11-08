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
            this.doanhThuThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuNămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuQuýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
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
            this.Btn_out.Location = new System.Drawing.Point(11, 615);
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
            this.doanhThuThángToolStripMenuItem,
            this.doanhThuQuýToolStripMenuItem,
            this.doanhThuNămToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doanhThuThángToolStripMenuItem
            // 
            this.doanhThuThángToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhThuThángToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.doanhThuThángToolStripMenuItem.Name = "doanhThuThángToolStripMenuItem";
            this.doanhThuThángToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.doanhThuThángToolStripMenuItem.Text = "Doanh thu tháng";
            // 
            // doanhThuNămToolStripMenuItem
            // 
            this.doanhThuNămToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhThuNămToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.doanhThuNămToolStripMenuItem.Name = "doanhThuNămToolStripMenuItem";
            this.doanhThuNămToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.doanhThuNămToolStripMenuItem.Text = "Doanh thu năm";
            // 
            // doanhThuQuýToolStripMenuItem
            // 
            this.doanhThuQuýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhThuQuýToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.doanhThuQuýToolStripMenuItem.Name = "doanhThuQuýToolStripMenuItem";
            this.doanhThuQuýToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.doanhThuQuýToolStripMenuItem.Text = "Doanh thu quý";
            // 
            // QuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Btn_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyDoanhThu";
            this.Text = "QuanLyDoanhThu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_out;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doanhThuThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuQuýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuNămToolStripMenuItem;
    }
}