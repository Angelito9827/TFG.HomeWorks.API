using FluentValidation;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.DeleteTaskById
{
    public class TaskDeleteByIdRequestValidator: AbstractValidator<TaskDeleteByIdRequest>
    {
        public TaskDeleteByIdRequestValidator()
        {
            RuleFor(x=>x.Id).NotEmpty();
        }
    }

}
