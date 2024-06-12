using FluentValidation;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.GetHouseById
{
    public class HouseGetByIdRequestValidator : AbstractValidator<HouseGetByIdRequest>
    {
        public HouseGetByIdRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
