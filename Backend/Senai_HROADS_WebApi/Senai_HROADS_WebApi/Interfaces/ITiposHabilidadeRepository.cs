using Senai_HROADS_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_HROADS_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsávelo pelo TiposHabilidadeRepository
    /// </summary>
    interface ITiposHabilidadeRepository
    {
        /// <summary>
        /// Lista todos os TiposHabilidadeRepository
        /// </summary>
        /// <returns></returns>
        List<TiposHabilidade> ListarTodos();

        /// <summary>
        /// Cadastra um novo novoTiposHabilidade
        /// </summary>
        /// <param name="novoTiposHabilidade"></param>
        void Cadastrar(TiposHabilidade novoTiposHabilidade);

        /// <summary>
        /// Deleta um Tipo de Habilidade
        /// </summary>
        /// <param name="IdTipos"> id do Tipo Habilidade que será deletado</param>
        void Deletar(int IdTipos);


        /// <summary>
        /// Busca um idTipos pelo seu id
        /// </summary>
        /// <param name="IdTipos">id do idTipos que será buscado</param>
        /// <returns></returns>
        Usuario BuscarId(int IdTipos);

        /// <summary>
        /// Atualiza os dados de um idTipos existente
        /// </summary>
        /// <param name="IdTipos">id do TipoHabilidade que será atualizado</param>
        /// <param name="tiposHabilidadeAtualizado">objeto idTiposAtualizado com as novas informações</param>
        void Atualizar(int IdTipos, TiposHabilidade IdTiposAtualizado);

    }
}
