using Dapper;
using SahrotunShop.DataAccess.Common.Intefaces.Discounts;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Companies;
using SahrotunShop.Domain.Entities.Discounts;

namespace SahrotunShop.DataAccess.Repositories.Discounts;

public class DiscountRepository : BaseRepository, IDiscountRepository
{
    public async Task<long> CountAsync()
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"select count(*) from discounts";
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

    public async Task<int> CreateAsync(Discount entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "INSERT INTO public.discounts(name, description, created_at, updated_at) " +
                "VALUES (@Name, @Description, @CreatedAt, @UpdatedAt);";
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
            string query = $"delete from discounts where id = @Id";
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

    public async Task<IList<Discount>> GetAllAsync(PaginationParams @params)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"select * from discounts " +
                $"order by id desc " +
                $"offset {@params.GetSkipCount()} limit {@params.PageSize}";
            var result = (await _connection.QueryAsync<Discount>(query)).ToList();
            return result;
        }
        catch
        {
            return new List<Discount>();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public Task<IList<Discount>> GetAllByDurationAsync(DateTime startAt, DateTime endAt, PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public async Task<Discount?> GetByIdAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"select * from discounts where id = {id}";
            var result = await _connection.QuerySingleAsync<Discount>(query);
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

    public async Task<int> UpdateAsync(long id, Discount entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "UPDATE public.discounts " +
                "SET name=@Name, description=@Description, " +
                "created_at=@CreatedAt, updated_at=@UpdatedAt " +
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
