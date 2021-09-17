using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_HROADS_WebApi.Domains
{
    public partial class Personagem
    {
        public int IdPersonagem { get; set; }
        public int? IdClasse { get; set; }


        [Required(ErrorMessage ="O nome do personagem é obrigatório!")]
        public string NomePersonagem { get; set; }


        [Required(ErrorMessage = "A capacidade máxima vida precisa ser informada!")]
        public short CapacidadeMaxVida { get; set; }


        [Required(ErrorMessage = "A capacidade máxima mana precisa ser informada!")]
        public short CapacidadeMaxMana { get; set; }


        [Required(ErrorMessage ="É necessário informar a data de criação do personagem")]
        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }


        [Required(ErrorMessage = "É necessário informar a data de atualização do personagem")]
        [DataType(DataType.Date)]
        public DateTime DataAtualizacao { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
    }
}
