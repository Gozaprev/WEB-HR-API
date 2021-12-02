using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCwithWebAPI.Models
{
    public interface IContactRepository
    {
        Task Create(Contact contact);
        Task Update(Contact contact);
        Task Delete(int ContactId);
        Task<Contact> GetContact(int ContactId);
        Task<IEnumerable<Contact>> GetContacts();

        
    }
}