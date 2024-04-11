using ASM_Agile.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Agile.Service
{
	 class Account
	{
		private DBContext _dbContext;
		public Account()
		{
			_dbContext = new DBContext();
		}

		public bool CheckTaiKhoanCanBo(string TaiKhoan, string MatKhau)
		{
			var Exists = _dbContext.Managers.Any(a => a.Account == TaiKhoan && a.Pass == MatKhau);
			return Exists;
		}
		public bool CheckTaiKhoanNhanVien(string TaiKhoan, string MatKhau)
		{
			var Exists = _dbContext.Employees.Any(a => a.Account == TaiKhoan && a.Pass == MatKhau);
			return Exists;
		}
		public bool CheckTaiKhoanKhachHang(string TaiKhoan, string MatKhau)
		{
			var Exists = _dbContext.Customers.Any(a => a.Account == TaiKhoan && a.Pass == MatKhau);
			return Exists;
		}
	}
}
