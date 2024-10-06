using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMH.AddressService.Application.Dto;
using BMH.AddressService.Domain.Enum;

namespace BMH.AddressService.Application
{
    public interface IAddressService
    {
        Task<ValidStatus> ValidateAddress(AddressInputDto addressDto);
    }
}
