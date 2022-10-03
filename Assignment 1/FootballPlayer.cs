using System.ComponentModel.DataAnnotations;

namespace Assignment_1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }


        public void ValidateName()
        {
            if (Name.Length < 2) throw new ValidationException("Name must be more than 1 character");
        }

        public void ValidateAge()
        {
            if (Age < 1) throw new ValidationException("Age must be more than 0");
        }
        
        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99) throw new ValidationException("ShirtNumber must be 1 - 99");
        }
    }
}