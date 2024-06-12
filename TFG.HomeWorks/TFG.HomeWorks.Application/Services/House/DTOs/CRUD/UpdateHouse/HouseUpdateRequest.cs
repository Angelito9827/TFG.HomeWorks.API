namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.UpdateHouse
{
    public class HouseUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public Stream? ProfileImage { get; set; }
        public string? FileName { get; set; }
    }
}

