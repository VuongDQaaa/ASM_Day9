using ASM_Day9.Interface;
using ASM_Day9.Data;
using ASM_Day9.DTO;
using ASM_Day9.Entities;

namespace ASM_Day9.Service
{
    public class PersonService : IPersonService
    {
        private PersonContext _context;
        public PersonService(PersonContext context)
        {
            _context = context;
        }

        public void AddPerson(PersonDTO person)
        {
            _context.Person.Add(new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                DateOfBirth = person.DateOfBirth,
                Gender = person.Gender,
                BirthPlace = person.BirthPlace
            });

            _context.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            var item = _context.Person.FirstOrDefault(m => m.Id == id);
            if (item != null)
            {
                _context.Person.Remove(item);
                _context.SaveChanges();
            }
        }

        public List<Person> Filter(FilterPersonDTO person)
        {
            return _context.Person.Where(m => (!string.IsNullOrEmpty(person.FirstName) && m.FirstName.ToLower() == person.FirstName.ToLower())
            || (!string.IsNullOrEmpty(person.LastName) && m.LastName.ToLower() == person.LastName.ToLower())
            || m.Gender == person.Gender
            || m.BirthPlace == person.BirthPlace).ToList();
        }

        public void UpdatePerson(Person person)
        {
            var item = _context.Person.FirstOrDefault(m => m.Id == person.Id);
            if (item != null)
            {
                item.FirstName = person.FirstName;
                item.LastName = person.LastName;
                item.Gender = person.Gender;
                item.DateOfBirth = person.DateOfBirth;
                item.BirthPlace = person.BirthPlace;
                _context.SaveChanges();
            }
        }
    }
}