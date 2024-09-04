using ContactAppRestApi2.Models;
using ContactAppRestApi2.Repository;

namespace ContactAppRestApi2.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository = new ContactRepository();
        public void AddContactService(Contact contact)
        {
            _contactRepository.AddContact(contact);
        }

        public List<Contact> GetContactsService()
        {
            return _contactRepository.GetContacts();
        }
    }
}
