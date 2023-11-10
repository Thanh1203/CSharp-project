namespace Srouce_code.View
{
    partial class LoaiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuInsertTypeProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdateTypeProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteTypeProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_idtypeproduct = new System.Windows.Forms.TextBox();
            this.Txt_nameproduct = new System.Windows.Forms.TextBox();
            this.Btn_out = new System.Windows.Forms.Button();
            this.Btn_inset = new System.Windows.Forms.Button();
            this.Btn_update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Type = new System.Windows.Forms.DataGridView();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_reload = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Type)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInsertTypeProduct,
            this.MenuUpdateTypeProduct,
            this.MenuDeleteTypeProduct});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuInsertTypeProduct
            // 
            this.MenuInsertTypeProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuInsertTypeProduct.Name = "MenuInsertTypeProduct";
            this.MenuInsertTypeProduct.Size = new System.Drawing.Size(194, 29);
            this.MenuInsertTypeProduct.Text = "Thêm loại sản phẩm";
            this.MenuInsertTypeProduct.Click += new System.EventHandler(this.MenuInsertTypeProduct_Click);
            // 
            // MenuUpdateTypeProduct
            // 
            this.MenuUpdateTypeProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuUpdateTypeProduct.Name = "MenuUpdateTypeProduct";
            this.MenuUpdateTypeProduct.Size = new System.Drawing.Size(178, 29);
            this.MenuUpdateTypeProduct.Text = "Sửa loại sản phẩm";
            this.MenuUpdateTypeProduct.Click += new System.EventHandler(this.MenuUpdateTypeProduct_Click);
            // 
            // MenuDeleteTypeProduct
            // 
            this.MenuDeleteTypeProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuDeleteTypeProduct.Name = "MenuDeleteTypeProduct";
            this.MenuDeleteTypeProduct.Size = new System.Drawing.Size(179, 29);
            this.MenuDeleteTypeProduct.Text = "Xóa loại sản phẩm";
            this.MenuDeleteTypeProduct.Click += new System.EventHandler(this.MenuDeleteTypeProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin loại sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // Txt_idtypeproduct
            // 
            this.Txt_idtypeproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idtypeproduct.Location = new System.Drawing.Point(293, 100);
            this.Txt_idtypeproduct.Name = "Txt_idtypeproduct";
            this.Txt_idtypeproduct.Size = new System.Drawing.Size(257, 29);
            this.Txt_idtypeproduct.TabIndex = 4;
            // 
            // Txt_nameproduct
            // 
            this.Txt_nameproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nameproduct.Location = new System.Drawing.Point(293, 153);
            this.Txt_nameproduct.Name = "Txt_nameproduct";
            this.Txt_nameproduct.Size = new System.Drawing.Size(257, 29);
            this.Txt_nameproduct.TabIndex = 5;
            // 
            // Btn_out
            // 
            this.Btn_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_out.BackColor = System.Drawing.Color.Red;
            this.Btn_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_out.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_out.Location = new System.Drawing.Point(11, 735);
            this.Btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_out.Name = "Btn_out";
            this.Btn_out.Size = new System.Drawing.Size(119, 35);
            this.Btn_out.TabIndex = 16;
            this.Btn_out.Text = "Thoát";
            this.Btn_out.UseVisualStyleBackColor = false;
            this.Btn_out.Click += new System.EventHandler(this.Btn_out_Click);
            // 
            // Btn_inset
            // 
            this.Btn_inset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_inset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_inset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_inset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_inset.Location = new System.Drawing.Point(635, 97);
            this.Btn_inset.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_inset.Name = "Btn_inset";
            this.Btn_inset.Size = new System.Drawing.Size(167, 35);
            this.Btn_inset.TabIndex = 17;
            this.Btn_inset.Text = "Thêm mới";
            this.Btn_inset.UseVisualStyleBackColor = false;
            this.Btn_inset.Click += new System.EventHandler(this.Btn_inset_Click);
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_update.Location = new System.Drawing.Point(667, 97);
            this.Btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(103, 35);
            this.Btn_update.TabIndex = 18;
            this.Btn_update.Text = "Sửa";
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Type);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 515);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // DGV_Type
            // 
            this.DGV_Type.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Type.Location = new System.Drawing.Point(6, 25);
            this.DGV_Type.Name = "DGV_Type";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Type.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Type.Size = new System.Drawing.Size(1148, 484);
            this.DGV_Type.TabIndex = 0;
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.Red;
            this.Btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_delete.Location = new System.Drawing.Point(667, 97);
            this.Btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(103, 35);
            this.Btn_delete.TabIndex = 20;
            this.Btn_delete.Text = "Xóa";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_reload
            // 
            this.Btn_reload.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_reload.Location = new System.Drawing.Point(862, 97);
            this.Btn_reload.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_reload.Name = "Btn_reload";
            this.Btn_reload.Size = new System.Drawing.Size(134, 35);
            this.Btn_reload.TabIndex = 21;
            this.Btn_reload.Text = "Làm mới";
            this.Btn_reload.UseVisualStyleBackColor = false;
            this.Btn_reload.Click += new System.EventHandler(this.Btn_reload_Click);
            // 
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 781);
            this.Controls.Add(this.Btn_reload);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.Btn_inset);
            this.Controls.Add(this.Btn_out);
            this.Controls.Add(this.Txt_nameproduct);
            this.Controls.Add(this.Txt_idtypeproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoaiSanPham";
            this.Load += new System.EventHandler(this.LoaiSanPham_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuInsertTypeProduct;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdateTypeProduct;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteTypeProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_idtypeproduct;
        private System.Windows.Forms.TextBox Txt_nameproduct;
        private System.Windows.Forms.Button Btn_out;
        private System.Windows.Forms.Button Btn_inset;
        private System.Windows.Forms.Button Btn_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Type;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button Btn_reload;
    }
}