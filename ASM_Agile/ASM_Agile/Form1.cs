using ASM_Agile.frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_Agile
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnManagers_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đăng Nhập Tài Khoản Manager !!!");
			frmDangNhapManagers dn = new frmDangNhapManagers();
			this.Hide();
			dn.ShowDialog();
			Application.Exit();
		}

		private void btnEmployees_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đăng Nhập Tài Khoản Employees !!!");
			frmDangNhapEmployees dn = new frmDangNhapEmployees();
			this.Hide();
			dn.ShowDialog();
			Application.Exit();
		}

		private void btnExits_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("bạn Có Muốn Thoát Không", "Thông Báo Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				MessageBox.Show("Bạn Thoát Thành Công!", "Thoát Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
			}
			else
			{
				MessageBox.Show("Quay Lại Chương Trình", "Quay Lại Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
