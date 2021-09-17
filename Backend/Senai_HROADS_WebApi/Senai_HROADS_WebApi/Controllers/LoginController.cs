using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Senai_HROADS_WebApi.Domains;
using Senai_HROADS_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Senai_HROADS_WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }


        [HttpPost("Login")]
        public IActionResult Login(Usuario login)
        {
            Usuario usuarioBuscado = _UsuarioRepository.Login(login.Email, login.Senha);

            if (usuarioBuscado != null)
            {
                //return Ok(usuarioBuscado);

                var minhasclaims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString()),
                    new Claim("Claim Personalizada", "Anny e Rezende")
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Autenticacao_ChaveInLock"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var MeuToken = new JwtSecurityToken(
                    issuer: "Inlock.webAPI",
                    audience: "Inlock.webAPI",
                    claims: minhasclaims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(MeuToken)
                });
            }

            return NotFound("Email ou senha inválidos");
        }
    }
}
