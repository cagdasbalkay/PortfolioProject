using BusinessLayer.Abstact;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IGenericService<Service>
    {
        IServiceDal serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }

        public void TAdd(Service t)
        {
            serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            serviceDal.Delete(t);
        }

        public Service TGetById(int id)
        {
           return serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return serviceDal.GetList();
        }

        public List<Service> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            serviceDal.Update(t);
        }
    }
}
