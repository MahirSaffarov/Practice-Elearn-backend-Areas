using ELearn.Areas.Admin.ViewModels.Choose;
using ELearn.Areas.Admin.ViewModels.Slider;
using ELearn.Data;
using ELearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ChooseController : Controller
    {
        private readonly AppDbContext _context;
        public ChooseController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ChooseVM> chooseList = new();

            IEnumerable<Choose> chooses = await _context.Chooses.ToListAsync();

            foreach (Choose choose in chooses)
            {
                ChooseVM chooseVM = new()
                {
                    Id = choose.Id,
                    Description = choose.Description,
                    Title = choose.Title,
                    Date = choose.CreatedDate.ToString("dd/MM/yyyy")
                };
                chooseList.Add(chooseVM);
            }

            return View(chooseList);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            Choose choose = await _context.Chooses.FirstOrDefaultAsync(m => m.Id == id);

            if (choose == null) return NotFound();

            ChooseDetailVM model = new()
            {
                Description = choose.Description,
                Title = choose.Title,
                Date = choose.CreatedDate.ToString("dd/MM/yyyy")
            };

            return View(model);
        }
    }
}
