using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Navbar
{
    public class NavbarList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
