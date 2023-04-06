using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Services
{
    public class EmployeeServices
    {
       public static object GetAll()
        {
            return EmployeeRepo.GetAll();
        }
        public static Employee Get(int id)
        {
            return EmployeeRepo.Get(id);
        }
        public static bool Create(Employee e)
        {
            return EmployeeRepo.Create(e);
        }
        public static bool Update(Employee e)
        {
            return EmployeeRepo.Update(e);
        }
        public static bool Delete(int id)
        {
            return EmployeeRepo.Delete(id);
        }
    }
}
