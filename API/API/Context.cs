using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "",
                Email = "admin@gmail.com",
                MobileNumber = "1234567890",
                AccountStatus = AccountStatus.ACTIVE,
                UserType = UserType.ADMIN,
                Password = "admin1999",
                CreatedOn = new DateTime(2023, 11, 01, 13, 28, 12)
            });

            modelBuilder.Entity<CarCategory>().HasData(
                new CarCategory { Id = 1, Category = "computer", SubCategory = "algorithm" },
                new CarCategory { Id = 2, Category = "computer", SubCategory = "programming languages" },
                new CarCategory { Id = 3, Category = "computer", SubCategory = "networking" },
                new CarCategory { Id = 4, Category = "computer", SubCategory = "hardware" },
                new CarCategory { Id = 5, Category = "mechanical", SubCategory = "machine" },
                new CarCategory { Id = 6, Category = "mechanical", SubCategory = "transfer of energy" },
                new CarCategory { Id = 7, Category = "mathematics", SubCategory = "calculus" },
                new CarCategory { Id = 8, Category = "mathematics", SubCategory = "algebra" });

            modelBuilder.Entity<Car>().HasData(
            new Car { Id = 1, CarCategoryId = 1, Ordered = false, Price = 100, Owner = "Thomas Corman", Name = "Introduction to Algorithm" },
            new Car { Id = 2, CarCategoryId = 1, Ordered = false, Price = 100, Owner = "Thomas Corman", Name = "Introduction to Algorithm" },
            new Car { Id = 3, CarCategoryId = 1, Ordered = false, Price = 200, Owner = "Robert Sedgewick & Kevin Wayne", Name = "Algorithms" },
            new Car { Id = 4, CarCategoryId = 1, Ordered = false, Price = 300, Owner = "Steve Skiena", Name = "The Algorithm Design Manual" },
            new Car { Id = 5, CarCategoryId = 1, Ordered = false, Price = 400, Owner = "Adnan Aziz", Name = "Algorithms For Interviews" },
            new Car { Id = 6, CarCategoryId = 1, Ordered = false, Price = 400, Owner = "Adnan Aziz", Name = "Algorithms For Interviews" },
            new Car { Id = 7, CarCategoryId = 1, Ordered = false, Price = 400, Owner = "Adnan Aziz", Name = "Algorithms For Interviews" },
            new Car { Id = 8, CarCategoryId = 1, Ordered = false, Price = 500, Owner = "George Heineman", Name = "Algorithm in Nutshell" },
            new Car { Id = 9, CarCategoryId = 1, Ordered = false, Price = 600, Owner = "Algorithm Design", Name = "Klienberg & Tardos" },

            new Car { Id = 10, CarCategoryId = 2, Ordered = false, Price = 700, Owner = "Eric Matthes", Name = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
            new Car { Id = 11, CarCategoryId = 2, Ordered = false, Price = 700, Owner = "Eric Matthes", Name = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
            new Car { Id = 12, CarCategoryId = 2, Ordered = false, Price = 700, Owner = "Eric Matthes", Name = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
            new Car { Id = 13, CarCategoryId = 2, Ordered = false, Price = 800, Owner = "Paul Barry", Name = "Head First Python: A Brain-Friendly Guide" },
            new Car { Id = 14, CarCategoryId = 2, Ordered = false, Price = 900, Owner = "Joshua Bloch", Name = "Effective Java" },
            new Car { Id = 15, CarCategoryId = 2, Ordered = false, Price = 900, Owner = "Joshua Bloch", Name = "Effective Java" },
            new Car { Id = 16, CarCategoryId = 2, Ordered = false, Price = 1000, Owner = "Kathy Sierra and Bert Bates", Name = "Head First Java" },
            new Car { Id = 17, CarCategoryId = 2, Ordered = false, Price = 1100, Owner = "Brian W. Kernighan, Dennis M. Ritchie", Name = "C Programming Language" },
            new Car { Id = 18, CarCategoryId = 2, Ordered = false, Price = 1100, Owner = "Brian W. Kernighan, Dennis M. Ritchie", Name = "C Programming Language" },
            new Car { Id = 19, CarCategoryId = 2, Ordered = false, Price = 1100, Owner = "Brian W. Kernighan, Dennis M. Ritchie", Name = "C Programming Language" },
            new Car { Id = 20, CarCategoryId = 2, Ordered = false, Price = 1200, Owner = "Marijn Haverbeke", Name = "Eloquent JavaScript: A Modern Introduction to Programming" },
            new Car { Id = 21, CarCategoryId = 2, Ordered = false, Price = 1300, Owner = "Donald E. Knuth", Name = "The Art of Computer Programming" },
            new Car { Id = 22, CarCategoryId = 2, Ordered = false, Price = 1300, Owner = "Donald E. Knuth", Name = "The Art of Computer Programming" },

            new Car { Id = 23, CarCategoryId = 3, Ordered = false, Price = 1400, Owner = "James F Kurose and Keith W Ross", Name = "A Top-Down Approach: Computer Networking" },
            new Car { Id = 24, CarCategoryId = 3, Ordered = false, Price = 1500, Owner = "Rich Seifert and James Edwards", Name = "The All-New Switch Book (2nd Edition)" },
            new Car { Id = 25, CarCategoryId = 3, Ordered = false, Price = 1500, Owner = "Rich Seifert and James Edwards", Name = "The All-New Switch Book (2nd Edition)" },
            new Car { Id = 26, CarCategoryId = 3, Ordered = false, Price = 1600, Owner = "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova", Name = "Business Data Communications and Networking (14th Edition)" },
            new Car { Id = 27, CarCategoryId = 3, Ordered = false, Price = 1700, Owner = "Forouzan", Name = "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition" },
            new Car { Id = 28, CarCategoryId = 3, Ordered = false, Price = 1800, Owner = "Gary Donahue", Name = "Network Warrior, 2nd Edition" },
            new Car { Id = 29, CarCategoryId = 3, Ordered = false, Price = 1800, Owner = "Gary Donahue", Name = "Network Warrior, 2nd Edition" },
            new Car { Id = 30, CarCategoryId = 3, Ordered = false, Price = 1800, Owner = "Gary Donahue", Name = "Network Warrior, 2nd Edition" },

            new Car { Id = 31, CarCategoryId = 4, Ordered = false, Price = 1900, Owner = "Ramesh Gaonkar", Name = "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)" },
            new Car { Id = 32, CarCategoryId = 4, Ordered = false, Price = 2000, Owner = "Douglas V. Hall", Name = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
            new Car { Id = 33, CarCategoryId = 4, Ordered = false, Price = 2000, Owner = "Douglas V. Hall", Name = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
            new Car { Id = 34, CarCategoryId = 4, Ordered = false, Price = 2100, Owner = "Kenneth L. Short", Name = "Embedded Microprocessor Systems Design" },
            new Car { Id = 35, CarCategoryId = 4, Ordered = false, Price = 2200, Owner = "Dr. Vibhav Kumar Sachan", Name = "Digital Electronics & Microprocessor" },
            new Car { Id = 36, CarCategoryId = 4, Ordered = false, Price = 2300, Owner = "Xiaocong Fan", Name = "Real-Time Embedded Systems" },
            new Car { Id = 37, CarCategoryId = 4, Ordered = false, Price = 2400, Owner = "Jonathan A. Dell", Name = "Digital Interface Design and Application" },

            new Car { Id = 38, CarCategoryId = 5, Ordered = false, Price = 2500, Owner = "Shigley's Mechanical Engineering Design", Name = "Richard G. Budynas and Keith J. Nisbett" },
            new Car { Id = 39, CarCategoryId = 5, Ordered = false, Price = 2500, Owner = "Shigley's Mechanical Engineering Design", Name = "Richard G. Budynas and Keith J. Nisbett" },
            new Car { Id = 40, CarCategoryId = 5, Ordered = false, Price = 2500, Owner = "Shigley's Mechanical Engineering Design", Name = "Richard G. Budynas and Keith J. Nisbett" },
            new Car { Id = 41, CarCategoryId = 5, Ordered = false, Price = 2600, Owner = "Erik Oberg", Name = "Machinery's Handbook" },
            new Car { Id = 42, CarCategoryId = 5, Ordered = false, Price = 2700, Owner = "John J. Craig", Name = "Introduction to Robotics: Mechanics and Control" },
            new Car { Id = 43, CarCategoryId = 5, Ordered = false, Price = 2800, Owner = "Robert L. Norton", Name = "Machine Design" },
            new Car { Id = 44, CarCategoryId = 5, Ordered = false, Price = 2800, Owner = "Robert L. Norton", Name = "Machine Design" },

            new Car { Id = 45, CarCategoryId = 6, Ordered = false, Price = 3000, Owner = "Frank M. White", Name = "Fluid Mechanics" },
            new Car { Id = 46, CarCategoryId = 6, Ordered = false, Price = 3100, Owner = "Claus Borgnakke and Richard E. Sonntag", Name = "Fundamentals of Thermodynamics" },
            new Car { Id = 47, CarCategoryId = 6, Ordered = false, Price = 3100, Owner = "Claus Borgnakke and Richard E. Sonntag", Name = "Fundamentals of Thermodynamics" },

            new Car { Id = 48, CarCategoryId = 7, Ordered = false, Price = 3200, Owner = "James Stewart", Name = "Calculus: Early Transcendentals" },
            new Car { Id = 49, CarCategoryId = 7, Ordered = false, Price = 3300, Owner = "Mark Ryan", Name = "Calculus for Dummies" },
            new Car { Id = 50, CarCategoryId = 7, Ordered = false, Price = 3300, Owner = "Mark Ryan", Name = "Calculus for Dummies" },
            new Car { Id = 51, CarCategoryId = 7, Ordered = false, Price = 3400, Owner = "Louis Leithold", Name = "The Calculus with Analytic Geometry" },

            new Car { Id = 52, CarCategoryId = 8, Ordered = false, Price = 3500, Owner = "Euclid", Name = "Euclid's Elements" },
            new Car { Id = 53, CarCategoryId = 8, Ordered = false, Price = 3600, Owner = "Robert Kanigel", Name = "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
            new Car { Id = 54, CarCategoryId = 8, Ordered = false, Price = 3600, Owner = "Robert Kanigel", Name = "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
            new Car { Id = 55, CarCategoryId = 8, Ordered = false, Price = 3700, Owner = "Stephen Hawking", Name = "A Brief History of Time" },
            new Car { Id = 56, CarCategoryId = 8, Ordered = false, Price = 3800, Owner = "Albert Einstein", Name = "Relativity: The Special and the General Theory" },
            new Car { Id = 57, CarCategoryId = 8, Ordered = false, Price = 3800, Owner = "Albert Einstein", Name = "Relativity: The Special and the General Theory" },
            new Car { Id = 58, CarCategoryId = 8, Ordered = false, Price = 3800, Owner = "Albert Einstein", Name = "Relativity: The Special and the General Theory" },
            new Car { Id = 59, CarCategoryId = 8, Ordered = false, Price = 3800, Owner = "Albert Einstein", Name = "Relativity: The Special and the General Theory" },
            new Car { Id = 60, CarCategoryId = 8, Ordered = false, Price = 3800, Owner = "Albert Einstein", Name = "Relativity: The Special and the General Theory" });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<UserType>().HaveConversion<string>();
            configurationBuilder.Properties<AccountStatus>().HaveConversion<string>();
        }
    }
}
