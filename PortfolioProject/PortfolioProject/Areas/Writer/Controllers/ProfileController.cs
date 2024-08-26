using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]

    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            return View(model);
        }
        //[HttpPost]
        //public async Task<IActionResult> Index(UserEditViewModel userInfo)
        //{
        //    //var user = await userManager.FindByNameAsync(User.Identity.Name);
        //    //if (userInfo.Picture != null)
        //    //{
        //    //    var resource = Directory.GetCurrentDirectory();
        //    //    var extension = Path.GetExtension(userInfo.Picture.FileName);
        //    //    var imageName = Guid.NewGuid() + extension;
        //    //    var saveLocation = resource + "/wwwroot/userimage/" + imageName;
        //    //    var stream = new FileStream(saveLocation, FileMode.Create);
        //    //    await userInfo.Picture.CopyToAsync(stream);
        //    //    user.ImageUrl = imageName;
        //    //}


        //    //user.Name = userInfo.Name;
        //    //user.Surname = userInfo.Surname;
        //    //if(userInfo.Password != null && userInfo.PasswordConfirm != null)
        //    //    user.PasswordHash = userManager.PasswordHasher.HashPassword(user, userInfo.Password);

        //    //var result = await userManager.UpdateAsync(user);

        //    //if (result.Succeeded)
        //    //{
        //    //    return RedirectToAction("Index","Login");
        //    //}

        //    //return View();

        //    if (!ModelState.IsValid)
        //    {
        //        // Model geçersizse, formu tekrar göster
        //        return View(userInfo);
        //    }

        //    var user = await userManager.FindByNameAsync(User.Identity.Name);
        //    if (userInfo.Picture != null && userInfo.Password != null && userInfo.PasswordConfirm != null)
        //    {
        //        var resource = Directory.GetCurrentDirectory();
        //        var extension = Path.GetExtension(userInfo.Picture.FileName);
        //        var imageName = Guid.NewGuid() + extension;
        //        var saveLocation = resource + "/wwwroot/userimage/" + imageName;
        //        var stream = new FileStream(saveLocation, FileMode.Create);
        //        await userInfo.Picture.CopyToAsync(stream);
        //        user.ImageUrl = imageName;

        //    user.Name = userInfo.Name;
        //    user.Surname = userInfo.Surname;

        //        user.PasswordHash = userManager.PasswordHasher.HashPassword(user, userInfo.Password);

        //    var result = await userManager.UpdateAsync(user);

        //    if (result.Succeeded)
        //    {
        //        return RedirectToAction("Index", "Login");
        //    }
        //    }





        //}

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userInfo)
        {
            if (!ModelState.IsValid)
            {
                // Model geçersizse, formu tekrar göster
                return View(userInfo);
            }

            var user = await userManager.FindByNameAsync(User.Identity.Name);

            if (userInfo.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userInfo.Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userInfo.Picture.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }

            user.Name = userInfo.Name;
            user.Surname = userInfo.Surname;

            if (userInfo.Password != null && userInfo.PasswordConfirm != null)
            {
                user.PasswordHash = userManager.PasswordHasher.HashPassword(user, userInfo.Password);
            }

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return Redirect("/Writer/Dashboard/Index");
            }

            // Hata durumunda modelin yeniden görüntülenmesini sağla
            ModelState.AddModelError(string.Empty, "Güncelleme işlemi başarısız oldu.");
            return View(userInfo);
        }

    }
}
