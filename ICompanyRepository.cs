using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCwithWebAPI.Models
{
    public interface ICompanyRepository
    {
        Task Create(Company company);
        Task Update(Company company);
        Task Delete(int CompanyId);
        Task<Company> GetCompany(int CompanyId);
        Task<IEnumerable<Company>> GetCompany();

        
    }
}