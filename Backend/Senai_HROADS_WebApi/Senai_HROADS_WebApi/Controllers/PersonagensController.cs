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
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }

        public PersonagensController()
        {
            _personagemRepository = new PersonagemRepository();
        }



        //ListarTodos
        /// <summary>
        /// Lista todos os personagens
        /// </summary>
        /// <returns>uma lista de estudios com status code</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_personagemRepository.ListarTodos());
        }


        //Cadastrar
        /// <summary>
        /// cadastra um novo personagem
        /// </summary>
        /// <param name="novoPersonagem">objeto personagem com as ionformações</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(Personagem novoPersonagem)
        {
            _personagemRepository.Cadastrar(novoPersonagem);

            return StatusCode(201);
        }


        //Deletar
        /// <summary>
        /// Deleta um personagem existente
        /// </summary>
        /// <param name="id">id do personagem que será deletado</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _personagemRepository.Deletar(id);

            return StatusCode(204);        
        }


        //Atualizar
        /// <summary>
        /// Atualiza um personagem existente
        /// </summary>
        /// <param name="id">id do personagem que será atualizado</param>
        /// <param name="personagemAtualizado">objeto Personagem com as informações novas</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Personagem personagemAtualizado)
        {
            _personagemRepository.Atualizar(id, personagemAtualizado);

            return StatusCode(204);
        }


        //BuscarId
        [HttpGet("{id}")]
        public IActionResult BuscarId(int id)
        {
            return Ok(_personagemRepository.BuscarId(id);
        }
    }
}
