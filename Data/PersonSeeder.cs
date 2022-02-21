using ASM_Day9.Entities;
using ASM_Day9.Enum;

namespace ASM_Day9.Data
{
    public class PersonSeeder
    {
        private readonly PersonContext _context;
        public PersonSeeder(PersonContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            _context.Person.AddRange(new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Dao",
                    LastName = "Vuong1",
                    DateOfBirth = new DateTime(2000, 3, 29),
                    Gender = Gender.Male,
                    BirthPlace = "Ha Noi",
                },
                new Person()
                {
                    Id = 2,
                    FirstName = "Nguyen",
                    LastName = "Nam",
                    DateOfBirth = new DateTime(1996, 3, 23),
                    Gender = Gender.Male,
                    BirthPlace = "HCM",
                },
                new Person()
                {
                    Id = 3,
                    FirstName = "Le",
                    LastName = "Na",
                    DateOfBirth = new DateTime(1998, 4, 30),
                    Gender = Gender.Female,
                    BirthPlace = "Ha Noi",
                },
                new Person()
                {
                    Id = 4,
                    FirstName = "Tran",
                    LastName = "Duc Bo",
                    DateOfBirth = new DateTime(2001, 8, 29),
                    Gender = Gender.Other,
                    BirthPlace = "DN",
                },
                new Person()
                {
                    Id = 5,
                    FirstName = "Jonh",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2002, 3, 29),
                    Gender = Gender.Female,
                    BirthPlace = "Ha Noi",
                }
            });

            _context.SaveChanges();
        }
    }
}