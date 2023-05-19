using ELearn.Areas.Admin.ViewModels.Event;
using ELearn.Areas.Admin.ViewModels.Slider;
using ELearn.Data;
using ELearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<EventVM> eventList = new();

            IEnumerable<Event> events = await _context.Events.ToListAsync();

            foreach (Event item in events)
            { 
                EventVM model = new()
                {
                    Id = item.Id,
                    Description = item.Description,
                    Title = item.Title,
                    Date = item.CreatedDate.ToString("dd/MM/yyyy")
                };
                eventList.Add(model);
            }

            return View(eventList);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            Event events = await _context.Events.FirstOrDefaultAsync(m => m.Id == id);

            if (events == null) return NotFound();

            EventDetailVM model = new()
            {
                Description = events.Description,
                Title = events.Title,
                Date = events.CreatedDate.ToString("dd/MM/yyyy")
            };

            return View(model);
        }
    }
}
