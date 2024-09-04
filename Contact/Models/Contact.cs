using System.ComponentModel.DataAnnotations.Schema;

namespace ContactAppRestApi2.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public List<ContactDetail> ContactDetailsList { get; set; }
    }
}
