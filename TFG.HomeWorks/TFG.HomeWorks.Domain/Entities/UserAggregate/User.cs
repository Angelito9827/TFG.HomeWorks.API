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
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Gender Gender { get; set; }
        public string ProfileImage { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<HouseMember> HouseMembers { get; set; }

        //Constructors
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private User() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static User Create(
            string email,
            string username,
            string firstName,
            string? lastName1,
            string? lastName2,
            DateTime birthDate,
            string? phoneNumber,
            string passwordHash,
            string passwordSalt,
            Gender gender,
            string profileImage,
            Roles role)
        {

            var roleEntity = Role.Create(role);

            var entity = new User();
            entity.Email = email;
            entity.Username = username;
            entity.FirstName = firstName;
            entity.LastName1 = lastName1;
            entity.LastName2 = lastName2;
            entity.BirthDate = birthDate;
            entity.PhoneNumber = phoneNumber;
            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;
            entity.Gender = gender;
            entity.ProfileImage = profileImage;
            entity.RoleId = roleEntity.Id;
            entity.HouseMembers = [];

            return entity;
        }

    }
}
