using ASM_Agile.DomainClass;
using ASM_Agile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace ASM_Agile.frm
{
	public partial class frmEmployeesQuanLyCustomers : Form
	{
		private QuanLyKhachHangService sv;

		public frmEmployeesQuanLyCustomers()
		{
			InitializeComponent();
			sv = new QuanLyKhachHangService();
			LoadGrid();
		}
		private void LoadGrid()
		{
			string[] columnHeaders = { "Mã KH", "Họ Tên", "Tên Tài Khoản", "Mật Khẩu", "Email",
							   "Ngày Sinh", "Địa Chỉ", "Số Điện Thoại", "Giới Tính" };
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}

			foreach (var item in sv.GetCustomers())
			{
				dtg_DanhSach.Rows.Add(item.CustomerId, item.Name, item.Account,
										item.Pass, item.Email, item.Birtdate,
										item.Address, item.PhoneNumber, item.Gender);
			}
		}

		private void dtg_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0 && rowIndex < dtg_DanhSach.Rows.Count - 1)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.Rows[rowIndex];
				txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
				txtTenKhachHang.Text = selectedRow.Cells[1].Value.ToString();
				txtTaiKhoan.Text = selectedRow.Cells[2].Value.ToString();
				txtMatKhau.Text = selectedRow.Cells[3].Value.ToString();
				txtEmail.Text = selectedRow.Cells[4].Value.ToString();
				DTNgaySinh.Text = selectedRow.Cells[5].Value.ToString();
				txtDiaChi.Text = selectedRow.Cells[6].Value.ToString();
				txtSDT.Text = selectedRow.Cells[7].Value.ToString();
				string gioiTinh = selectedRow.Cells[8].Value.ToString();
				if (gioiTinh == "Nam")
				{
					rdNam.Checked = true;
					rdNu.Checked = false;
				}
				else if (gioiTinh == "Nữ")
				{
					rdNam.Checked = false;
					rdNu.Checked = true;
				}
				else
				{
					rdNam.Checked = false;
					rdNu.Checked = false;
				}
			}
		}
		private void Clear()
		{
			txtTenKhachHang.Clear();
			txtMaKH.Clear();
			txtTaiKhoan.Clear();
			txtMatKhau.Clear();
			txtEmail.Clear();
			DTNgaySinh.Text = "";
			txtDiaChi.Clear();
			txtSDT.Clear();
			rdNam.Checked = false;
			rdNu.Checked = false;
			btnDelete.Enabled = true;
			btnEdit.Enabled = true;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Clear();
			btnDelete.Enabled = false;
			btnEdit.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Customers ct = new Customers();
			if (dtg_DanhSach.SelectedRows.Count == 0 || dtg_DanhSach.SelectedRows[0].Cells[0].Value == null || string.IsNullOrEmpty(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString()))
			{
				MessageBox.Show("mã rồng Hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ct.CustomerId = int.Parse(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString());
			
			ct.Name = txtTenKhachHang.Text;
			ct.Account = txtTaiKhoan.Text;
			ct.Pass = txtMatKhau.Text;
			ct.Email = txtEmail.Text;
			if (!IsValidEmail(ct.Email))
			{
				MessageBox.Show("Email không đúng định dạng");
				return;
			}
			ct.Birtdate = DateTime.Parse(DTNgaySinh.Text.ToString());
			ct.Address = txtDiaChi.Text;
			ct.PhoneNumber = txtSDT.Text;
			if (!IsValidSDT(ct.PhoneNumber))
			{
				MessageBox.Show("SĐT không đúng định dạng");
				return;
			}
			ct.Gender = rdNam.Checked ? "Nam" : rdNu.Checked ? "Nữ" : "";
			if (string.IsNullOrEmpty(ct.Name) || string.IsNullOrEmpty(ct.Account) || string.IsNullOrEmpty(ct.Pass) 
				|| string.IsNullOrEmpty(ct.Email) || string.IsNullOrEmpty(ct.Address)|| string.IsNullOrEmpty(ct.PhoneNumber))
			{
				MessageBox.Show("Không được bỏ trống các trường dữ liệu");
				return;
			}
			MessageBox.Show(sv.Update(ct), "Thông Báo");
			Clear();
			LoadGrid();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dtg_DanhSach.SelectedRows.Count == 0 || dtg_DanhSach.SelectedRows[0].Cells[0].Value == null || string.IsNullOrEmpty(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString()))
			{
				MessageBox.Show("mã rồng Hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int ID = int.Parse(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString());
			MessageBox.Show(sv.Delete(ID), "Thông Báo");
			LoadGrid();
			Clear();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Customers ct = new Customers();
			if (dtg_DanhSach.SelectedRows.Count == 0 || dtg_DanhSach.SelectedRows[0].Cells[0].Value == null || string.IsNullOrEmpty(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString()))
			{
				MessageBox.Show("mã rồng Hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ct.CustomerId = int.Parse(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString());
			ct.Name = txtTenKhachHang.Text;
			ct.Account = txtTaiKhoan.Text;
			ct.Pass = txtMatKhau.Text;
			ct.Email = txtEmail.Text;
			if (!IsValidEmail(ct.Email))
			{
				MessageBox.Show("Email không đúng định dạng");
				return;
			}
			ct.Birtdate = DateTime.Parse(DTNgaySinh.Text.ToString());
			ct.Address = txtDiaChi.Text;
			ct.PhoneNumber = txtSDT.Text;
			if (!IsValidSDT(ct.PhoneNumber))
			{
				MessageBox.Show("SĐT không đúng định dạng");
				return;
			}
			ct.Gender = rdNam.Checked ? "Nam" : rdNu.Checked ? "Nữ" : "";
			if (string.IsNullOrEmpty(ct.Name) || string.IsNullOrEmpty(ct.Account) || string.IsNullOrEmpty(ct.Pass)
				|| string.IsNullOrEmpty(ct.Email) || string.IsNullOrEmpty(ct.Address) || string.IsNullOrEmpty(ct.PhoneNumber))
			{
				MessageBox.Show("Không được bỏ trống các trường dữ liệu");
				return;
			}
			MessageBox.Show(sv.Save(ct), "Thông Báo");
			Clear();
			LoadGrid();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnExits_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmMenuManagers form = new frmMenuManagers();
			form.ShowDialog();
			Application.Exit();

		}
		private void LoadGrid(string Name)
		{
			string[] columnHeaders = { "Mã KH", "Họ Tên", "Tên TK", "Mật Khẩu", "Email",
							   "Ngày Sinh", "Địa Chỉ", "Số ĐT", "Giới Tính" };
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}

			foreach (var item in sv.Search(Name))
			{
				dtg_DanhSach.Rows.Add(item.CustomerId, item.Name ,item.Account,
										item.Pass, item.Email, item.Birtdate,
										item.Address, item.PhoneNumber, item.Gender);
			}
		}
		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			LoadGrid(txtSearch.Text.ToLower());
			TimKiem(txtSearch.Text.ToLower());
		}
		private void TimKiem(string Ten)
		{
			if (dtg_DanhSach.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.SelectedRows[0];
				txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
				txtTenKhachHang.Text = selectedRow.Cells[1].Value.ToString();
				txtTaiKhoan.Text = selectedRow.Cells[2].Value.ToString();
				txtMatKhau.Text = selectedRow.Cells[3].Value.ToString();
				txtEmail.Text = selectedRow.Cells[4].Value.ToString();
				DTNgaySinh.Text = selectedRow.Cells[5].Value.ToString();
				txtDiaChi.Text = selectedRow.Cells[6].Value.ToString();
				txtSDT.Text = selectedRow.Cells[7].Value.ToString();
				string gioiTinh = selectedRow.Cells[8].Value.ToString();
				if (gioiTinh == "Nam")
				{
					rdNam.Checked = true;
					rdNu.Checked = false;
				}
				else if (gioiTinh == "Nữ")
				{
					rdNam.Checked = false;
					rdNu.Checked = true;
				}
				else
				{
					rdNam.Checked = false;
					rdNu.Checked = false;
				}
			}
		}

		private void txtSDT_TextChanged(object sender, EventArgs e)
		{

		}
		private bool IsValidEmail(string email)
		{
			return Regex.IsMatch(email, @"^[_a-z0-9A-Z-]+(\.[_a-z0-9A-Z-]+)*@[a-z0-9A-Z-]+(\.[a-z0-9A-Z-]+)*(\.[a-zA-Z]{2,3})$");
		}
		private bool IsValidSDT(string sdt)
		{
			return Regex.IsMatch(sdt, @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b$");
		}

		private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}
	}
}
