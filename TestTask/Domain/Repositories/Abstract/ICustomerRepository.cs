using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Domain.Entities;

namespace TestTask.Domain.Repositories.Abstract
{
    interface ICustomerRepository
    {
        IQueryable<Customer> GetCustomerInfo();
        Customer GetCostomerById(int id);
        void SaveCustomerInfo(Customer entity);
    }
}
