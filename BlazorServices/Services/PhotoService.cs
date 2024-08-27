using BlazorServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Services
{
    public class PhotoService
    {
        
        private readonly HttpClient _httpClient;

        public PhotoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Photos>> getPhotoList()
        {
            return await _httpClient.GetFromJsonAsync<List<Photos>>("https://jsonplaceholder.typicode.com/photos");
        }
    }
}
