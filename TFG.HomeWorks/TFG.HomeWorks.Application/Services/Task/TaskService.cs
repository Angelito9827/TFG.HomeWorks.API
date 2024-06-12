using AutoMapper;
using Microsoft.Extensions.Logging;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;
using TFG.HomeWorks.Application.Validations;

namespace TFG.HomeWorks.Application.Services.Task
{
    internal class TaskService : ITaskService
    {
        private readonly ILogger<TaskService> _logger;
        private readonly IMapper _mapper;
        private readonly IObjectValidator _validator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITaskRepository _taskRepository;

        public TaskService(
            ILogger<TaskService> logger,
            IMapper mapper,
            IObjectValidator validator,
            IUnitOfWork unitOfWork,
            ITaskRepository taskRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
            _taskRepository = taskRepository;
        }


        public async Task<TaskCreateResponse> Create(TaskCreateRequest request)
        {
            _validator.EnsureIsValid(request);

            var entity = new Domain.Entities.TaskAggregate.Task(
                request.Name,
                request.Description,
                request.DeadlineDate,
                request.AssignedTo,
                request.AssignedBy,
                request.CategoryId,
                request.HouseId);

            _taskRepository.Add(entity);

            await _unitOfWork.SaveChangesAsync();
            return new TaskCreateResponse(entity.Id);
        }

    }
}
