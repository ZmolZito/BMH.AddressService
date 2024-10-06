using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMH.AddressService.Application.Dto
{
    public class AddressInputDto
    {
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public string PostalCode { get; set; }
        public string? Floor { get; set; }
        public string? door { get; set; }
    }
}
