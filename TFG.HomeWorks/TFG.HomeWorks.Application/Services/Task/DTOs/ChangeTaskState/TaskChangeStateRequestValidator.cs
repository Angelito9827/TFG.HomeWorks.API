using FluentValidation;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.ChangeTaskState
{
    public class TaskChangeStateRequestValidator : AbstractValidator<TaskChangeStateRequest>
    {
        public TaskChangeStateRequestValidator()
        {
            RuleFor(x => x.State).NotNull();
        }
    }
}
