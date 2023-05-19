using BlazorDemo444.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo444.Data;

public class AppsContext : DbContext
{
    public AppsContext(DbContextOptions<AppsContext> o) : 
        base(o)
    {

    }

    public DbSet<Person> Persons { get; set; }
}
