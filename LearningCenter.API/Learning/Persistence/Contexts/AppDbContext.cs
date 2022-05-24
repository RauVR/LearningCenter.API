using Microsoft.EntityFrameworkCore;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Shared.Extensions;

namespace LearningCenter.API.Learning.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tutorial> Tutorials { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Categories
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            
            //Relationships  esto representa la relacion de uno a muchos
            builder.Entity<Category>().HasMany(p => p.Tutorials)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            
            //Tutorials
            builder.Entity<Tutorial>().ToTable("Categories");
            builder.Entity<Tutorial>().HasKey(p => p.Id);
            builder.Entity<Tutorial>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Tutorial>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Tutorial>().Property(p => p.Description).HasMaxLength(120);
            
            //Apply Naming Convention
            
            builder.UseSnakeCaseNamingConvention();
            

        }
    }
}