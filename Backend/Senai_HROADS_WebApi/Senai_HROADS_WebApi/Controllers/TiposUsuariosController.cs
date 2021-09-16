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
    public class TiposUsuariosController : ControllerBase
    {

        // Controller responsável pelos endpoints (URLs) referentes aos TiposUsuarios

        /// <summary>
        /// Objeto _tipoUsuarioRepository que irá receber todos os métodos definidos na interface ITiposUsuarioRepository
        /// </summary>
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _tipoUsuarioRepository para que haja referência às implementações feitas no repositório TipoUsuarioRepository
        /// </summary>
        public TiposUsuariosController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Lista todos os tiposUsuarios
        /// </summary>
        /// <returns>Uma lista de tiposUsuarios com o status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_tipoUsuarioRepository.ListarTodos());
        }

        /// <summary>
        /// Busca um tipoUsuario através do seu id
        /// </summary>
        /// <param name="IdTipoUsuario">ID do tipoUsuario que será buscado</param>
        /// <returns>Um tipoUsuario encontrado com o status code 200 - Ok</returns>
        [HttpGet("{IdTipoUsuario}")]
        public IActionResult BuscarPorId(int IdTipoUsuario)
        {
            // Retorna um tipo de Usuário encontrado
            return Ok(_tipoUsuarioRepository.BuscarId(IdTipoUsuario));
        }

        /// <summary>
        /// Cadastra um Tipo Usuario
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novoTipoUsuario com as informações</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(TipoUsuario novoTipoUsuario)
        {
            // Faz a chamada para o método .Cadastrar enviando as informações de cadastro
            _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);

            // Retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um TipoUsuario existente
        /// </summary>
        /// <param name="IdTipoUsuario">ID do tipoUsuario que será atualizado</param>
        /// <param name="tipoUsuarioAtualizado">Objeto TipoUsuarioAtualizado com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("{IdTipoUsuario}")]
        public IActionResult Atualizar(int IdTipoUsuario, TipoUsuario tipoUsuarioAtualizado)
        {
            // Faz a chamada para o método .Atualizar enviando as novas informações
            _tipoUsuarioRepository.Atualizar(IdTipoUsuario, tipoUsuarioAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um tipoUsuario existente
        /// </summary>
        /// <param name="IdTipoUsuario">ID do tipoUsuario que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{IdTipoUsuario}")]
        public IActionResult Deletar(int IdTipoUsuario)
        {
            // Faz a chamada para o método .Deletar enviando o id do tipoUsuario como parâmetro
            _tipoUsuarioRepository.Deletar(IdTipoUsuario);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
