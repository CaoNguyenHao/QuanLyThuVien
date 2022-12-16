using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_Quan_Ly_Thu_Vien
{
    public partial class Dangnhaphethong : Form
    {
        public Dangnhaphethong()
        {
            InitializeComponent();
        }

        private void Dangnhaphethong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Click(object sender, EventArgs e)
        {
            FormChuongTrinh f = new FormChuongTrinh();
            f.Show();
            this.Hide();
        }
    }
}
