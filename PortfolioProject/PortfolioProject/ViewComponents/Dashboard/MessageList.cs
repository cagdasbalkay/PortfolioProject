using BusinessLayer.Concrete;
using Core_Proje.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserManager<WriterUser> userManager;
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public MessageList(UserManager<WriterUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Context context = new();
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            var list = (from x in context.Users
                        join y in context.Messages
                        on x.Email equals y.Mail
                        select new UserImageMessageModel
                        {
                            ImageUrl = x.ImageUrl,
                            Date = y.Date,
                            SenderName = y.Name,
                            MessageContent = y.Content,
                            Id = y.MessageID
                        }).OrderByDescending(x => x.Id).Take(5).ToList();

            return View(list);
        }

        //public IViewComponentResult Invoke()
        //{
        //    var values = messageManager.TGetList().Take(5).ToList();
        //    return View(values);
        //}

    }
}
