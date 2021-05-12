using PagarmeTalks.Api.Models.Entities;
using System;

namespace PagarmeTalks.Api.Models.Contracts
{
    public class AccountResponse
    {
        public AccountResponse(Account account)
        {
            Balance = account.Balance;
            Since = account.Since;
        }

        public decimal Balance { get; set; }
        public DateTime Since { get; set; }
    }
}
