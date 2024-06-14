using FluentValidation;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskById
{
    public class TaskGetByIdValidator : AbstractValidator<TaskGetByIdRequest>
    {
        public TaskGetByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }

}
