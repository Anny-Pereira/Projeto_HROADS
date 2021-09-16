using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_HROADS_WebApi.Domains;
using Senai_HROADS_WebApi.Interfaces;
using Senai_HROADS_WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_HROADS_WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    // Controller responsável pelos endpoints (URLs) referentes aos Usuario
    public class UsuariosController : ControllerBase
    {
        /// <summary>
        /// Objeto _usuarioRepository que irá receber todos os métodos definidos na interface IUsuarioRepository
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _usuarioRepository para que haja referência às implementações feitas no repositório UsuarioRepository
        /// </summary>
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Uma lista de usuários com o status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_usuarioRepository.ListarTodos());
        }

        /// <summary>
        /// Busca um usuario através do seu id
        /// </summary>
        /// <param name="IdUsuario">ID do usuario que será buscado</param>
        /// <returns>Um usuário encontrado com o status code 200 - Ok</returns>
        [HttpGet("{IdUsuario}")]
        public IActionResult BuscarPorId(int IdUsuario)
        {
            // Retorna um estúdio encontrado
            return Ok(_usuarioRepository.BuscarId(IdUsuario));
        }

        /// <summary>
        /// Cadastra um Usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario com as informações</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            // Faz a chamada para o método .Cadastrar enviando as informações de cadastro
            _usuarioRepository.Cadastrar(novoUsuario);

            // Retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um Usuário existente
        /// </summary>
        /// <param name="IdUsuario">ID do Usuario que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto usuarioAtualizado com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("{IdUsuario}")]
        public IActionResult Atualizar(int IdUsuario, Usuario usuarioAtualizado)
        {
            // Faz a chamada para o método .Atualizar enviando as novas informações
            _usuarioRepository.Atualizar(IdUsuario, usuarioAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um Usuário existente
        /// </summary>
        /// <param name="IdUsuario">ID do usuário que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{IdUsuario}")]
        public IActionResult Deletar(int IdUsuario)
        {
            // Faz a chamada para o método .Deletar enviando o id do usuário como parâmetro
            _usuarioRepository.Deletar(IdUsuario);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
