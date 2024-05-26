using TFG.HomeWorks.Domain.Entities.Base;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;

namespace TFG.HomeWorks.Domain.Entities.UserAggregate
{
    public class User : BaseEntity<int>
    {
        //Properties 
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string? LastName1 { get; set; }
        public string? LastName2 { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public byte[] PasswordHash { get; set; }
        public Genre Genre { get; set; }
        public string ProfileImage { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<HouseMember> HouseMembers { get; set; }

        //Constructors
        private User() { }

        public User(
            string email,
            string username,
            string firstName,
            string? lastName1,
            string? lastName2,
            DateTime birthDate,
            string phoneNumber,
            byte[] passwordHash,
            Genre genre,
            string profileImage,
            int roleId,
            Role role,
            ICollection<HouseMember> houseMembers)
        {
            var entity = new User();
            entity.Email = email;
            entity.Username = username;
            entity.FirstName = firstName;
            entity.LastName1 = lastName1;
            entity.LastName2 = lastName2;
            entity.BirthDate = birthDate;
            entity.PhoneNumber = phoneNumber;
            entity.PasswordHash = passwordHash;
            entity.Genre = genre;
            entity.ProfileImage = profileImage;
            entity.RoleId = roleId;
            entity.Role = role;
            entity.HouseMembers = houseMembers;
        }
    }
}
