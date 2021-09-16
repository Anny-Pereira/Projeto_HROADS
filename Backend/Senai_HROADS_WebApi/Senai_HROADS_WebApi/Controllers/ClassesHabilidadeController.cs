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
    public class ClassesHabilidadeController : ControllerBase
    {
        /// <summary>
        ///  Objeto _ClasseHabilidadeRepository que irá receber todos os métodos definidos na interface IEstudioRepository
        /// </summary>

        private IClasseHabilidadeRepository _classeHabilidadeRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _classeHabilidadeRepositor para que haja referência às implementações feitas no repositório ClasseHabilidadeRepository
        /// </summary>
        public ClassesHabilidadeController()
        {
            _classeHabilidadeRepository = new ClasseHabilidadeRepository();
        }

        /// <summary>
        /// Lista todos os ClasseHabilidadeRepository
        /// </summary>
        /// <returns>Uma lista de ClasseHabilidade com o status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_classeHabilidadeRepository.ListarTodos());
        }


        /// <summary>
        /// Busca um ClasseHabilidade através do seu id
        /// </summary>
        /// <param name="Id">ID do classeHabilidade que será buscado</param>
        /// <returns>Um ClasseHabilidade encontrado com o status code 200 - Ok</returns>
        [HttpGet("{Id}")]
        public IActionResult BuscarPorId(int Id)
        {
            // Retorna um Classe Habilidade encontrado
            return Ok(_classeHabilidadeRepository.BuscarId(Id));
        }

        /// <summary>
        /// Cadastra uma ClasseHabilidade
        /// </summary>
        /// <param name="novoClasseHabilidade">Objeto novoClasseHabilidade com as informações</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(ClasseHabilidade novoClasseHabilidade)
        {
            // Faz a chamada para o método .Cadastrar enviando as informações de cadastro
            _classeHabilidadeRepository.Cadastrar(novoClasseHabilidade);

            // Retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um ClasseHabilidade existente
        /// </summary>
        /// <param name="Id">ID do Classe Habilidade que será atualizado</param>
        /// <param name="classeHabilidadeAtualizado">Objeto classeHabilidadeAtualizado com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id, ClasseHabilidade classeHabilidadeAtualizado)
        {
            // Faz a chamada para o método .Atualizar enviando as novas informações
            _classeHabilidadeRepository.Atualizar(Id, classeHabilidadeAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um Classe Habilidade existente
        /// </summary>
        /// <param name="Id">ID do Classe Habilidadee que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            // Faz a chamada para o método .Deletar enviando o id do Classe habilidade como parâmetro
            _classeHabilidadeRepository.Deletar(Id);

            // Retorna um status code
            return StatusCode(204);
        }

    }
}
