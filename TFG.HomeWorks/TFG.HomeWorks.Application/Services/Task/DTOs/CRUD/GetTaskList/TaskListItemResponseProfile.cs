using AutoMapper;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList
{
    public class TaskListItemResponseProfile : Profile
    {
        public TaskListItemResponseProfile()
        {
            CreateMap<Domain.Entities.TaskAggregate.Task, TaskListItemResponse>();
        }
    }
}
