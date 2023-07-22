namespace SahrotunShop.Domain.Exceptions.Suppliers;

internal class SupplierNotFoundException : NotFoundException
{
    public SupplierNotFoundException()
    {
        this.TitleMessage = "Supplier Not Found!";
    }
}

