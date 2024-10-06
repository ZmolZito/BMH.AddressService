using BMH.AddressService.Application.Dto;
using BMH.AddressService.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMH.AddressService.Domain.Enum;
using System.ComponentModel.Design.Serialization;

namespace BMH.AddressService.Infrastructure
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        async Task<ValidStatus> IAddressService.ValidateAddress(AddressInputDto addressDto)
        {
            var response = await _httpClient.GetStringAsync($"/adresser?vejnavn={addressDto.Street}");

            if (string.IsNullOrWhiteSpace(response) || response.Trim() == "[]" || response.Trim() == "[\\n\\n]" || response.Trim() == "[\n\n]")
            {
                return ValidStatus.Invalid;
            }

            return ValidStatus.Valid;
        }
    }
}
