using Dapper;
using SahrotunShop.DataAccess.Common.Intefaces.Products;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.DataAccess.ViewModels.Products;
using SahrotunShop.Domain.Entities.Companies;
using SahrotunShop.Domain.Entities.Products;

namespace SahrotunShop.DataAccess.Repositories.Products;

public class ProductRepository :BaseRepository, IProductRepository
{
    public async Task<long> CountAsync()
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"select count(*) from products";
            var result = await _connection.QuerySingleAsync<long>(query);
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<int> CreateAsync(Product entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "INSERT INTO public.products(name, description, image_path, unit_price, created_at, updated_at) " +
                "VALUES (@Name, @Description, @ImagePath, @UnitPrice, @CreatedAt, @UpdatedAt);";
            var result = await _connection.ExecuteAsync(query, entity);
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<int> DeleteAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"delete from products where id = @Id";
            var result = await _connection.ExecuteAsync(query, new { Id = id });
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<IList<ProductViewModel>> GetAllAsync(PaginationParams @params)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"select * from products " +
                $"order by id desc " +
                $"offset {@params.GetSkipCount()} limit {@params.PageSize}";
            var result = (await _connection.QueryAsync<ProductViewModel>(query)).ToList();
            return result;
        }
        catch
        {
            return new List<ProductViewModel>();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<ProductViewModel?> GetByIdAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"select * from products where id = {id}";
            var result = await _connection.QuerySingleAsync<ProductViewModel>(query);
            return result;
        }
        catch
        {
            return null;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public Task<(int ItemsCount, IList<ProductViewModel>)> SearchAsync(string search, PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public async Task<int> UpdateAsync(long id, Product entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "UPDATE public.products " +
                "SET name=@Name, description=@Description, image_path=@ImagePath, category_Id=@CategoryId, company_Id = @CompanyId " +
                "unit_price=@UnitPrice, created_at=@CreatedAt, updated_at=@UpdatedAt " +
                $"WHERE id = {id};";
            var result = await _connection.ExecuteAsync(query, entity);
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }
}
