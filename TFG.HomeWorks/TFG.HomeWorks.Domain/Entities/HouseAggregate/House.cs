using TFG.HomeWorks.Domain.Entities.Base;

namespace TFG.HomeWorks.Domain.Entities.HouseAggregate
{
    public class House : BaseEntity<int>
    {
        //Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ProfileImage { get; set; }

        public ICollection<HouseMember> Members { get; set; }

        //Constructors
        private House() { }

        public House(string name, string description, string address, string profileImage)
        {
            Name = name;
            Description = description;
            Address = address;
            ProfileImage = profileImage;
        }
    }
}
