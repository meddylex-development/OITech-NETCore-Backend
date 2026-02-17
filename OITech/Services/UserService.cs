using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OITech.Models.common;
using OITech.Models.Datos;
using OITech.Models.Request;
using OITech.Models.Response;
using OITech.Tools;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace OITech.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public UserResponse Auth(AuthRequest model)
        {
            UserResponse userresponse = new UserResponse();
            using (var DB = new OITechContext())
            {
                string spassword = Encrypt.GetSHA256(model.password);
                var usuario = DB.TblUsuarios.Where(d => d.Email == model.user &&
                                                    d.Password == spassword).FirstOrDefault();
                if (usuario == null) return null;
                userresponse.token = GetToken(usuario);
                userresponse.Email = usuario.Email;
                userresponse.Nombre = usuario.Nombre;
            }
            return userresponse;
        }
        private string GetToken(TblUsuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var llave = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, usuario.IdUsuario.ToString()),
                        new Claim(ClaimTypes.Email, usuario.Email),
                        new Claim(ClaimTypes.Name, usuario.Nombre)
                    }
                    ),
                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
