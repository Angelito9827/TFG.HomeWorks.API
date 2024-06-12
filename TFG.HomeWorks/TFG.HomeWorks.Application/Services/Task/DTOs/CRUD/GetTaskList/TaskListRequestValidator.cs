using FluentValidation;

namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList
{
    public class TaskListRequestValidator : AbstractValidator<TaskListRequest>
    {
        public TaskListRequestValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(0);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
