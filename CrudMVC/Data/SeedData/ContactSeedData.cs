using CrudMVC.Models;

namespace CrudMVC.Data.SeedData
{
    public class ContactSeedData
    {
        public static Contact[] GetContacts()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Juan Pérez",
                    Phone = "123456789",
                    Email = "juan.perez@example.com",
                    CreateTime = DateTime.Now
                },
                new Contact
                {
                    Id = 2,
                    Name = "María López",
                    Phone = "987654321",
                    Email = "maria.lopez@example.com",
                    CreateTime = DateTime.Now
                }
            };
        }
    }
}
