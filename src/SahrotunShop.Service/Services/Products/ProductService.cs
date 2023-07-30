using SahrotunShop.DataAccess.Common.Intefaces.Products;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.DataAccess.ViewModels.Products;
using SahrotunShop.Domain.Entities.Categories;
using SahrotunShop.Domain.Entities.Products;
using SahrotunShop.Domain.Exceptions.Categories;
using SahrotunShop.Domain.Exceptions.Files;
using SahrotunShop.Domain.Exceptions.Products;
using SahrotunShop.Service.Common.Helpers;
using SahrotunShop.Service.Dtos.Products;
using SahrotunShop.Service.Interfaces.Common;
using SahrotunShop.Service.Interfaces.Products;

namespace SahrotunShop.Service.Services.Products;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;   
    private readonly IFileService _fileService;
    private readonly IPaginator _paginator;

    public ProductService(IProductRepository productRepository,
        IFileService fileService,
        IPaginator paginator)
    {
        this._repository = productRepository;
        this._fileService = fileService;
        this._paginator = paginator;
    }
    public async Task<bool> CreateAsync(ProductCreateDto dto)
    {
        string imagepath = await _fileService.UploadImageAsync(dto.Image);

        Product product = new Product()
        {
            ImagePath = imagepath,
            Name = dto.Name,
            Description = dto.Description,
            UnitPrice = dto.UnitPrice,
            CreatedAt = TimeHelper.GetDateTime(),
            UpdatedAt = TimeHelper.GetDateTime()
        };
        var dbResult = await _repository.CreateAsync(product);
        return dbResult > 0;
    }

    public async Task<bool> DeleteAsync(long productId)
    {
        var product = await _repository.GetByIdAsync(productId);
        if (product is null) throw new ProductNotFoundException();

        var result = await _fileService.DeleteImageAsync(product.ImagePath);
        if (result == false) throw new ImageNotFoundException();

        var dbResult = await _repository.DeleteAsync(productId);
        return dbResult > 0;
    }

    public async Task<IList<ProductViewModel>> GetAllAsync(PaginationParams @params)
    {
        var products = await _repository.GetAllAsync(@params);
        var count = await _repository.CountAsync();
        _paginator.Paginate(count, @params);
        return products;
    }

    public  async Task<ProductViewModel> GetByIdAsync(long productId)
    {
        var product = await _repository.GetByIdAsync(productId);
        if (product is null) throw new ProductNotFoundException();
        return product;
    }

    public async Task<bool> UpdateAsync(long productId, ProductUpdateDto dto)
    {
        var product = await _repository.GetByIdAsync(productId);
        if (product is null) throw new ProductNotFoundException();

        // parse new items to product
        product.Name = dto.Name;
        product.Description = dto.Description;

        if (dto.Image is not null)
        {
            // delete old image
            var deleteResult = await _fileService.DeleteImageAsync(product.ImagePath);
            if (deleteResult is false) throw new ImageNotFoundException();

            // upload new image
            string newImagePath = await _fileService.UploadImageAsync(dto.Image);

            // parse new path to product
            product.ImagePath = newImagePath;
        }
        // else product old image have to save

        product.UpdatedAt = TimeHelper.GetDateTime();

        var dbResult = await _repository.UpdateAsync(productId, product);
        return dbResult > 0;
    }
}
