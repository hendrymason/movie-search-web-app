using Microsoft.EntityFrameworkCore;

//TODO: Update this using statement to include your project name
using Hendry_Mason_HW3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//TODO: Make this namespace match your project name
namespace Hendry_Mason_HW3.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below

    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //TODO: Add Dbsets here.  Products is included as an example.
        public DbSet<Show> Shows { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}