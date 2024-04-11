using ASM_Agile.Context;
using ASM_Agile.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Agile.Service
{
	class QuanLySanPhamService
	{
		private readonly DBContext dbContext;
		private List<Phones> phones;
		private readonly List<Brands> brands;
		private readonly List<NhaSanXuat> nhaSanXuat;

		public QuanLySanPhamService()
		{
			dbContext = new DBContext();
			brands = dbContext.Brands.ToList();
			nhaSanXuat = dbContext.NhaSanXuat.ToList();
			GetPhonesDB();
		}

		public void GetPhonesDB()
		{
			phones = dbContext.Phones.ToList();
		}

		public List<Phones> GetPhones()
		{
			return phones;
		}

		public List<Brands> GetBrands()
		{
			return brands;
		}

		public List<NhaSanXuat> GetNhaSanXuat()
		{
			return nhaSanXuat;
		}

		public string Delete(int id)
		{
			try
			{
				var phoneToDelete = dbContext.Phones
					.Include(p => p.PhoneCategories)
					.Include(p => p.PhoneCustomers)
					.Include(p => p.PhoneEmployees)
					.FirstOrDefault(p => p.PhoneId == id);

				if (phoneToDelete != null)
				{
					var orderDetailsToDelete = dbContext.OrderDetails.Where(od => od.PhoneId == id);
					dbContext.OrderDetails.RemoveRange(orderDetailsToDelete);

					var ordersToDelete = dbContext.Orders.Where(o => o.OrderDetails.Any(od => od.PhoneId == id));
					dbContext.Orders.RemoveRange(ordersToDelete);

					dbContext.PhoneCategories.RemoveRange(phoneToDelete.PhoneCategories);

					dbContext.PhoneCustomers.RemoveRange(phoneToDelete.PhoneCustomers);

					dbContext.PhoneEmployees.RemoveRange(phoneToDelete.PhoneEmployees);

					dbContext.Phones.Remove(phoneToDelete);
					dbContext.SaveChanges();
					GetPhonesDB();

					return "Xóa Thành Công";
				}
				else
				{
					return $"Không Tìm Thấy ID {id}";
				}
			}
			catch (Exception ex)
			{
				return "Lỗi Khi Xóa: " + ex.Message;
			}
		}


		public string Save(Phones phone)
		{
			try
			{
				var Exists = phones.Any(p => p.PhoneId == phone.PhoneId);
				if (!Exists)
				{
					dbContext.Phones.Add(phone);
					dbContext.SaveChanges();
					GetPhonesDB();
					return "Save Thành Công";
				}
				else
				{
					return "ID Đã Tồn Tại ";

				}

			}
			catch (Exception ex)
			{
				return "Save  Thất Bại" + ex.Message;

			}
		}

		public string Update(Phones phone)
		{
			var existingPhone = dbContext.Phones.FirstOrDefault(p => p.PhoneId == phone.PhoneId);
			if (existingPhone != null)
			{
				existingPhone.Model = phone.Model;
				existingPhone.Price = phone.Price;
				existingPhone.StockQuantity = phone.StockQuantity;
				existingPhone.BrandId = phone.BrandId;
				existingPhone.NhaSanXuatId = phone.NhaSanXuatId;
				dbContext.SaveChanges();
				GetPhonesDB();
				return "Update Thành Công!";
			}
			else
			{
				return "Không Tìm Thấy ID Cần Update";
			}
		}
		public List<Phones> Seach(string Name)
		{
			return phones.Where(x => x.Model.ToLower().StartsWith(Name)).ToList();
		}
	}
}
