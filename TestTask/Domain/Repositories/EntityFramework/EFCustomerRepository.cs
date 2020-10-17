using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Domain.Entities;
using TestTask.Domain.Repositories.Abstract;

namespace TestTask.Domain.Repositories.EntityFramework
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;
        public EFCustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Customer GetCostomerById(int id)
        {
            return context.Customers.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Customer> GetCustomerInfo()
        {
            return context.Customers;
        }

        public void SaveCustomerInfo(Customer entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
