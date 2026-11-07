
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Setting_Up_Blazor___EF.Data.Models;

namespace Setting_Up_Blazor___EF.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

      

        public DbSet<Module> Modules { get; set; }
    }
}
