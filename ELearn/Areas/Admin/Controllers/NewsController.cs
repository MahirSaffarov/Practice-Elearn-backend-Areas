using ELearn.Areas.Admin.ViewModels.News;
using ELearn.Areas.Admin.ViewModels.Slider;
using ELearn.Data;
using ELearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;
        public NewsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<NewsVM> newsList = new();

            IEnumerable<News> news = await _context.News.Include(m=>m.NewsImages).Include(m=>m.NewsAuthor).ToListAsync();

            foreach (News item in news)
            {
                NewsVM newsVM = new()
                {
                    Id = item.Id,
                    Image = item.NewsImages.FirstOrDefault().Image,
                    Title = item.Title,
                    Author = item.NewsAuthor.FullName,
                    Date = item.CreatedDate.ToString("dd/MM/yyyy")
                };
                newsList.Add(newsVM);
            }

            return View(newsList);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            News news = await _context.News.Include(m => m.NewsImages).Include(m => m.NewsAuthor).FirstOrDefaultAsync(m => m.Id == id);

            if (news == null) return NotFound();

            NewsDetailVM model = new()
            {
                Image = news.NewsImages.FirstOrDefault().Image,
                Title = news.Title,
                Author = news.NewsAuthor.FullName,
                Date = news.CreatedDate.ToString("dd/MM/yyyy")
            };

            return View(model);
        }
    }
}
