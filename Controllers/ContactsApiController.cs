using MVCwithWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace MVCwithWebAPI.Controllers
{
    public class ContactsApiController : ApiController
    {
        private readonly IContactRepository _iContactRepository = new ContactRepository();

        [HttpGet]
        [Route("api/Contacts/Get")]
        public async Task<IEnumerable<Contact>> Get()
        {
            return await _iContactRepository.GetContacts();
        }

        [HttpPost]
        [Route("api/Contacts/Create")]
        public async Task CreateAsync([FromBody] Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _iContactRepository.Add(contact);
            }
        }

        [HttpGet]
        [Route("api/Contacts/Details/{id}")]
        public async Task<Contact> Details(int id)
        {
            var result = await _iContactRepository.GetContacts(id);
            return result;
        }

        [HttpPut]
        [Route("api/Contact/Edit")]
        public async Task EditAsync([FromBody] Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _iContactRepository.Update(contact);
            }
        }

        [HttpDelete]
        [Route("api/Contacts/Delete/{id}")]
        public async Task DeleteConfirmedAsync(int id)
        {
            await _iContactRepository.Delete(id);
        }
    }
}