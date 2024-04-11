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
	public partial class frmMenuManagers : Form
	{
		public frmMenuManagers()
		{
			InitializeComponent();
		}

		private void btnProDuct_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmQuanLyProduct ql = new frmQuanLyProduct();
			MessageBox.Show("Quản Lý ProDuct");
			ql.ShowDialog();
			Application.Exit();
		}

		private void btnEmployees_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmQuanLyEmployees quanLyNhanVien = new frmQuanLyEmployees();
			MessageBox.Show("Quản Lý Nhân Viên");
			quanLyNhanVien.ShowDialog();
			Application.Exit();
		}

		private void btnCustomers_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmQuanLyEmployees quanLyNhanVien = new frmQuanLyEmployees();
			MessageBox.Show("Quản Lý Khách Hàng");
			quanLyNhanVien.ShowDialog();
			Application.Exit();
		}

		private void btnExits_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmDangNhapManagers form = new frmDangNhapManagers();
			form.ShowDialog();
			Application.Exit();
		}
	}
}
