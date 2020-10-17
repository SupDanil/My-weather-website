using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Domain.Entities;

namespace TestTask.Domain.Repositories.Abstract
{
    interface IDeviceRepository
    {
        IQueryable<Device> GetDeviceInfo();
        Device GetDeviceById(int id);
        void SaveDeviceInfo(Device entity);
    }
}
