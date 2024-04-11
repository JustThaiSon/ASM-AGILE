using ASM_Agile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_Agile.frm
{
	public partial class frmDangNhapManagers : Form
	{
		private Account acc;
		public frmDangNhapManagers()
		{
			InitializeComponent();
			acc = new Account();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string TaiKhoan = txtTaiKhoan.Text;
			string matKhau = txtMatKhau.Text;
			if (CheckAccountManagers(TaiKhoan, matKhau))
			{
				MessageBox.Show("Đăng Nhập Thành Công!!!");
				this.Hide();
				frmMenuManagers form = new frmMenuManagers();
				form.ShowDialog();
				Application.Exit();

			}
			else
			{
				MessageBox.Show("Đăng Nhập Thất Bại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private bool CheckAccountManagers(string username, string password)
		{
			return acc.CheckTaiKhoanCanBo(username, password);
		}

		private void btnExits_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form = new Form1();
			form.ShowDialog();
			Application.Exit();
		}
	}
}
