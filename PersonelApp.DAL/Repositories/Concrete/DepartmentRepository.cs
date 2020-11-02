using PersonelApp.DAL.Repositories.Abstract;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonelContext context) : base(context)
        {

        }
        public IEnumerable<Department> GetDepartmentsWithPersonel()
        {
            return PersonelContext.Departments.Include("Personel").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonelContext.Departments.Take(count);
        }

        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
