namespace TFG.HomeWorks.Application.Services.Task.DTOs.CRUD.GetTaskList
{
    public class TaskListItemResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int State { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public CategoryDTO Category { get; set; }
        public HouseDto House { get; set; }
    }


    public class HouseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string ProfileImage { get; set; }
    }

    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
