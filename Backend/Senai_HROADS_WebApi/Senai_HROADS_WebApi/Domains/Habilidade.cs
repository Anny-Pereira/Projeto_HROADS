using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_HROADS_WebApi.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            ClasseHabilidades = new HashSet<ClasseHabilidade>();
            TiposHabilidades = new HashSet<TiposHabilidade>();
        }

        public int IdHabilidade { get; set; }
        public string NomeHabilidade { get; set; }

        public virtual ICollection<ClasseHabilidade> ClasseHabilidades { get; set; }
        public virtual ICollection<TiposHabilidade> TiposHabilidades { get; set; }
    }
}
