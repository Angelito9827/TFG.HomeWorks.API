namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.UpdateHouse
{
    public record HouseUpdateResponse(int Id, string Name, string? Description, string? Address, string? ProfileImage);
}
