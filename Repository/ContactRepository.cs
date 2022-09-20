using AgendaAPIProgWeb.Entities;

namespace AgendaAPIProgWeb.Repository
{
    public class ContactRepository
    {
        public static List<Contact> FakeContacts = new List<Contact>()//es basura es por ahora para los datos (hardcodear)
        {
            new Contact()
            {
                Id = 1,
                Name = "Oli",
                CelularNumber = 3423478556,
                TelephoneNumber = 4822259,
                Description = "La mejor ala derecha ofensiva :)",
            },
            new Contact()
            {
                Id = 2,
                Name = "Tucaralinda",
                CelularNumber = 3423478529,
                Description = "Hola jejejejeeeeeee",
            },
        };

        public List <Contact> GetAllContacts()
        {
            return FakeContacts;
        }
        public bool CreateContact(ContactForCreationDTO contactDTO)
        {
            Contact contact = new Contact()
            {
                Name = contactDTO.Name,
                Password = contactDTO.Password,
                Id = contactDTO.Id,
                Email = contactDTO.Email,
            };
            FakeContacts.Add(contact);
            return true;
        }

    }
}
