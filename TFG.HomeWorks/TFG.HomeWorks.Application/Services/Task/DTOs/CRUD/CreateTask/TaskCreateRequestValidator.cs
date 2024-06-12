using FluentValidation;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask
{
    public class TaskCreateRequestValidator : AbstractValidator<TaskCreateRequest>
    {
        public TaskCreateRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
