using FluentValidation;

namespace TFG.HomeWorks.Application.Services.House.DTOs.HouseList
{
    public class HouseListRequestValidator : AbstractValidator<HouseListRequest>
    {
        public HouseListRequestValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(0);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
