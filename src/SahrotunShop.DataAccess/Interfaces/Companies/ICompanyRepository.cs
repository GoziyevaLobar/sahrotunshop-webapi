using SahrotunShop.DataAccess.Common.Intefaces;
using SahrotunShop.Domain.Entities.Companies;

namespace SahrotunShop.DataAccess.Interfaces.Companies;

public interface ICompanyRepository : IRepository<Company, Company>,
    IGetAll<Company>
{

}
