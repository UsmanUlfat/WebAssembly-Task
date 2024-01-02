using Microsoft.EntityFrameworkCore;
using Projecttt.Components.Pages;

namespace Projecttt.Model
{
    public class AddContext : DbContext
    {
        public AddContext(DbContextOptions<AddContext> options) : base(options) //configure dbContext option 
        {

        }
        public DbSet<Admission> Admissions { get; set; }
        public object Admission { get; internal set; }
    }
}
