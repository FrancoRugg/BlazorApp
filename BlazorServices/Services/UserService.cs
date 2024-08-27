using BlazorServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Users>> getUsersList()
        {
            return await _httpClient.GetFromJsonAsync<List<Users>>("https://jsonplaceholder.typicode.com/users");
        }
    }
}
