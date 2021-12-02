using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCwithWebAPI.Models
{
    public interface ICountryRepository
    {
        Task Create(Country country);
        Task Update(Country country);
        Task Delete(int CountryId);
        Task<Country> GetCountry(int CountryId);
        Task<IEnumerable<Country>> GetCountry();

        
    }
}