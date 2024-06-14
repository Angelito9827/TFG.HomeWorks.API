namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask
{
    public record TaskCreateRequest(string Name, string Description, DateTime CreationDate, DateTime DeadlineDate, string AssignedTo, string? AssignedBy, int HouseId, int CategoryId);
}
