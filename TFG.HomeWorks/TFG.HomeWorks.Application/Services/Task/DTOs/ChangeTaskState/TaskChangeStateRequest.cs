using TFG.HomeWorks.Domain.Entities.TaskAggregate;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.ChangeTaskState
{
    public class TaskChangeStateRequest
    {
        public int Id { get; set; }
        public TaskState State { get; set; }
    }
}
