using ContactAppRestApi2.Data;
using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDbContext _dbContext = new ContactDbContext();
        public void AddContact(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();
        }
        public List<Contact> GetContacts()
        {
            return _dbContext.Contacts.ToList();
        }
    }
}
