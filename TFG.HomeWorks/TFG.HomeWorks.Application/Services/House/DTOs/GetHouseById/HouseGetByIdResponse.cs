namespace TFG.HomeWorks.Application.Services.House.DTOs.GetHouseById
{
    public record HouseGetByIdResponse(int Id, string Name, string? Description, string? Address, string? ProfileImage);
}
