using TFG.HomeWorks.Domain.Entities.Base;
using TFG.HomeWorks.Domain.Entities.HouseAggregate;

namespace TFG.HomeWorks.Domain.Entities.TaskAggregate
{
    public class Task : BaseEntity<int>
    {
        //Properties 
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }

        //FK Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //FK House
        public int HouseId { get; set; }
        public House House { get; set; }


        //Constructors
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Task() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Task(string name,
                    string description,
                    TaskState state,
                    DateTime deadlineDate,
                    string assignedTo,
                    string assignedBy,
                    int categoryId,
                    Category category,
                    int houseId,
                    House house)
        {
            Name = name;
            Description = description;
            State = state;
            CreationDate = DateTime.Now;
            DeadlineDate = deadlineDate;
            AssignedTo = assignedTo;
            AssignedBy = assignedBy;
            CategoryId = categoryId;
            Category = category;
            HouseId = houseId;
            House = house;
        }
    }
}
