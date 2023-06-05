using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLayer
{
    public class ClassBLL
    {
        public Learn_DBEntities _context;
        public ClassBLL()
        {
            _context = new Learn_DBEntities();
        }
        public List<Employee> namesDetail()
        {
            return _context.Employees.ToList();
        }
        public void addEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}
