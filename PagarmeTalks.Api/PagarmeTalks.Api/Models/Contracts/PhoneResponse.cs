using PagarmeTalks.Api.Models.Entities;
using PagarmeTalks.Api.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagarmeTalks.Api.Models.Contracts
{
    public class PhoneResponse : IPhone
    {
        public PhoneResponse()
        {

        }

        public string Number { get; set; }
        public string AreaCode { get; set; }
        public string Type { get; set; }
    }
}
