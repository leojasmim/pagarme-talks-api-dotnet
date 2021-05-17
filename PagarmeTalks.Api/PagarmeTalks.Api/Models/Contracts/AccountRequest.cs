using System;

namespace PagarmeTalks.Api.Models.Contracts
{
    public class AccountRequest
    {
        public decimal Balance { get; set; }
        public DateTime Since { get; set; }
    }
}
