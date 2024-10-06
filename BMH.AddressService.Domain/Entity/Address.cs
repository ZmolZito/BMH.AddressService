using BMH.AddressService.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMH.AddressService.Domain.Entity
{
    public class Address
    {
        public int Id { get; protected set; }
        public string Street { get; protected set; }
        public string City { get; protected set; }
        public int PostalCode { get; protected set; }
        public ValidStatus Valid { get; protected set; } = ValidStatus.Pending;

        protected void ValidateAddress()
        {
            throw new NotImplementedException();
        }

    }
}
