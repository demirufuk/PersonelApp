using PersonelApp.DAL;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());

            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "IT",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "Finans",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            unitOfWork.Complete();
        }
    }
}
