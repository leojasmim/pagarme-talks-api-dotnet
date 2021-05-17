using PagarmeTalks.Api.Models.Contracts;
using System;

namespace PagarmeTalks.Api.Models.Entities
{
    public class Account
    {
        public Account(AccountRequest request)
        {
            Balance = request.Balance;
            Since = request.Since;
        }
        public decimal Balance { get; set; }
        public DateTime Since { get; set; }
    }
}
