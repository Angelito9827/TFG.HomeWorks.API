namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.UpdateHouse
{
    public record HouseUpdateRequest(int Id, string Name, string? Description, string? Address, Stream? ProfileImage, string? FileName);
}

