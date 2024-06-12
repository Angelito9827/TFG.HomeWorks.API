using AutoMapper;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask
{
    public class TaskCreateResponseProfile : Profile
    {
        public TaskCreateResponseProfile()
        {
            CreateMap<Domain.Entities.TaskAggregate.Task, TaskCreateResponse>();
        }
    }
}
