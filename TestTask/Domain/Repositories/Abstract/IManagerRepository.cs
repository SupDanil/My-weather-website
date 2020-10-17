using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Domain.Entities;

namespace TestTask.Domain.Repositories.Abstract
{
    interface IManagerRepository
    {
        IQueryable<Manager> GetManagerInfo();
        Manager GetManagerById(int id);
        void SaveManagerInfo(Manager entity);
    }
}
