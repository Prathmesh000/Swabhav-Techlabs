using ContactAppRestApi2.Models;
using ContactAppRestApi2.Repository;

namespace ContactAppRestApi2.Services
{
    public class ContactDetailServices : IContactDetailServices
    {
        private readonly IContactDetailRepository _contactDetailRepository = new ContactDetailRepository();

        public void AddContactDetailService(ContactDetail contactDetail)
        {
            _contactDetailRepository.AddContactDetail(contactDetail);
        }

        public List<ContactDetail> GetContactDetailService()
        {
            return _contactDetailRepository.GetContactDetail();
        }
    }
}
