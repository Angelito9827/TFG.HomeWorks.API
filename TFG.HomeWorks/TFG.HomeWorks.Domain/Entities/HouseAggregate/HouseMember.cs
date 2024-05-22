using TFG.HomeWorks.Domain.Entities.Base;
using TFG.HomeWorks.Domain.Entities.UserAggregate;

namespace TFG.HomeWorks.Domain.Entities.HouseAggregate
{
    public class HouseMember : BaseEntity<int>
    {
        public int HouseId { get; set; }
        public House House { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        private HouseMember() { }
        public HouseMember(int houseId, House house, int userId, User user)
        {
            HouseId = houseId;
            House = house;
            UserId = userId;
            User = user;
        }
    }
}
