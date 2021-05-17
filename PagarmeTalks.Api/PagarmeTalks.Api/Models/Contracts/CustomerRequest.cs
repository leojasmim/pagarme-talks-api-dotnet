using PagarmeTalks.Api.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PagarmeTalks.Api.Models.Contracts
{
    public class CustomerRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }
        
        public AccountRequest Account { get; set; }
        public AddressRequest Address { get; set; }
        public List<PhoneRequest> Phones { get; set; }
        public IContact Contact { get; set; }

    }

}
