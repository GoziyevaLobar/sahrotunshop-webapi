using FluentValidation;
using SahrotunShop.Service.Common.Helpers;
using SahrotunShop.Service.Dtos.Products;

namespace SahrotunShop.Service.Validators.Dtos.Products;

public class ProductCreateValidator : AbstractValidator<ProductCreateDto>
{
    public ProductCreateValidator()
    {
        RuleFor(dto => dto.Name).NotNull().NotEmpty().WithMessage("Name field is required!")
            .MinimumLength(3).WithMessage("Name must be more than 3 characters")
            .MaximumLength(50).WithMessage("Name must be less than 50 characters");

        RuleFor(dto => dto.Description).NotNull().NotEmpty().WithMessage("Description field is required!")
            .MinimumLength(20).WithMessage("Description field is required!");

        int maxImageSizeMB = 5;
        RuleFor(dto => dto.Image).NotNull().NotEmpty().WithMessage("Image field is required!");
        RuleFor(dto => dto.Image.Length).LessThan(maxImageSizeMB * 1024 * 1024).WithMessage($"Image size must be less than {maxImageSizeMB} MB!");
        RuleFor(dto => dto.Image.FileName).Must(predicate =>
        {
            FileInfo fileInfo = new FileInfo(predicate);
            return MediaHelper.GetImageExtensions().Contains(fileInfo.Extension);
        }).WithMessage("This file type is not image file!");
    }
}
