using Microsoft.AspNetCore.Http;

namespace TFG.HomeWorks.WebApi.DTOs.House
{
    public class HouseUpdateRequestAPI
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }

        public IFormFile? Image { get; set; }
    }
}
