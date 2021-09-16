using Senai_HROADS_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_HROADS_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsávelo pelo TipoUsuarioRepository
    /// </summary>
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista todos os TipoUsuario
        /// </summary>
        /// <returns></returns>
        List<TipoUsuario> ListarTodos();


        /// <summary>
        /// Cadastra um novo TipoUsuario
        /// </summary>
        /// <param name="novoTipoUsuario"></param>
        void Cadastrar(TipoUsuario novoTipoUsuario);


        /// <summary>
        /// Deleta um TipoUsuario
        /// </summary>
        /// <param name="idUsuario">id do TipoUsuario que será deletado</param>
        void Deletar(int idTipoUsuario);


        /// <summary>
        /// Busca um TipoUsuario pelo seu id
        /// </summary>
        /// <param name="idUsuario">id do TipoUsuario que será buscado</param>
        /// <returns></returns>
        Usuario BuscarId(int idTipoUsuario);

        /// <summary>
        /// Atualiza os dados de um TipoUsuario existente
        /// </summary>
        /// <param name="idTipoUsuario">id do TipoUsuario que será atualizado</param>
        /// <param name="tipoUsuarioAtualizado">objeto TipoUsuarioAtualizado com as novas informações</param>
        void Atualizar(int idTipoUsuario, TipoUsuario tipoUsuarioAtualizado);

    }
}
