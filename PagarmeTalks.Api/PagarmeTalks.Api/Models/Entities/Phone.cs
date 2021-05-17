using PagarmeTalks.Api.Models.Interfaces;

namespace PagarmeTalks.Api.Models.Entities
{
    public class Phone : IPhone
    {
        public Phone()
        {
            
        }

        public string Number { get; set; }
        public string AreaCode { get; set; }
        public string Type { get; set; }
    }
}
