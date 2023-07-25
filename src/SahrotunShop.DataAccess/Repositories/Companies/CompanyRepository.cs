using SahrotunShop.DataAccess.Interfaces.Companies;
using SahrotunShop.DataAccess.Utils;
using SahrotunShop.Domain.Entities.Companies;

namespace SahrotunShop.DataAccess.Repositories.Companies
{
    public class CompanyRepository : ICompanyRepository
    {
        public Task<long> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Company>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<Company?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(long id, Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
