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
    public class ClassesController : ControllerBase
    {
        /// <summary>
        /// Objeto _classeRepository que irá receber todos os métodos definidos na interface IClasseRepository
        /// </summary>
        private IClasseRepository _classeRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _classeRepository para que haja referência às implementações feitas no repositório ClasseRepository
        /// </summary>
        public ClassesController()
        {
            _classeRepository = new ClasseRepository();
        }

        /// <summary>
        /// Lista todos as Classes
        /// </summary>
        /// <returns>Uma lista de Classes com o status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_classeRepository.ListarTodos());
        }

        /// <summary>
        /// Busca uma classe através do seu id
        /// </summary>
        /// <param name="IdClasse">ID da Classe que será buscado</param>
        /// <returns>Uma classe encontrado com o status code 200 - Ok</returns>
        [HttpGet("{IdClasse}")]
        public IActionResult BuscarPorId(int IdClasse)
        {
            // Retorna uma Classe encontrada
            return Ok(_classeRepository.BuscarId(IdClasse));
        }

        /// <summary>
        /// Cadastra uma Classe
        /// </summary>
        /// <param name="novoClasse">Objeto novoClasse com as informações</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(Classe novoClasse)
        {
            // Faz a chamada para o método .Cadastrar enviando as informações de cadastro
            _classeRepository.Cadastrar(novoClasse);

            // Retorna um status code
            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza uma classe existente
        /// </summary>
        /// <param name="IdClasse">ID da classe que será atualizado</param>
        /// <param name="classeAtualizado">Objeto classeAtualizado com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("{IdClasse}")]
        public IActionResult Atualizar(int IdClasse, Classe classeAtualizado)
        {
            // Faz a chamada para o método .Atualizar enviando as novas informações
            _classeRepository.Atualizar(IdClasse, classeAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        /// <summary>
        /// Deleta uma classe existente
        /// </summary>
        /// <param name="IdClasse">ID da Classe que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{IdClasse}")]
        public IActionResult Deletar(int IdClasse)
        {
            // Faz a chamada para o método .Deletar enviando o id da Classe como parâmetro
            _classeRepository.Deletar(IdClasse);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
