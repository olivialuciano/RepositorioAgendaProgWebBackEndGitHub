using AgendaAPI.DTOs;
using AgendaAPI.Entities;
using AgendaAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserRepository _userRepository { get; set; }
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_userRepository.GetAllUsers());
        }

        [HttpGet]
        [Route("GetOne/{Id}")]
        public IActionResult GetOneById(int Id)
        {
            List<User> usersToReturn = _userRepository.GetAllUsers();
            usersToReturn.Where(x => x.Id == Id).ToList();
            if (usersToReturn.Count > 0)
                return Ok(usersToReturn);
            return NotFound("Usuario inexistente");
        }

        [HttpPost]
        public IActionResult CreateUser(UserForCreationDTO userDTO)
        {
            _userRepository.CreateUser(userDTO);
            return NoContent();
        }
    }
}