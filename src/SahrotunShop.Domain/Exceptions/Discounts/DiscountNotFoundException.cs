namespace SahrotunShop.Domain.Exceptions.Discounts;

public class DiscountNotFoundException : NotFoundException
{
    public DiscountNotFoundException()
    {
        this.TitleMessage = "Discount Not Found!";
    }
}
