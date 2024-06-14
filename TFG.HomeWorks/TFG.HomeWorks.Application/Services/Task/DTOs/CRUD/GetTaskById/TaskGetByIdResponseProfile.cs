using AutoMapper;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskById
{
    public class TaskGetByIdResponseProfile : Profile
    {
        public TaskGetByIdResponseProfile()
        {
            CreateMap<Domain.Entities.TaskAggregate.Task, TaskGetByIdResponse>();
        }
    }



}
