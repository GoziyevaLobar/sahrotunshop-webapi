using FluentValidation;
using SahrotunShop.Service.Dtos.Discounts;

namespace SahrotunShop.Service.Validators.Dtos.Discounts;

public class DiscountUpdateValidator : AbstractValidator <DiscountUpdateDto>
{
    public DiscountUpdateValidator()
    {
        RuleFor(dto => dto.Name).NotEmpty().NotNull().WithMessage("Discount name is required!")
            .MinimumLength(3).WithMessage("Discount name must be more than 3 characters!")
            .MaximumLength(50).WithMessage("Discount name must be less than 50 characters!");

        RuleFor(dto => dto.Description).NotNull().NotEmpty().WithMessage("Description field is required!")
            .MinimumLength(20).WithMessage("Description field is required!");
    }
}
