using SahrotunShop.DataAccess.Common.Intefaces.Discounts;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Categories;
using SahrotunShop.Domain.Entities.Companies;
using SahrotunShop.Domain.Entities.Discounts;
using SahrotunShop.Domain.Exceptions.Categories;
using SahrotunShop.Domain.Exceptions.Discounts;
using SahrotunShop.Domain.Exceptions.Files;
using SahrotunShop.Service.Common.Helpers;
using SahrotunShop.Service.Dtos.Companies;
using SahrotunShop.Service.Dtos.Discounts;
using SahrotunShop.Service.Interfaces.Common;
using SahrotunShop.Service.Interfaces.Discounts;

namespace SahrotunShop.Service.Services.Discounts;

public class DiscountService : IDiscountService
{
    private readonly IDiscountRepository _repository;
    private readonly IFileService _fileService;

    public DiscountService(IDiscountRepository discountRepository,
        IFileService fileService)
    {
        this._repository = discountRepository;
        this._fileService = fileService;
    }

    public async Task<bool> CreateAsync(DiscountCreateDto dto)
    {
        Discount discount = new Discount()
        {
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = TimeHelper.GetDateTime(),
            UpdatedAt = TimeHelper.GetDateTime()
        };
        var result = await _repository.CreateAsync(discount);
        return result > 0;
    }

    public async Task<bool> DeleteAsync(long discountId)
    {
        var discount = await _repository.GetByIdAsync(discountId);
        if (discount is null) throw new DiscountNotFoundException();
        var dbResult = await _repository.DeleteAsync(discountId);
        return dbResult > 0;
    }

    public async Task<IList<Discount>> GetAllAsync(PaginationParams @params)
    {
        var discounts = await _repository.GetAllAsync(@params);
        return discounts;
    }

    public async Task<Discount> GetByIdAsync(long discountId)
    {
        var discount = await _repository.GetByIdAsync(discountId);
        if (discount is null) throw new DiscountNotFoundException();
        else return discount;
    }

    public async Task<bool> UpdateAsync(long discountId, DiscountUpdateDto dto)
    {
        var discount = await _repository.GetByIdAsync(discountId);
        if (discount is null) throw new DiscountNotFoundException();

        // parse new items to discount

        discount.Name = dto.Name;
        discount.Description = dto.Description;

        discount.UpdatedAt = TimeHelper.GetDateTime();

        var dbResult = await _repository.UpdateAsync(discountId, discount);
        return dbResult > 0;
    }
}
