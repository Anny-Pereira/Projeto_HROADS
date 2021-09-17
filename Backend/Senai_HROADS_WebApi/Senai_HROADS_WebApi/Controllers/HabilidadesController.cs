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
    public class HabilidadesController : ControllerBase
    {
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadesController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }



        //Listar Todos
        /// <summary>
        /// Lista todas as habilidades
        /// </summary>
        /// <returns>uma lista de habilidades e um status code</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_habilidadeRepository.ListarTodos());
        }



        //Cadastrar
        /// <summary>
        /// Cadastra uma habilidade
        /// </summary>
        /// <param name="novaHabiliade">novo objeto que será cadastrado</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(Habilidade novaHabiliade)
        {
            _habilidadeRepository.Cadastrar(novaHabiliade);

            return StatusCode(201);
        }



        //Deletar
        /// <summary>
        /// Deleta uma habilidade existente
        /// </summary>
        /// <param name="id">id da habilidade que será deletada</param>
        /// <returns>retorna um status code</returns>
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _habilidadeRepository.Deletar(id);

            return StatusCode(204);
        }



        //Atualizar
        /// <summary>
        /// Atualiza uma habilidade existente
        /// </summary>
        /// <param name="id">id da habilidade que será atualizada</param>
        /// <param name="habilidadeAtualizada">objeto habilidade atualizado</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Habilidade habilidadeAtualizada)
        {
            _habilidadeRepository.Atualizar(id, habilidadeAtualizada);

            return StatusCode(204);
        }


        //BuscarId
        /// <summary>
        /// Busca uma habilidade pelo seu id
        /// </summary>
        /// <param name="id">id da habilidade que será buscada</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult BuscarId(int id)
        {
            return Ok(_habilidadeRepository.BuscarId(id));
        }

    }
}
