using TFG.HomeWorks.Domain.Entities.Base;

namespace TFG.HomeWorks.Domain.Entities.UserAggregate
{
    public class Role : BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
