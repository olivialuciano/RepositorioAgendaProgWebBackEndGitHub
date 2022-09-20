using AgendaAPI.Entities;
using AgendaAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private ContactRepository _contactRepository { get; set; }

        public ContactController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_contactRepository.GetAllContacts());
        }

        [HttpGet]
        [Route("GetOne/{Id}")]
        public IActionResult GetOneById(int Id)
        {
            List<Contact> contactsToReturn = _contactRepository.GetAllContacts();
            contactsToReturn.Where(x => x.Id == Id).ToList();
            if (contactsToReturn.Count > 0)
                return Ok(contactsToReturn);
            return NotFound("Usuario inexistente");
        }

        [HttpPost]
        public IActionResult CreateContact(ContactForCreationDTO contactDTO)
        {
            _contactRepository.CreateContact(contactDTO);
            return NoContent();
        }
    }
}






