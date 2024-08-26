﻿using BusinessLayer.Abstact;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            this.writerUserDal = writerUserDal;
        }

        public void TAdd(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public WriterUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetList()
        {
            return writerUserDal.GetList();
        }

        public List<WriterUser> TGetListByFilter()
        {
            return writerUserDal.GetList();
        }

        public void TUpdate(WriterUser t)
        {
            throw new NotImplementedException();
        }
    }
}
