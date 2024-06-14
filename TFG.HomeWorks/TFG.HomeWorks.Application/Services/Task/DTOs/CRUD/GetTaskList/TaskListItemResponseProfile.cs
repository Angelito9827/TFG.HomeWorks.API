using AutoMapper;
using TFG.HomeWorks.Domain.Entities.TaskAggregate;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList
{
    public class TaskListItemResponseProfile : Profile
    {
        public TaskListItemResponseProfile()
        {
            CreateMap<Domain.Entities.TaskAggregate.Task, TaskListItemResponse>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<Domain.Entities.HouseAggregate.House, HouseDto>();
        }
    }
}
