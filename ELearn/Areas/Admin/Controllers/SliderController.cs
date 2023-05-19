using ELearn.Areas.Admin.ViewModels.Slider;
using ELearn.Data;
using ELearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<SliderVM> sliderList = new();

            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();

            foreach (Slider slider in sliders)
            {
                SliderVM sliderVM = new()
                {
                    Id = slider.Id,
                    Image = slider.Image,
                    Description = slider.Description,
                    Title = slider.Title,
                    Date = slider.CreatedDate.ToString("dd/MM/yyyy")
                };
                sliderList.Add(sliderVM);
            }

            return View(sliderList);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            Slider slider = await _context.Sliders.FirstOrDefaultAsync(m=>m.Id == id);

            if (slider == null) return NotFound();

            SliderDetailVM model = new()
            {
                Image = slider.Image,
                Description = slider.Description,
                Title = slider.Title,
                Date = slider.CreatedDate.ToString("dd/MM/yyyy")
            };

            return View(model);
        }
    }
}
