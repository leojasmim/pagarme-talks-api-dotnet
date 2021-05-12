using PagarmeTalks.Api.Models.Contracts;
using PagarmeTalks.Api.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace PagarmeTalks.Api.Models.Entities
{
    public class Customer
    {
        public Customer(CustomerRequest request)
        {
            var random = new Random();
            ExternalId = "cus_" + random.Next(9999999);
            Name = request.Name;
            Email = request.Email;
            Document = request.Document;
            DocumentType = request.DocumentType;

            Account = request.Account != null ? new Account(request.Account) : null;
            Address = request.Address != null ? new Address(request.Address) : null;
            if(request.Phones != null)
            {
                Phones = new List<Phone>();
                foreach(PhoneRequest phone in request.Phones)
                {

                    Phones.Add(new Phone() { AreaCode = phone.AreaCode, Number = phone.Number, Type = phone.Type});
                }
            }

            Contact = request.Contact;
        }

        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }

        public Account Account { get; set; }
        public Address Address { get; set; }
        public List<Phone> Phones { get; set; }
        public IContact Contact { get; set; }


        public void Update(CustomerRequest request)
        {
            Name = request.Name;
            Email = request.Email;
            Document = request.Document;
            DocumentType = request.DocumentType;
        }
    }
}
