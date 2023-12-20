namespace ZeroToHero.Models
{
    // User class

    public class User
    {
        public int EmployeeId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public Profession Profession { get; set; }
        public Statistic Statistic { get; set; }
        public string PhotoPath { get; set; }

        public User()
        {
            Profession = new Profession();
            Statistic = new Statistic();
        }
    }


    // Gender Enum

    public enum Gender
    {
        Male,
        Female,
        Other
    }

}
