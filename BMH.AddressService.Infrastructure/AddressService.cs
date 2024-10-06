using BMH.AddressService.Application.Dto;
using BMH.AddressService.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMH.AddressService.Infrastructure
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        async Task<string> IAddressService.ValidateAddress(AddressInputDto addressDto)
        {
            var response = await _httpClient.GetStringAsync($"/adresser?vejnavn={addressDto.Street}");

            return response;
        }
    }
}
