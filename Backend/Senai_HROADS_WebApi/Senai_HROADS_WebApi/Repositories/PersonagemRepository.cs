using Senai_HROADS_WebApi.Contexts;
using Senai_HROADS_WebApi.Domains;
using Senai_HROADS_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_HROADS_WebApi.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int IdPersonagem, Personagem PersonagemAtualizado)
        {
            Personagem personagemBuscado = ctx.Personagems.Find(IdPersonagem);

            if (PersonagemAtualizado != null)
            {
                ///Coloca o id TipoHabilidade???
                personagemBuscado.NomePersonagem = PersonagemAtualizado.NomePersonagem;

            }

            ctx.Personagems.Update(personagemBuscado);

            ctx.SaveChanges();

        }

        public Usuario BuscarId(int IdPersonagem)
        {
            return ctx.Personagems.FirstOrDefault(p => p.IdPersonagem == IdPersonagem);
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            ctx.Personagems.Add(novoPersonagem);

            ctx.SaveChanges();
        }

        public void Deletar(int IdPersonagem)
        {
            Habilidade habiliddeBuscada = BuscarId(IdPersonagem);

            ctx.Remove(habiliddeBuscada);

            ctx.SaveChanges();
        }

        public List<Personagem> ListarTodos()
        {
            return ctx.Habilidades.ToList();
        }
    }
}
