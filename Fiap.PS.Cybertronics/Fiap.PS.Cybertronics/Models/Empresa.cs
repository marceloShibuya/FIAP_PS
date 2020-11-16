using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PS.Cybertronics.Models
{
    [Table("TB_EMPRESA")]
    public class Empresa
    {
        [Column("Id")]
        public int EmpresaId { get; set; }

        public IList<Produto> Produtos { get; set; }

        public string Cnpj { get; set; }

        public string Nome { get; set; }

        public string Contato { get; set; }

    }
}