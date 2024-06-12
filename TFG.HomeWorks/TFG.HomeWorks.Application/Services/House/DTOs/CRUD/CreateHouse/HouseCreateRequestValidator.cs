using FluentValidation;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.CreateHouse
{
    public class HouseCreateRequestValidator : AbstractValidator<HouseCreateRequest>
    {
        public HouseCreateRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}

