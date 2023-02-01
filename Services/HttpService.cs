using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace Wise.Services
{
    public class APIClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public APIClient(string baseUrl)
        {
            _httpClient = new HttpClient();
            _baseUrl = baseUrl;
        }

        public async Task<WiseUser[]> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<WiseUser[]>();

            return result;
        }

        public async Task<List<WiseUser>> ObtenerDatosUsuarios()
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:7086/api/users");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al obtener los datos de los usuarios");
            }

            var json = await response.Content.ReadAsStringAsync();
            var usuarios = JsonSerializer.Deserialize<List<WiseUser>>(json);
            return usuarios;
        }

    }
}