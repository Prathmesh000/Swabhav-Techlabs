using ContactAppRestApi2.Data;
using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Repository
{
    public class ContactDetailRepository : IContactDetailRepository
    {
        private readonly ContactDbContext _dbContext = new ContactDbContext();
        public void AddContactDetail(ContactDetail contactDetail)
        {
            _dbContext.ContactDetails.Add(contactDetail);
            _dbContext.SaveChanges();
        }
        public List<ContactDetail> GetContactDetail()
        {
            return _dbContext.ContactDetails.ToList();
        }
    }
}
