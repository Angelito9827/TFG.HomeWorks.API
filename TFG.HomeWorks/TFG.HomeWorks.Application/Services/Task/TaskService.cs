using AutoMapper;
using Microsoft.Extensions.Logging;
using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.Task.DTOs.ChangeTaskState;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.CreateTask;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.DeleteTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskById;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList;
using TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.UpdateTask;
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

        public async Task<PageListResponse<TaskListItemResponse>> List(TaskListRequest request)
        {
            _validator.EnsureIsValid(request);

            var entities = await _taskRepository.List(request);

            return new PageListResponse<TaskListItemResponse>
            {
                Elements = _mapper.Map<IEnumerable<TaskListItemResponse>>(entities),
                Page = request.Page,
                PageSize = request.PageSize,
                TotalCount = await _taskRepository.Count(request)
            };
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
        public async System.Threading.Tasks.Task Delete(TaskDeleteByIdRequest request)
        {
            _validator.EnsureIsValid(request);

            var entity = await _taskRepository.GetById(new TaskGetByIdRequest(request.Id));

            if (entity is null)
                throw new KeyNotFoundException(nameof(Domain.Entities.TaskAggregate.Task));

            _taskRepository.Delete(entity);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task<TaskGetByIdResponse> GetById(TaskGetByIdRequest request)
        {
            _validator.EnsureIsValid(request);
            var entity = await _taskRepository.GetById(request);

            if (entity is null)
                throw new KeyNotFoundException(nameof(Domain.Entities.HouseAggregate.House));

            var response = _mapper.Map<TaskGetByIdResponse>(entity);
            return response;
        }

        public async System.Threading.Tasks.Task ChangeState(TaskChangeStateRequest request)
        {
            _validator.EnsureIsValid(request);
            var entity = await _taskRepository.GetById(new TaskGetByIdRequest(request.Id));

            if (entity is null)
                throw new KeyNotFoundException(nameof(Domain.Entities.HouseAggregate.House));

            entity.State = request.State;

            _taskRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task Update(TaskUpdateRequest request)
        {
            _validator.EnsureIsValid(request);
            var entity = await _taskRepository.GetById(new TaskGetByIdRequest(request.Id));

            if (entity is null)
                throw new KeyNotFoundException(nameof(Domain.Entities.HouseAggregate.House));

            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.State = request.State ?? entity.State;
            entity.CreationDate = request.CreationDate ?? entity.CreationDate;
            entity.DeadlineDate = request.DeadlineDate;
            entity.AssignedTo = request.AssignedTo;
            entity.AssignedBy = request.AssignedBy ?? "user@example.com";
            entity.CategoryId = request.CategoryId;
            entity.HouseId = request.HouseId ?? entity.HouseId;


            _taskRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }



    }
}
