using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMH.AddressService.Application.Dto;

namespace BMH.AddressService.Application
{
    public interface IAddressService
    {
        Task<string> ValidateAddress(AddressInputDto addressDto);
    }
}
