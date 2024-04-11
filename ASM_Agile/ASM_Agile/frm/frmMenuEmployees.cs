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
	public partial class frmMenuEmployees : Form
	{
		public frmMenuEmployees()
		{
			InitializeComponent();
		}

		private void btnExits_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmDangNhapManagers form = new frmDangNhapManagers();
			form.ShowDialog();
			Application.Exit();
		}

		private void btnCustomers_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormNhanVienKH quanLyNhanVien = new FormNhanVienKH();
			MessageBox.Show("Quản Lý Nhân Viên");
			quanLyNhanVien.ShowDialog();
			Application.Exit();
		}

		private void btnProDuct_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormProduct ql = new FormProduct();
			MessageBox.Show("Quản Lý ProDuct");
			ql.ShowDialog();
			Application.Exit();
		}
	}
}
