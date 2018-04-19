using System;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
    public class TravelBlogDbContext : DbContext
    {
        public TravelBlogDbContext()
        {

        }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<ExperiencesPersons> ExperiencesPersons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=travelblog;uid=root;pwd=root;");
        
        public TravelBlogDbContext(DbContextOptions<TravelBlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
