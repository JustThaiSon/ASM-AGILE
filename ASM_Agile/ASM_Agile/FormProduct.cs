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
	public partial class FormProduct : Form
	{
		private QuanLySanPhamService sv;
		public FormProduct()
		{
			InitializeComponent();
			sv = new QuanLySanPhamService();
			An();
			LoadGrid();
		}
		private void An()
		{
			btnDelete.Enabled = false;
			btnEdit.Enabled = false;
			btnExit.Enabled = false;
			btnNew.Enabled = false;
			btnReset.Enabled = false;
			btnSave.Enabled = false;
		}
		private void LoadGrid()
		{
			string[] columnHeaders = { "PhoneID", "Tên Sản Phẩm", "Tên Brand", "Tên Nhà Sản Xuất", "Số Lượng",
							   "Giá"};
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}
			foreach (var item in sv.GetPhones())
			{
				dtg_DanhSach.Rows.Add(item.PhoneId, item.Model, sv.GetBrands().Where(a => a.BrandId == item.BrandId).Select(a => a.BrandName).FirstOrDefault(),
					sv.GetNhaSanXuat().Where(a => a.NhaSanXuatId == item.NhaSanXuatId).Select(a => a.TenNhaSanXuat).FirstOrDefault(), item.StockQuantity, item.Price);
			}
		}
		private void LoadGrid(string name)
		{
			string[] columnHeaders = { "PhoneID", "Tên Sản Phẩm", "Tên Brand", "Tên Nhà Sản Xuất", "Số Lượng",
							   "Giá"};
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}
			foreach (var item in sv.Seach(name))
			{
				dtg_DanhSach.Rows.Add(item.PhoneId, item.Model, sv.GetBrands().Where(a => a.BrandId == item.BrandId).Select(a => a.BrandName).FirstOrDefault(),
					sv.GetNhaSanXuat().Where(a => a.NhaSanXuatId == item.NhaSanXuatId).Select(a => a.TenNhaSanXuat).FirstOrDefault(), item.StockQuantity, item.Price);
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadGrid(txtSearch.Text);
		}

		private void dtg_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int Index = e.RowIndex;
			if (Index >= 0 && Index < dtg_DanhSach.Rows.Count - 1)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.Rows[Index];
				txtPhoneID.Text = selectedRow.Cells[0].Value.ToString();
				txtTenSanPham.Text = selectedRow.Cells[1].Value.ToString();
				txtSoLuong.Text = selectedRow.Cells[4].Value.ToString();
				txtGia.Text = selectedRow.Cells[5].Value.ToString();
				cbbNhaSanXuat.Text = selectedRow.Cells[3].Value.ToString();
				cbbTenBrand.Text = selectedRow.Cells[2].Value.ToString();
			}
		}
	}
}
