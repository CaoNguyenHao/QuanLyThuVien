namespace He_Thong_Quan_Ly_Thu_Vien
{
    partial class FormChuongTrinh
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.lblTenNhaXuatban = new System.Windows.Forms.Label();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.lblNgonNgu = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.txtNgonNgu = new System.Windows.Forms.TextBox();
            this.txtTenNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.clnMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTenTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTenNhaXuatBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNamSanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNgonNgu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(517, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(106, 107);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(50, 13);
            this.lblMaSach.TabIndex = 9;
            this.lblMaSach.Text = "Mã Sách";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(106, 133);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(54, 13);
            this.lblTenSach.TabIndex = 10;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Location = new System.Drawing.Point(106, 165);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(67, 13);
            this.lblTenTacGia.TabIndex = 11;
            this.lblTenTacGia.Text = "Tên Tác Giả";
            // 
            // lblTenNhaXuatban
            // 
            this.lblTenNhaXuatban.AutoSize = true;
            this.lblTenNhaXuatban.Location = new System.Drawing.Point(106, 193);
            this.lblTenNhaXuatban.Name = "lblTenNhaXuatban";
            this.lblTenNhaXuatban.Size = new System.Drawing.Size(96, 13);
            this.lblTenNhaXuatban.TabIndex = 12;
            this.lblTenNhaXuatban.Text = "Tên Nhà Xuất Bản";
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Location = new System.Drawing.Point(106, 222);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(76, 13);
            this.lblNamXuatBan.TabIndex = 13;
            this.lblNamXuatBan.Text = "Năm Xuất Bản";
            // 
            // lblNgonNgu
            // 
            this.lblNgonNgu.AutoSize = true;
            this.lblNgonNgu.Location = new System.Drawing.Point(106, 256);
            this.lblNgonNgu.Name = "lblNgonNgu";
            this.lblNgonNgu.Size = new System.Drawing.Size(56, 13);
            this.lblNgonNgu.TabIndex = 14;
            this.lblNgonNgu.Text = "Ngôn Ngữ";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(230, 104);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(226, 20);
            this.txtMaSach.TabIndex = 15;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(230, 130);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(226, 20);
            this.txtTenSach.TabIndex = 16;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(230, 158);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(226, 20);
            this.txtTenTacGia.TabIndex = 17;
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Location = new System.Drawing.Point(230, 253);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(226, 20);
            this.txtNgonNgu.TabIndex = 19;
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(230, 190);
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(226, 20);
            this.txtTenNhaXuatBan.TabIndex = 20;
            this.txtTenNhaXuatBan.TextChanged += new System.EventHandler(this.txtTenNhaXuatBan_TextChanged);
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(230, 222);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(226, 20);
            this.txtNamXuatBan.TabIndex = 21;
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaSach,
            this.clnTenSach,
            this.clnTenTacGia,
            this.clnTenNhaXuatBan,
            this.clnNamSanXuat,
            this.clnNgonNgu});
            this.lstView.FullRowSelect = true;
            this.lstView.GridLines = true;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(12, 301);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(660, 194);
            this.lstView.TabIndex = 22;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // clnMaSach
            // 
            this.clnMaSach.Text = "Mã Sách";
            this.clnMaSach.Width = 75;
            // 
            // clnTenSach
            // 
            this.clnTenSach.Text = "Tên Sách";
            this.clnTenSach.Width = 175;
            // 
            // clnTenTacGia
            // 
            this.clnTenTacGia.Text = "Tên Tác Giả";
            this.clnTenTacGia.Width = 115;
            // 
            // clnTenNhaXuatBan
            // 
            this.clnTenNhaXuatBan.Text = "Nhà Xuất Bản";
            this.clnTenNhaXuatBan.Width = 100;
            // 
            // clnNamSanXuat
            // 
            this.clnNamSanXuat.Text = "Năm Sản Xuất";
            this.clnNamSanXuat.Width = 70;
            // 
            // clnNgonNgu
            // 
            this.clnNgonNgu.Text = "Ngôn Ngữ";
            this.clnNgonNgu.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Book List";
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.txtNamXuatBan);
            this.Controls.Add(this.txtTenNhaXuatBan);
            this.Controls.Add(this.txtNgonNgu);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lblNgonNgu);
            this.Controls.Add(this.lblNamXuatBan);
            this.Controls.Add(this.lblTenNhaXuatban);
            this.Controls.Add(this.lblTenTacGia);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormChuongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Thư Viện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.Label lblTenNhaXuatban;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.Label lblNgonNgu;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtNgonNgu;
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader clnMaSach;
        private System.Windows.Forms.ColumnHeader clnTenSach;
        private System.Windows.Forms.ColumnHeader clnTenTacGia;
        private System.Windows.Forms.ColumnHeader clnTenNhaXuatBan;
        private System.Windows.Forms.ColumnHeader clnNamSanXuat;
        private System.Windows.Forms.ColumnHeader clnNgonNgu;
        private System.Windows.Forms.Label label1;
    }
}