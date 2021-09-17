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
    public class TiposHabilidadesController : ControllerBase
    {
        private ITiposHabilidadeRepository _tiposHabilidadeRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _classeHabilidadeRepositor para que haja referência às implementações feitas no repositório ClasseHabilidadeRepository
        /// </summary>
        public TiposHabilidadesController()
        {
            _tiposHabilidadeRepository = new TipoHabilidadeRepository();
        }

        
        //Listar Todos
        /// <summary>
        /// Lista todos os tiposHabilidade
        /// </summary>
        /// <returns>Uma lista de TiposHabilidade com o status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_tiposHabilidadeRepository.ListarTodos());
        }


        //Cadastrar
        /// <summary>
        /// Cadastra um TipoHabilidade
        /// </summary>
        /// <param name="novoTipoHabilidade">Objeto novoTipoHabilidade com as informações</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(TiposHabilidade novoTipoHabilidade)
        {
            _tiposHabilidadeRepository.Cadastrar(novoTipoHabilidade);

            return StatusCode(201);
        }


        //Deletar
        /// <summary>
        /// Deleta um tipo Habilidade existente
        /// </summary>
        /// <param name="Id">ID do tipo Habilidadee que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            _tiposHabilidadeRepository.Deletar(Id);

            return StatusCode(204);
        }


        //Buscar ID
        /// <summary>
        /// Busca um TipoHabilidade através do seu id
        /// </summary>
        /// <param name="Id">ID do TipoHabilidade que será buscado</param>
        /// <returns>Um TipoHabilidade encontrado com o status code 200 - Ok</returns>
        [HttpGet("{Id}")]
        public IActionResult BuscarPorId(int Id)
        {
            // Retorna um Classe Habilidade encontrado
            return Ok(_tiposHabilidadeRepository.BuscarId(Id));
        }



        //Atualizar
        /// <summary>
        /// Atualiza um TipoHabilidade existente
        /// </summary>
        /// <param name="Id">ID do TipoHabilidade que será atualizado</param>
        /// <param name="tipoHabilidadeAtualizado">Objeto TipoHabilidadeAtualizado com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id,TiposHabilidade tipoHabilidadeAtualizado)
        {
            // Faz a chamada para o método .Atualizar enviando as novas informações
            _tiposHabilidadeRepository.Atualizar(Id, tipoHabilidadeAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
