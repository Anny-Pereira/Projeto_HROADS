using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_HROADS_WebApi.Domains
{
    public partial class TiposHabilidade
    {
        public int IdTipos { get; set; }
        public int? IdHabilidade { get; set; }
        public string NomeTipo { get; set; }

        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
