
using Level1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.DataLayer.NHibernateConfigurations
{

    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(List<Person> entity);
        System.Threading.Tasks.Task Delete(Person entity);
        IQueryable<Person> company { get; }
    }
}

