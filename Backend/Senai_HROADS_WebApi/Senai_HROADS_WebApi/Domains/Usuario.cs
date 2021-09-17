using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_HROADS_WebApi.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }

        [Required(ErrorMessage ="É necessário informar o e-mail!")]
        [StringLength(40, MinimumLength =3, ErrorMessage ="O email deve conter entre 3 a 40 caracteres.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "É necessário informar a senha!")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "A senha deve conter entre 3 a 40 caracteres.")]
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
