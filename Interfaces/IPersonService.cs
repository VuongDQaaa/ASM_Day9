using ASM_Day9.Entities;
using ASM_Day9.DTO;

namespace ASM_Day9.Interfaces
{
    public interface IPersonService
    {
        void AddPerson(PersonDTO person);
        List<Person> Filter(FilterPersonDTO person);
        void DeletePerson(int id);
        void UpdatePerson(Person person);
    }
}