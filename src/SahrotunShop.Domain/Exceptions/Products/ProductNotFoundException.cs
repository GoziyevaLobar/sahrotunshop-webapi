namespace SahrotunShop.Domain.Exceptions.Products;
public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException()
    {
        this.TitleMessage = "ProductNotFound!";
    }
}
