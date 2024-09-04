using ContactAppRestApi2.Models;

namespace ContactAppRestApi2.Services
{
    public interface IContactDetailServices
    {
        public void AddContactDetailService(ContactDetail contactDetail);

        public List<ContactDetail> GetContactDetailService();
    }
}
