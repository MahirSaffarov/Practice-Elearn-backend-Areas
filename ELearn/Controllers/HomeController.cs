using ELearn.Data;
using ELearn.Models;
using ELearn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ELearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();
            IEnumerable<Milestone> milestones = await _context.Milestones.ToListAsync();
            IEnumerable<Choose> chooses = await _context.Chooses.ToListAsync();
            IEnumerable<Event> events = await _context.Events.ToListAsync();    
            IEnumerable<News> news = await _context.News.Include(m=>m.NewsAuthor).Include(m=>m.NewsImages).ToListAsync();
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.CourseImages).Include(m => m.Author).OrderByDescending(m => m.CreatedDate).ToListAsync();

            HomeVM homeVM = new()
            { 
                Sliders = sliders,
                Milestones = milestones,
                Chooses = chooses,
                Events = events,
                News = news,
                Courses = courses
            };
            return View(homeVM);
        }
    }
}