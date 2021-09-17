using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_HROADS_WebApi.Domains
{
    public partial class TiposHabilidade
    {
        public int IdTipos { get; set; }
        public int? IdHabilidade { get; set; }

        [Required(ErrorMessage = "O nome do tipo de habilidade deve ser informado!")]
        public string NomeTipo { get; set; }

        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
