using TFG.HomeWorks.Domain.Entities.TaskAggregate;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList
{
    public class TaskListItemResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public int CategoryId { get; set; }
        public int HouseId { get; set; }
    }
}
