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
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(txtMaSach.Text);
            lv.SubItems.Add(txtTenSach.Text);
            lv.SubItems.Add(txtTenTacGia.Text);
            lv.SubItems.Add(txtTenNhaXuatBan.Text);
            lv.SubItems.Add(txtNamXuatBan.Text);
            lv.SubItems.Add(txtNgonNgu.Text);

            lstView.Items.Add(lv);
        }

        private void txtTenNhaXuatBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                ListViewItem lv = lstView.SelectedItems[0];
                string MaSach = lv.SubItems[0].Text;
                string TenSach = lv.SubItems[1].Text;
                string TenTacGia = lv.SubItems[2].Text;
                string TenNhaXuatBan = lv.SubItems[3].Text;
                string NamXuatBan = lv.SubItems[4].Text;
                string NgonNgu = lv.SubItems[5].Text;

                txtMaSach.Text = MaSach;
                txtTenSach.Text = TenSach;
                txtTenTacGia.Text = TenTacGia;
                txtTenNhaXuatBan.Text = TenNhaXuatBan;
                txtNamXuatBan.Text = NamXuatBan;
                txtNgonNgu.Text = NgonNgu;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                lstView.Items.RemoveAt(lstView.SelectedItems[0].Index);
            }
        }
    }
}
