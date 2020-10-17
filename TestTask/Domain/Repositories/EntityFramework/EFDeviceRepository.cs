using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Domain.Entities;
using TestTask.Domain.Repositories.Abstract;

namespace TestTask.Domain.Repositories.EntityFramework
{
    public class EFDeviceRepository : IDeviceRepository
    {
        private readonly AppDbContext context;
        public EFDeviceRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Device GetDeviceById(int id)
        {
            return context.Devices.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Device> GetDeviceInfo()
        {
            return context.Devices;
        }

        public void SaveDeviceInfo(Device entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    

    }
}
