namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.CreateHouse
{
    public record HouseCreateRequest(string Name, string? Description, string? Address, Stream? ProfileImage, string? FileName);
}

