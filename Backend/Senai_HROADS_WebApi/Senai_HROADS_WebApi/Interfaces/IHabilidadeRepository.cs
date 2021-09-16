using Senai_HROADS_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_HROADS_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsávelo pelo HabilidadeRepository
    /// </summary>
    interface IHabilidadeRepository
    {
        /// <summary>
        /// Lista todos os Habilidade
        /// </summary>
        /// <returns></returns>
        List<Habilidade> ListarTodos();

        /// <summary>
        /// Cadastra uma nova Habilidade
        /// </summary>
        /// <param name="Habilidade"></param>
        void Cadastrar(Habilidade habilidade);

        /// <summary>
        /// Deleta uma Habilidade
        /// </summary>
        /// <param name="Habilidade"> id da Habilidade que será deletado</param>
        void Deletar(int IdHabilidade);


        /// <summary>
        /// Busca uma Habilidade pelo seu id
        /// </summary>
        /// <param name="IdHabilidade">id do idHabilidade que será buscado</param>
        /// <returns></returns>
        Usuario BuscarId(int IdHabilidade);

        /// <summary>
        /// Atualiza os dados de um idHabilidade existente
        /// </summary>
        /// <param name="IdHabilidade">id do Habilidade e que será atualizado</param>
        /// <param name="Habilidade">objeto idHabilidadeAtualizado com as novas informações</param>
        void Atualizar(int IdHabilidade, Habilidade IdHabilidadeAtualizado);
    }
}
