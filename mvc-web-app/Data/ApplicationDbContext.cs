using Microsoft.EntityFrameworkCore;
using mvc_web_app.Models;

namespace mvc_web_app.Data;
class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    } 

    public DbSet<Category> Categories { get; set; }
}