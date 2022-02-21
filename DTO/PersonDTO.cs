using ASM_Day9.Enum;

namespace ASM_Day9.DTO
{
    public class PersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string BirthPlace { get; set; }
    }
}