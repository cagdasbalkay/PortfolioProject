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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            this.socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia t)
        {
            socialMediaDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            socialMediaDal.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return socialMediaDal.GetById(id);
        }

        public List<SocialMedia> TGetList()
        {
            return socialMediaDal.GetList();    
        }

        public List<SocialMedia> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            socialMediaDal.Update(t);
        }
    }
}
