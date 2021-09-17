using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_HROADS_WebApi.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            ClasseHabilidades = new HashSet<ClasseHabilidade>();
            Personagems = new HashSet<Personagem>();
        }

        public int IdClasse { get; set; }

        [Required(ErrorMessage ="O nome da classe é obrigatório!")]
        public string NomeClasse { get; set; }

        public virtual ICollection<ClasseHabilidade> ClasseHabilidades { get; set; }
        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
