using Microsoft.AspNetCore.Http;

namespace TFG.HomeWorks.WebApi.DTOs.House
{
    public class HouseCreateRequestAPI
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public IFormFile? ProfileImage { get; set; }
    }
}
