using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Services
{
    public interface IContactService
    {
        public void AddContactService(Contact contact);

        public List<Contact> GetContactsService();
    }
}
