using AmuseTheKids.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace AmuseTheKids.DAL
{
    public class EnrolKidsContext : DbContext
    {
        public EnrolKidsContext() : base("EnrolKidsContext")
        {
        }
        public DbSet<Child> Children { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}