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

namespace ASM_Agile
{
	public partial class FormNhanVienKH : Form
	{
		private QuanLyKhachHangService sv;
		public FormNhanVienKH()
		{
			InitializeComponent();
			sv = new QuanLyKhachHangService();
			LoadGrid();
			An();
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
				dtg_DanhSach.Rows.Add(item.CustomerId, item.Name, item.Account,
										item.Pass, item.Email, item.Birtdate,
										item.Address, item.PhoneNumber, item.Gender);
			}
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

		private void An()
		{
			btnDelete.Enabled = false;
			btnEdit.Enabled = false;
			btnExits.Enabled = false;
			btnNew.Enabled = false;
			btnReset.Enabled = false;
			btnSave.Enabled = false;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadGrid(txtSearch.Text);
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
	}
}
