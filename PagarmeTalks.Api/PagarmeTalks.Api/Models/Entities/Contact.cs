using System;

namespace PagarmeTalks.Api.Models.Entities
{
    public interface IContact
    {
        string Name { get; set; }
        string Email { get; set; }
    }

    public class Person : IContact
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }

    public class Organisation : IContact
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Address Headquarters { get; set; }
    }

   
}
