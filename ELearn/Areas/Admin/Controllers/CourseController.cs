using ELearn.Areas.Admin.ViewModels.Course;
using ELearn.Data;
using ELearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<CourseVM> courseList = new();
            IEnumerable<Course> courses = await _context.Courses.Include(m=>m.Author).Include(m=>m.CourseImages).ToListAsync();

            foreach (var course in courses)
            {
                CourseVM courseVM = new()
                {
                    Id = course.Id,
                    Description = course.Description,
                    Title = course.Title,
                    Date = course.CreatedDate.ToString("dd/MMMM/yyyy"),
                    Author = course.Author.Name,
                    Image = course.CourseImages.FirstOrDefault().Image
                };
                courseList.Add(courseVM);
            }
            
            return View(courseList);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Course course = await _context.Courses.Include(m => m.Author).Include(m => m.CourseImages).FirstOrDefaultAsync(m=>m.Id == id);
            if (course == null) return NotFound();

            CourseDetailVM courseDetailVM = new() 
            {
                Description = course.Description,
                Title = course.Title,
                Date = course.CreatedDate.ToString("dd/MMMM/yyyy"),
                Author = course.Author.Name,
                Image = course.CourseImages.FirstOrDefault().Image
            };
            return View(courseDetailVM);
        }
    }
}
