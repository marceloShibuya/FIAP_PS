using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PS.Cybertronics.Models
{
    [Table("TB_CLIENTE")]
    public class Cliente
    {
        [Column("Id")]
        public int ClienteId { get; set; }

        public IList<Produto> Produtos { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

    }
}