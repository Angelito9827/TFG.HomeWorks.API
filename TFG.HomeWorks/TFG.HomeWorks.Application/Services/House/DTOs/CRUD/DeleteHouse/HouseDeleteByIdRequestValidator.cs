using FluentValidation;

namespace TFG.HomeWorks.Application.Services.House.DTOs.CRUD.DeleteHouse
{
    public class HouseDeleteByIdRequestValidator : AbstractValidator<HouseDeleteByIdRequest>
    {
        public HouseDeleteByIdRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }


}
