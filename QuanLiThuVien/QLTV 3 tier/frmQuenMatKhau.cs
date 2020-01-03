using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLTV
{
    public partial class frmQuenMatKhau : MetroForm
    {
        private frmMain parentForm;
        private DTO.DangNhap_DTO user;
        public frmQuenMatKhau(frmMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        public void receivingData(DangNhap_DTO user)
        {
            this.user = user;
        }
        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text != "" && txtMaResetMK.Text != "")
            {
                if (txtMaResetMK.Text == "123")
                {
                    try
                    {
                        BUS_OBJ.taoMoiTKNV(txtTenDN.Text, "1");
                        MetroFramework.MetroMessageBox.Show(this, "Tên đăng nhập không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenDN.Focus();
                    }
                    catch (Exception)
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Đặt lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUS_OBJ.doiMK(txtTenDN.Text, "1");
                        this.Close();
                    }
                    finally
                    {
                        //if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Mã đặt lại mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (txtMaResetMK.Text == "") txtMaResetMK.Focus();
                }
               
                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtTenDN.Text == "") txtTenDN.Focus();

            }
        }

        private void frmQuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Opacity = 1;
            this.parentForm.showInfo();
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaResetMK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
