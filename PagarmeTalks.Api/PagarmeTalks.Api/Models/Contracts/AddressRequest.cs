﻿namespace PagarmeTalks.Api.Models.Contracts
{
    public class AddressRequest
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
