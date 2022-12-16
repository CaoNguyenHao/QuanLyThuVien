namespace He_Thong_Quan_Ly_Thu_Vien
{
    partial class Dangnhaphethong
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
            this.Thoat = new System.Windows.Forms.Button();
            this.Dangnhap = new System.Windows.Forms.Button();
            this.Hethongquanlythuvien = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(143, 233);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(99, 23);
            this.Thoat.TabIndex = 0;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dangnhap
            // 
            this.Dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dangnhap.Location = new System.Drawing.Point(307, 233);
            this.Dangnhap.Name = "Dangnhap";
            this.Dangnhap.Size = new System.Drawing.Size(99, 23);
            this.Dangnhap.TabIndex = 1;
            this.Dangnhap.Text = "Đăng nhập";
            this.Dangnhap.UseVisualStyleBackColor = true;
            this.Dangnhap.Click += new System.EventHandler(this.Dangnhap_Click);
            // 
            // Hethongquanlythuvien
            // 
            this.Hethongquanlythuvien.AutoSize = true;
            this.Hethongquanlythuvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hethongquanlythuvien.Location = new System.Drawing.Point(129, 37);
            this.Hethongquanlythuvien.Name = "Hethongquanlythuvien";
            this.Hethongquanlythuvien.Size = new System.Drawing.Size(310, 25);
            this.Hethongquanlythuvien.TabIndex = 2;
            this.Hethongquanlythuvien.Text = "Hệ Thống Quản Lý Thư Viện";
            this.Hethongquanlythuvien.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(140, 122);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 15);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(140, 168);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 15);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Dangnhaphethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 328);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Hethongquanlythuvien);
            this.Controls.Add(this.Dangnhap);
            this.Controls.Add(this.Thoat);
            this.Name = "Dangnhaphethong";
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.Dangnhaphethong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button Dangnhap;
        private System.Windows.Forms.Label Hethongquanlythuvien;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

