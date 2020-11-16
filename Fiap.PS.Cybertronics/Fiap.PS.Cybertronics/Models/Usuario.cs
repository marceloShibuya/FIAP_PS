using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PS.Cybertronics.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Column("Id")]
        public int UsuarioId { get; set; }

        public IList<ProdutoUsuarios> ProdutoUsuarios { get; set; }

        public string Email { get; set; }

        public string Nome { get; set; }

        public Cargo Cargo { get; set; }

        public string Senha { get; set; }

        [MaxLength(14)]
        public string Cpf { get; set; }

        public string Contato { get; set; }

        public string Endereco { get; set; }
    }
}
