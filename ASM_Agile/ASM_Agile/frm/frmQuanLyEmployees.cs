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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM_Agile.frm
{
	public partial class frmQuanLyEmployees : Form
	{
		private QuanLyNhanVienService sv;
		public frmQuanLyEmployees()
		{
			InitializeComponent();
			sv = new QuanLyNhanVienService();
			LoadGrid();
			LoadCBB();
		}
		private void LoadGrid()
		{
			string[] columnHeaders = { "Mã NV", "Họ Tên", "Tên Tài Khoản", "Mật Khẩu", "Email",
							   "Ngày Sinh", "Tên Quản Lý", "Địa Chỉ", "Số Điện Thoại", "Giới Tính" };
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}

			foreach (var item in sv.GetlstEmployees())
			{
				dtg_DanhSach.Rows.Add(item.EmployeeId, item.Name, item.Account,
										item.Pass, item.Email, item.Birtdate,
										sv.GetlstManagers().Where(a => a.ManagerId == item.ManagerId)
										.Select(a => $"{a.LastName} {a.FirstName}").FirstOrDefault(),
										item.Address, item.PhoneNumber, item.Gender);
			}
		}
		private void LoadCBB()
		{
			foreach (var item in sv.GetlstManagers())
			{
				cbbTenQuanLy.Items.Add($"{item.LastName}  {item.FirstName}");
			}
			cbbTenQuanLy.SelectedIndex = 0;
		}
		private void Clear()
		{
			txtMaNV.Clear();
			txtTenNhanVien.Clear();
			txtTaiKhoan.Clear();
			txtMatKhau.Clear();
			txtEmail.Clear();
			DTNgaySinh.Text = "";
			cbbTenQuanLy.Text = "";
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
			Employees employees = new Employees();
			if (dtg_DanhSach.SelectedRows.Count == 0 || dtg_DanhSach.SelectedRows[0].Cells[0].Value == null || string.IsNullOrEmpty(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString()))
			{
				MessageBox.Show("mã rồng Hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			employees.EmployeeId = int.Parse(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString()); ;
			employees.Name = txtTenNhanVien.Text;
			employees.Account = txtTaiKhoan.Text;
			employees.Pass = txtMatKhau.Text;
			employees.Email = txtEmail.Text;
			if (!IsValidEmail(txtEmail.Text))
			{
				MessageBox.Show("Email Không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			employees.Birtdate = DateTime.Parse(DTNgaySinh.Text);
			employees.ManagerId = sv.GetlstManagers().FirstOrDefault(a => $"{a.LastName}  {a.FirstName}" == cbbTenQuanLy.Text)?.ManagerId ?? 0;
			employees.Address = txtDiaChi.Text;
			employees.PhoneNumber = txtSDT.Text;
			if (!IsValidSDT(txtSDT.Text))
			{
				MessageBox.Show("SĐT Không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			employees.Gender = rdNam.Checked ? "Nam" : rdNu.Checked ? "Nữ" : "";
			MessageBox.Show(sv.Update(employees), "Thông Báo");
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
			Employees employees = new Employees();
			employees.EmployeeId = int.Parse(txtMaNV.Text);
			employees.Name = txtTenNhanVien.Text;
			employees.Account = txtTaiKhoan.Text;
			employees.Pass = txtMatKhau.Text;
			employees.Email = txtEmail.Text;
			if (!IsValidEmail(employees.Email))
			{
				MessageBox.Show("Email Không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			employees.Birtdate = DateTime.Parse(DTNgaySinh.Text.ToString());
			employees.ManagerId = sv.GetlstManagers().FirstOrDefault(a => $"{a.LastName}  {a.FirstName}" == cbbTenQuanLy.Text)?.ManagerId ?? 0;
			employees.Address = txtDiaChi.Text;
			employees.PhoneNumber = txtSDT.Text;
			if (!IsValidSDT(employees.PhoneNumber))
			{
				MessageBox.Show("SĐT Không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			employees.Gender = rdNam.Checked ? "Nam" : rdNu.Checked ? "Nữ" : "";
			MessageBox.Show(sv.Save(employees), "Thông Báo");
			Clear();
			LoadGrid();
		}
		private bool IsValidEmail(string email)
		{
			return Regex.IsMatch(email, @"^[_a-z0-9A-Z-]+(\.[_a-z0-9A-Z-]+)*@[a-z0-9A-Z-]+(\.[a-z0-9A-Z-]+)*(\.[a-zA-Z]{2,3})$");
		}
		private bool IsValidSDT(string sdt)
		{
			return Regex.IsMatch(sdt, @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b$");
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

		private void dtg_DanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0 && rowIndex < dtg_DanhSach.Rows.Count - 1)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.Rows[rowIndex];
				txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
				txtTenNhanVien.Text = selectedRow.Cells[1].Value.ToString();
				txtTaiKhoan.Text = selectedRow.Cells[2].Value.ToString();
				txtMatKhau.Text = selectedRow.Cells[3].Value.ToString();
				txtEmail.Text = selectedRow.Cells[4].Value.ToString();
				DTNgaySinh.Text = selectedRow.Cells[5].Value.ToString();
				cbbTenQuanLy.Text = selectedRow.Cells[6].Value.ToString();
				txtDiaChi.Text = selectedRow.Cells[7].Value.ToString();
				txtSDT.Text = selectedRow.Cells[8].Value.ToString();
				string gioiTinh = selectedRow.Cells[9].Value.ToString();
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
		private void LoadGrid(string Name)
		{
			string[] columnHeaders = { "Mã NV", "Họ Tên", "Tên Tài Khoản", "Mật Khẩu", "Email",
							   "Ngày Sinh", "Tên Quản Lý", "Địa Chỉ", "Số Điện Thoại", "Giới Tính" };
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}

			foreach (var item in sv.Seach(Name))
			{
				dtg_DanhSach.Rows.Add(item.EmployeeId, item.Name, item.Account,
										item.Pass, item.Email, item.Birtdate,
										sv.GetlstManagers().Where(a => a.ManagerId == item.ManagerId)
										.Select(a => $"{a.LastName} {a.FirstName}").FirstOrDefault(),
										item.Address, item.PhoneNumber, item.Gender);
			}
		}
		private void frmQuanLyEmployees_Load(object sender, EventArgs e)
		{

		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadGrid(txtSearch.Text.ToLower());
			TimKiem(txtSearch.Text.ToLower());
		}

		private void TimKiem(string Ten)
		{
			if (dtg_DanhSach.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.SelectedRows[0];
				txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
				txtTenNhanVien.Text = selectedRow.Cells[1].Value.ToString();
				txtTaiKhoan.Text = selectedRow.Cells[2].Value.ToString();
				txtMatKhau.Text = selectedRow.Cells[3].Value.ToString();
				txtEmail.Text = selectedRow.Cells[4].Value.ToString();
				DTNgaySinh.Text = selectedRow.Cells[5].Value.ToString();
				cbbTenQuanLy.Text = selectedRow.Cells[6].Value.ToString();
				txtDiaChi.Text = selectedRow.Cells[7].Value.ToString();
				txtSDT.Text = selectedRow.Cells[8].Value.ToString();
				string gioiTinh = selectedRow.Cells[9].Value.ToString();
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

		private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}
	}
}