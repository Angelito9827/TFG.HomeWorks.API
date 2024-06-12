using FluentValidation;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.UpdateHouse
{
    public class HouseUpdateRequestValidator : AbstractValidator<HouseUpdateRequest>
    {
        public HouseUpdateRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}

