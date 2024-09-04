using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Repository
{
    public interface IContactDetailRepository
    {
        public void AddContactDetail(ContactDetail contactDetail);
        public List<ContactDetail> GetContactDetail();
    }
}
