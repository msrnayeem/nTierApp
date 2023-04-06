using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        static EmpContext db;
        static EmployeeRepo()
        {
            db = new EmpContext();
        }
        public static List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }
        public static Employee Get(int id)
        {
            return db.Employees.Find(id);
        }
        public static bool Create(Employee e)
        {
            db.Employees.Add(e);
            var res = db.SaveChanges() > 0;
            if (res)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Update(Employee e)
        {
            var exEmp = Get(e.Id);
            db.Entry(exEmp).CurrentValues.SetValues(e);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            var exEmp = Get(id);
            db.Employees.Remove(exEmp);
            return db.SaveChanges() > 0;
        }
    }
}
