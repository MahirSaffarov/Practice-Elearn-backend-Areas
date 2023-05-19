using ELearn.Models;

namespace ELearn.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Milestone> Milestones { get; set; }
        public IEnumerable<Choose> Chooses { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<News> News { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
