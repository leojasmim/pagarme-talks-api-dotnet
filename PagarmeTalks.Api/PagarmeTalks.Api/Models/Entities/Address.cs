using PagarmeTalks.Api.Models.Contracts;

namespace PagarmeTalks.Api.Models.Entities
{
    public class Address
    {
        public Address(AddressRequest request)
        {
            Street = request.Street;
            Number = request.Number;
            City = request.City;
            State = request.State;
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
