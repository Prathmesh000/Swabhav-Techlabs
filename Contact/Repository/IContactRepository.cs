using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Repository
{
    public interface IContactRepository
    {
        public void AddContact(Contact contact);
        public List<Contact> GetContacts();
    }
}
