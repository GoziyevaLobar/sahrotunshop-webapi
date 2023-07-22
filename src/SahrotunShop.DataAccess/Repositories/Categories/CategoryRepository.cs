﻿using Dapper;
using SahrotunShop.DataAccess.Interfaces.Categories;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Categories;
using static Dapper.SqlMapper;

namespace SahrotunShop.DataAccess.Repositories.Categories;

public class CategoryRepository : BaseRepository, ICategoryRepository
{
    public async Task<long> CountAsync()
    {
        try
        {
            await _connection.OpenAsync();
            string query = "SELECT count(*) FROM public.categories;";
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

    public async Task<int> CreateAsync(Category entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "INSERT INTO public.categories( " +
                "name, description, image_path, created_at, updated_at)  " +
                "VALUES (@Name, @Description, @ImagePath, @CreatedAt, @UpdatedAt);";
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
            string query = "DELETE FROM categories WHERE id = @Id";
            var result = await _connection.ExecuteAsync(query, new {Id = id});
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

    public async Task<IList<Category>> GetAllAsync(PaginationParams @params)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "SELECR * FROM categories order by id desc " +
                $"offset {@params.ScipCount} limit {@params.PageSize}";
            var result = (await _connection.QueryAsync<Category>(query)).ToList();  
            return result;
        }
        catch
        {
            return new List<Category>();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<Category?> GetByIdAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "SELECT * FROM categories where id = @Id";
            var result = await _connection.QuerySingleAsync<Category>(query, new {Id=id});
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

    public Task<int> UpdateAsync(long id, Category entity)
    {
        throw new NotImplementedException();
    }
}