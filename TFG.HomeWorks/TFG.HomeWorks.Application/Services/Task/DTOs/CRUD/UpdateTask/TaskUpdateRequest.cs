using TFG.HomeWorks.Domain.Entities.TaskAggregate;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.UpdateTask
{
    public record TaskUpdateRequest(int Id, string Name, string Description, DateTime? CreationDate, DateTime DeadlineDate, string AssignedTo, string? AssignedBy, int? HouseId, int CategoryId, TaskState? State);
}
