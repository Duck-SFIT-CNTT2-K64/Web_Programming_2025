using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangLuuNiem.DanhMuc
{
    public partial class frmChatLieu : Form
    {
        public frmChatLieu()
        {
            InitializeComponent();
        }

        private bool isAdding = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
             txtMaChatLieu.Text = "";
            txtTenChatLieu.Text = "";
            txtMaChatLieu.Enabled = true;
            txtTenChatLieu.Enabled = true;
            txtMaChatLieu.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (/* kiểm tra có dòng nào được chọn */ false)
            {
                MessageBox.Show("Vui lòng chọn chất liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            // txtTenChatLieu.Enabled = true;
            // txtTenChatLieu.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (false)
            {
                MessageBox.Show("Vui lòng chọn chất liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chất liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtMaChatLieu.Text) || string.IsNullOrWhiteSpace(txtTenChatLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isAdding)
            {
                
            }
            else
            {
                
            }

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            // txtMaChatLieu.Enabled = false;
            // txtTenChatLieu.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            // txtMaChatLieu.Enabled = false;
            // txtTenChatLieu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
