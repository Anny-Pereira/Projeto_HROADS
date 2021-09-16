using Senai_HROADS_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_HROADS_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsávelo pelo PersonagemRepository
    /// </summary>
    interface IPersonagemRepository
    {
        /// <summary>
        /// Lista todos os PersonagemRepository
        /// </summary>
        /// <returns></returns>
        List<Personagem> ListarTodos();

        /// <summary>
        /// Cadastra um novo Personagem
        /// </summary>
        /// <param name="Personagem"></param>
        void Cadastrar(Personagem personagem);

        /// <summary>
        /// Deleta um Personagem
        /// </summary>
        /// <param name="Personagem"> id do Personagem que será deletado</param>
        void Deletar(int IdPersonagem);


        /// <summary>
        /// Busca um Personagem pelo seu id
        /// </summary>
        /// <param name="IdPersonagem">id do idPersonagem que será buscado</param>
        /// <returns></returns>
        Usuario BuscarId(int IdPersonagem);

        /// <summary>
        /// Atualiza os dados de um idPersonagem existente
        /// </summary>
        /// <param name="IdPersonagem">id do Personagem e que será atualizado</param>
        /// <param name="Personagem">objeto idPersonagemAtualizado com as novas informações</param>
        void Atualizar(int IdPersonagem, Personagem IdPersonagemAtualizado);
    }
}
