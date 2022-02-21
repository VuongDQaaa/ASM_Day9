using ASM_Day9.Enum;

namespace ASM_Day9.DTO
{
    public class FilterPersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string BirthPlace { get; set; }
    }
}