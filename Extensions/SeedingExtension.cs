using ASM_Day9.Data;

namespace ASM_Day9.Extensions
{
    public static class SeedingExtension
    {
        public static IWebHost SeedData(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                PersonContext context = services.GetService<PersonContext>();

                // now we have the DbContext. Run migrations
                //context.Database.Migrate();

                // now that the database is up to date. Let's seed
                new PersonSeeder(context).SeedData();
            }

            return host;
        }
    }
}