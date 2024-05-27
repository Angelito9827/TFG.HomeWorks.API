using TFG.HomeWorks.Domain.Entities.Base;

namespace TFG.HomeWorks.Domain.Entities.UserAggregate
{
    public class Role : BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();



#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Role() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static Role Create(Roles role)
        {
            return new Role()
            {
                Id = (int)role,
                Name = role.ToString(),
            };

        }
    }
}
