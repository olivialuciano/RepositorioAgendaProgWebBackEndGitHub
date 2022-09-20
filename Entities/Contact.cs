﻿namespace AgendaAPIProgWeb.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long CelularNumber { get; set; }
        public long? TelephoneNumber { get; set; }
        public string? Description { get; set; }
        public User User { get; set; }       //los contactos tienen que estar asociados al usuario dueño de los contactos
    }
}
