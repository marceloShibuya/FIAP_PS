
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PS.Cybertronics.Models
{
    [Table("TB_PRODUTO")]
    public class Produto
    {
        [Column("Id")]
        public int ProdutoId { get; set; }

        public int? EmpresaId { get; set; }

        public Empresa Empresa { get; set; }

        public IList<ProdutoUsuarios> ProdutoUsuarios { get; set; }

        public TipoServico TipoServico { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataGarantia { get; set; }

        public DateTime DataFabricacao { get; set; }


    }
}
