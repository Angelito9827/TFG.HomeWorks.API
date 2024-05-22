using TFG.HomeWorks.Domain.Entities.Base;

namespace TFG.HomeWorks.Domain.Entities.UserAggregate
{
    public class User : BaseEntity<int>
    {
        //Properties 
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] PasswordHash { get; set; }
        public Genre Genre { get; set; }
        public string ProfileImage { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        //Constructors
        private User() { }

        public User(
            string email,
            string username,
            string firstName,
            string lastName,
            DateTime birthDate,
            string phoneNumber,
            byte[] passwordHash,
            Genre genre,
            string profileImage,
            int roleId,
            Role role)
        {
            Email = email;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            PasswordHash = passwordHash;
            Genre = genre;
            ProfileImage = profileImage;
            RoleId = roleId;
            Role = role;
        }
    }
}
