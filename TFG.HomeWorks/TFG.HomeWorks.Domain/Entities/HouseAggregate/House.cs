using TFG.HomeWorks.Domain.Entities.Base;

namespace TFG.HomeWorks.Domain.Entities.HouseAggregate
{
    public class House : BaseEntity<int>
    {
        //Properties
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string ProfileImage { get; set; }
        public bool isAdmin { get; set; }

        public ICollection<HouseMember> Members { get; set; }

        //Constructors
        private House() { }

        public House(int id, string name, string? description, string? address, string profileImage)
        {
            Id = id;
            Name = name;
            Description = description;
            Address = address;
            ProfileImage = profileImage;
            isAdmin = true;
        }
        public House(string name, string? description, string? address, string profileImage)
        {
            Name = name;
            Description = description;
            Address = address;
            ProfileImage = profileImage;
            isAdmin = true;
        }
    }
}
