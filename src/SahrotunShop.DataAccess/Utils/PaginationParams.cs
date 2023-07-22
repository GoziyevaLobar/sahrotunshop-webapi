namespace SahrotunShop.DataAccess.Utils;

public class PaginationParams
{
    public int PageNumber { get; set; }   

    public int PageSize { get; set; } 
    
    public int ScipCount
    {
        get
        {
            return (PageNumber - 1) * PageSize; 
        }
    }
}
