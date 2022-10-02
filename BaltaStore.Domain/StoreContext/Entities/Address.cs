using BaltaStore.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Address
    {
        public Address(string street,
            string number,
            string complement,
            string district,
            string city,
            string state,
            string contry,
            string zipCode,
            EAddressType type)
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            Contry = contry;
            ZipCode = zipCode;
            Type = type;
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Contry { get; set; }
        public string ZipCode { get; set; }
        public EAddressType Type { get; set; }
    }
}
