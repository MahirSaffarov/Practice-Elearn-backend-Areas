using ELearn.Areas.Admin.ViewModels.Milestone;
using ELearn.Data;
using ELearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MilestoneController : Controller
    {
        private readonly AppDbContext _context;
        public MilestoneController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<MilestoneVM> milestoneList = new();

            IEnumerable<Milestone> milestones = await _context.Milestones.ToListAsync();

            foreach (var milestone in milestones)
            {
                MilestoneVM model = new() 
                {
                    Id = milestone.Id,
                    Count = milestone.Count,
                    Date = milestone.CreatedDate.ToString("dd/MMMM/yyyy"),
                    Title = milestone.Title
                };
                milestoneList.Add(model);
            }
            return View(milestoneList);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Milestone milestone = await _context.Milestones.FirstOrDefaultAsync(x => x.Id == id);

            if (milestone is null) return NotFound();

            MilestoneDetailVM model = new()
            {
                Count = milestone.Count,
                Date = milestone.CreatedDate.ToString("dd/MMMM/yyyy"),
                Title = milestone.Title
            };

            return View(model);
        }
    }
}
