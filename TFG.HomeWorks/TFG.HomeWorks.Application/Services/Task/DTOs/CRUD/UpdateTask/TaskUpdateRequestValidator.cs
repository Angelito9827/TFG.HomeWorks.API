using FluentValidation;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.UpdateTask
{
    public class TaskUpdateRequestValidator : AbstractValidator<TaskUpdateRequest>
    {
        public TaskUpdateRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
