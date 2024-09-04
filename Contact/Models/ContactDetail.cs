using System.ComponentModel.DataAnnotations.Schema;

namespace ContactAppRestApi2.Models
{
    public class ContactDetail
    {
        public int ContactDetailId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        [ForeignKey("Contact")]
        public int ContactId { get; set; }
    }
}
