using ComputerHardwareECommerceApi.Domain.Models.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class ApplicationUser:IdentityUser
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber {  get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<CreditCard> CreditCards { get; set; }
        public IEnumerable<Iban> Ibans { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        [NotMapped]
        public string Role { get; set; }
    }
}
