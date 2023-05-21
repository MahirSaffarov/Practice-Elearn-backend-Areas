using Microsoft.AspNetCore.Mvc;
using SessionStorage.Models;
using SessionStorage.ViewModels;
using System.Text.Json;


namespace SessionStorage.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginVM model)
        {
            List<User> dbUser = GetAll();

            var findUserByEmail = dbUser.FirstOrDefault(m => m.Email == model.Email);
            
            if (findUserByEmail == null)
            {
                ViewBag.error = "Email or password is wrong";
                return View();
            }

            if(findUserByEmail.Password != model.Password)
            {
                ViewBag.error = "Email or password is wrong";
                return View();
            }

            HttpContext.Session.SetString("user", JsonSerializer.Serialize(findUserByEmail));

            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        private List<User> GetAll()
        {
            User user1 = new User() 
            {
                Id = 1,
                UserName = "resul123",
                Email = "resul@gmail.com",
                Password = "Resul123_"
            };
            User user2 = new User()
            {
                Id = 2,
                UserName = "gultac123",
                Email = "gultac@gmail.com",
                Password = "Gultac123_"
            };
            User user3 = new User()
            {
                Id = 3,
                UserName = "novreste123",
                Email = "novreste@gmail.com",
                Password = "Novreste123_"
            };

            List<User> users = new() { user1, user2, user3 };

            return users;
        } 
    }
    
}
