using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Companies;
using SahrotunShop.Service.Dtos.Companies;

namespace SahrotunShop.Service.Interfaces.Companies;

public interface ICompanyService
{
    public Task<bool> CreateAsync(CompanyCreateDto dto);

    public Task<IList<Company>> GetAllAsync(PaginationParams @params);

    public Task<Company> GetByIdAsync(long companyId);

    public Task<bool> UpdateAsync(long companyId, CompanyUpdateDto dto);

    public Task<bool> DeleteAsync(long companyId);

}
