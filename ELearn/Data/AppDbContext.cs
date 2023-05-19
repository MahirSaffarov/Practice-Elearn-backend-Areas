using ELearn.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<CourseImage> CourseImages { get; set; }    
        public DbSet<Course>Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }
        public DbSet<NewsAuthor> NewsAuthors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Course>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<CourseImage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Choose>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Event>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Milestone>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<News>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<NewsAuthor>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<NewsImage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Author>().HasData(
               new Author
                {
                    Id = 1,
                    Name = "Mark Smith",
                },
               new Author
                 {
                     Id = 2,
                     Name = "James S. Morrison",
                     
                 },
               new Author
                 {
                     Id = 3,
                     Name = "Julia Williams",
                 }
                );


            modelBuilder.Entity<Course>().HasData(
               new Course
               {
                   Id= 1,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 1
               },
               new Course
               {
                   Id = 2,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 3
               },
               new Course
               {
                   Id = 3,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 2
               },
               new Course
               {
                   Id = 4,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 3
               },
               new Course
               {
                   Id = 5,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 2
               },
               new Course
               {
                   Id = 6,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 1
               },
               new Course
               {
                   Id = 7,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 3
               },
               new Course
               {
                   Id = 8,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 2
               },
               new Course
               {
                   Id = 9,
                   Title = "Online Literature Course",
                   Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                   Price = 35,
                   AuthorId = 1
               }
               );
            modelBuilder.Entity<CourseImage>().HasData(
              new CourseImage
              {
                  Id = 1,
                  IsMain = true,
                  Image = "course_1.jpg",
                  CourseId = 1,
              },
              new CourseImage
              {
                  Id = 2,
                  IsMain = true,
                  Image = "course_2.jpg",
                  CourseId = 2,
              },
              new CourseImage
              {
                  Id = 3,
                  IsMain = true,
                  Image = "course_3.jpg",
                  CourseId = 3,
              },
              new CourseImage
              {
                  Id = 4,
                  IsMain = true,
                  Image = "course_4.jpg",
                  CourseId = 4,
              },
              new CourseImage
              {
                  Id = 5,
                  IsMain = true,
                  Image = "course_5.jpg",
                  CourseId = 5,
              },
              new CourseImage
              {
                  Id = 6,
                  IsMain = true,
                  Image = "course_6.jpg",
                  CourseId = 6,
              },
              new CourseImage
              {
                  Id = 7,
                  IsMain = true,
                  Image = "course_7.jpg",
                  CourseId = 7,
              },
              new CourseImage
              {
                  Id = 8,
                  IsMain = true,
                  Image = "course_8.jpg",
                  CourseId = 8,
              },
              new CourseImage
              {
                  Id = 9,
                  IsMain = true,
                  Image = "course_9.jpg",
                  CourseId = 9,
              }
              );
            modelBuilder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 1,
                    Image = "index.jpg",
                    Logo = "logo.png",
                    Title = "Complete Online Courses",
                    Description = "Maecenas rutrum viverra sapien sed fermentum. Morbi tempor odio eget lacus tempus pulvinar. Praesent vel nisl fermentum, gravida augue ut, fermentum ipsum."
                }
                );
            modelBuilder.Entity<Milestone>().HasData(
                new Milestone
                {
                    Id= 1,
                    Logo = "milestone_1.svg",
                    Count = 1548,
                    Title = "online Course"
                },
                new Milestone
                {
                    Id = 2,
                    Logo = "milestone_2.svg",
                    Count = 7286,
                    Title = "Students"
                },
                new Milestone
                {
                    Id = 3,
                    Logo = "milestone_3.svg",
                    Count = 257,
                    Title = "Teachers"
                },
                new Milestone
                {
                    Id = 4,
                    Logo = "milestone_4.svg",
                    Count = 39,
                    Title = "Countries"
                }
                );
            modelBuilder.Entity<Choose>().HasData(
                new Choose
                {
                    Id = 1,
                    Title = "Mauris vehicula nisi congue ?",
                    Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam."
                },
                new Choose
                {
                    Id = 2,
                    Title = "Mauris vehicula nisi congue ?",
                    Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam."
                },
                new Choose
                {
                    Id = 3,
                    Title = "Mauris vehicula nisi congue ?",
                    Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam."
                },
                new Choose
                {
                    Id = 4,
                    Title = "Mauris vehicula nisi congue ?",
                    Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam."
                }
                );
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id= 1,
                    Title = "New Marketing Course Release",
                    Description = "Location: Online Platform"
                },
                new Event
                {
                    Id = 2,
                    Title = "Students Art Workshop",
                    Description = "Location: Online Platform"
                },
                new Event
                {
                    Id = 3,
                    Title = "Launch Party for a new Platform",
                    Description = "Location: Online Platform"
                },
                new Event
                {
                    Id = 4,
                    Title = "New Marketing Course",
                    Description = "Location: Online Platform"
                },
                new Event
                {
                    Id = 5,
                    Title = "New Marketing Course",
                    Description = "Location: Online Platform"
                }
                );
            modelBuilder.Entity<NewsAuthor>().HasData(
                new NewsAuthor
                {
                    Id = 1,
                    FullName = "Willam Smith"
                }
                );
            modelBuilder.Entity<News>().HasData(
                new News
                {
                    Id = 1,
                    Title = "Why Choose online education?",
                    NewsAuthorId = 1
                },
                new News
                {
                    Id = 2,
                    Title = "Books, Kindle or tablet?",
                    NewsAuthorId = 1
                },
                new News
                {
                    Id = 3,
                    Title = "Why Choose online education?",
                    NewsAuthorId = 1
                },
                new News
                {
                    Id = 4,
                    Title = "Books, Kindle or tablet?",
                    NewsAuthorId = 1
                }
                );
            modelBuilder.Entity<NewsImage>().HasData(
                new NewsImage
                {
                    Id = 1,
                    Image = "news_1.jpg",
                    NewsId = 1
                },
                new NewsImage
                {
                    Id = 2,
                    Image = "news_2.jpg",
                    NewsId = 2
                },
                new NewsImage
                {
                    Id = 3,
                    Image = "news_3.jpg",
                    NewsId = 3
                },
                new NewsImage
                {
                    Id = 4,
                    Image = "news_4.jpg",
                    NewsId = 4
                }
                );
        }
    }
}
