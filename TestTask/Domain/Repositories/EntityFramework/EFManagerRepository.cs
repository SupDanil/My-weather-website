using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Domain.Entities;
using TestTask.Domain.Repositories.Abstract;

namespace TestTask.Domain.Repositories.EntityFramework
{
    public class EFManagerRepository : IManagerRepository
    {
        private readonly AppDbContext context;
        public EFManagerRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Manager GetManagerById(int id)
        {
            return context.Managers.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Manager> GetManagerInfo()
        {
            return context.Managers;
        }

        public void SaveManagerInfo(Manager entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
    
    
}
