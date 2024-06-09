using FluentValidation;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CreateHouse
{
    public class HouseCreateRequestValidator : AbstractValidator<HouseCreateRequest>
    {
        public HouseCreateRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}

