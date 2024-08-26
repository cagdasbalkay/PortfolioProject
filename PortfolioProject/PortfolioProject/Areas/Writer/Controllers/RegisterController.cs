using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userInfos)
        {
            if (userInfos.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userInfos.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userInfos.Image.CopyToAsync(stream);
                //user.ImageUrl = imageName;



                WriterUser w = new WriterUser()
                {
                    Name = userInfos.Name,
                    Surname = userInfos.Surname,
                    Email = userInfos.Mail,
                    UserName = userInfos.UserName,
                    ImageUrl = imageName
                    //ImageUrl = userInfos.Image
                };



                if (userInfos.Password == userInfos.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(w, userInfos.Password);



                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }

                }
            }
                return View(userInfos);

            }
        
    }
}

