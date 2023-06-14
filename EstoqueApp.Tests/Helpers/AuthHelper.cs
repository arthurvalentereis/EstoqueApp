using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Tests.Helpers
{
    public class AuthHelper
    {
        public async Task<string> ObterTokenAcesso()
        {
            var resource = "https://usuariosapp1.azurewebsites.net/api/usuarios/autenticar";

            var request = new AuthRequest
            {
                Email = "usuarioteste@gmail.com",
                Senha = "@Admin123"
            };

            var content = TestHelper.CreateContent(request);
            var result = await new HttpClient().PostAsync(resource, content);
            var response = TestHelper.ReadResponse<AuthResponse>(result);
            return response.AccessToken;
        }
    }

    public class AuthRequest
    {
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }

    public class AuthResponse
    {
        public string? AccessToken { get; set; }
    }
}



