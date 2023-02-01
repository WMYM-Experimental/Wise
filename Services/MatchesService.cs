using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Wise.Models;

namespace Wise.Services
{
    public class MatchesService
    {
        public MatchesService()
        {

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

        //create a function for creating a match and send by post to an api
        public Match CreateMatch(int idPerson, int idMatch)
        {
            var match = new Match()
            {
                MatchId = idMatch,
                UserId = idPerson
            };
            return match;
        }

    }
}
