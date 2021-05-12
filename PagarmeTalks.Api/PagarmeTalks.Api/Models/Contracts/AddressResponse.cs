using PagarmeTalks.Api.Models.Entities;

namespace PagarmeTalks.Api.Models.Contracts
{
    public class AddressResponse
    {
        public AddressResponse(Address address)
        {
            Street = address.Street;
            Number = address.Number;
            City = address.City;
            State = address.State;
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
