using AgendaAPI.DTOs;
using AgendaAPI.Entities;

namespace AgendaAPI.Repository
{
    public class UserRepository
    {
        List<User> FakeUsers = new List<User>()
            {
                new User()
                {
                    Email = "oli@gmail.com",
                    Name = "Olitaaa",
                    Password = "contraseñaaaa",
                    Id = 1,
                },
                new User()
                {
                    Email = "holi@gmail.com",
                    Name = "Holiivv",
                    Password = "TucontrasenaBro",
                    Id = 2,
                }
            };

        public List<User> GetAllUsers()
        {
            return FakeUsers;
        }

        public bool CreateUser(UserForCreationDTO userDTO)
        {
            User user = new User()
            {
                Name = userDTO.Name,
                Password = userDTO.Password,
                Id = userDTO.Id,
                Email = userDTO.Email,
            };
            FakeUsers.Add(user);
            return true;
        }

    }
}