using Microsoft.EntityFrameworkCore;
using ASM_Day9.Entities;
using ASM_Day9.Enum;

namespace ASM_Day9.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }
        public DbSet<Person> Person { get; set; }
    }
}