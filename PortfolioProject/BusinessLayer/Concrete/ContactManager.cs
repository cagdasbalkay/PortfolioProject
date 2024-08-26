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
    public class ContactManager : IContactService
    {
        IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public void TAdd(Contact t)
        {
            contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            contactDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return contactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return contactDal.GetList();
        }

        public List<Contact> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            contactDal.Update(t);
        }
    }
}
