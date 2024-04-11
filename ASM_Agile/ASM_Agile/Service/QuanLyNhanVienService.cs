using ASM_Agile.Context;
using ASM_Agile.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_Agile.Service
{
	class QuanLyNhanVienService
	{
		private DBContext _dbContext;
		private List<Employees> _lstEmployees;
		private List<Managers> _lstManagers;
		public QuanLyNhanVienService()
		{
			_dbContext = new DBContext();
			_lstEmployees = new List<Employees>();
			_lstManagers = _dbContext.Managers.ToList();
			GetEmployeesDB();
		}
		public List<Employees> GetlstEmployees()
		{
			return _lstEmployees;
		}
		public List<Managers> GetlstManagers()
		{
			return _lstManagers;
		}
		public void GetEmployeesDB()
		{
			_lstEmployees = _dbContext.Employees.ToList();
		}
		public string Save(Employees e)
		{
			try
			{
				var Exits = _dbContext.Employees.Any(x=>x.EmployeeId == e.EmployeeId);
				if (!Exits)
				{
					_dbContext.Add(e);
					_dbContext.SaveChanges();
					GetEmployeesDB();
					return "Lưu Thành Công";
				}
				else
				{
					return "Id đã Tồn tại";
				}
					
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return "Lưu Thất Bại";
			}
		}

		public string Update(Employees e)
		{
			try
			{
				var Exists = _dbContext.Employees.FirstOrDefault(a => a.EmployeeId == e.EmployeeId);
				if (Exists != null)
				{
					Exists.Name = e.Name;
					Exists.Email = e.Email;
					Exists.Birtdate = e.Birtdate;
					Exists.Account = e.Account;
					Exists.Pass = e.Pass;
					Exists.Address = e.Address;
					Exists.Gender = e.Gender;
					Exists.PhoneNumber = e.PhoneNumber;
					_dbContext.SaveChanges();
					GetEmployeesDB();
					return "Update Thành Công";
				}
				else
				{
					return "ID Không tồn tại";

				}
			}
			catch
			{
				return "Lỗi Khi update";
			}

		}
		public string Delete(int ID)
		{
			var Delete = _dbContext.Employees.FirstOrDefault(a => a.EmployeeId == ID);
			if (Delete != null)
			{
				_dbContext.Remove(Delete);
				_dbContext.SaveChanges();
				GetEmployeesDB();
			}
			return "Xóa Thành Công";
		}
		public List<Employees> Seach(string Name)
		{
			return _lstEmployees.Where(x => x.Name.ToLower().StartsWith(Name)).ToList();
		}
	}
}
