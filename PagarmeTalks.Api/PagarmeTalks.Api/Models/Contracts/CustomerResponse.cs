using PagarmeTalks.Api.Models.Contracts;
using PagarmeTalks.Api.Models.Entities;
using PagarmeTalks.Api.Models.Interfaces;
using System.Collections.Generic;

namespace PagarmeTalks.Api.Models
{
    public class CustomerResponse
    {
        public CustomerResponse(Customer customer)
        {
            Id = customer.ExternalId;
            Name = customer.Name;
            Email = customer.Email;
            Document = customer.Document;
            DocumentType = customer.DocumentType;
            Account = customer.Account != null ? new AccountResponse(customer.Account) : null;
            Address = customer.Address != null ? new AddressResponse(customer.Address) : null;
            if(customer.Phones != null)
            {
                Phones = new List<PhoneResponse>();
                foreach (Phone phone in customer.Phones)
                {

                    Phones.Add(new PhoneResponse() { AreaCode = phone.AreaCode, Number = phone.Number, Type = phone.Type });
                }
            }
            Contact = customer.Contact; 
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }
        public AccountResponse Account { get; set; }
        public AddressResponse Address { get; set; }
        public List<PhoneResponse> Phones { get; set; }
        public IContact Contact { get; set; }
    }
}
