using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BlazorApp1.Models.Semesters> Semesters { get; set; } = default!;
        public DbSet<BlazorApp1.Models.Departments> Departments { get; set; } = default!;
        public DbSet<BlazorApp1.Models.Majors> Majors { get; set; } = default!;
        public DbSet<BlazorApp1.Models.Subjects> Subjects { get; set; } = default!;
        public DbSet<BlazorApp1.Models.Courses> Courses { get; set; } = default!;
        public DbSet<ApplicationUser> ApplicationUser { get; set; } = default!;
    }
}
