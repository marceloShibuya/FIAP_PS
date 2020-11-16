using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PS.Cybertronics.Models
{
    [Table("TB_PRODUTO")]
    public class Produto
    {
        [Column("Id"), HiddenInput]
        public int ProdutoId { get; set; }

        public int? EmpresaId { get; set; }

        public Empresa Empresa { get; set; }

        public int? ClienteId { get; set; }


        public Cliente Cliente { get; set; }

        public IList<ProdutoUsuarios> ProdutoUsuarios { get; set; }

        [Display(Name = "Tipo de Serviço")]
        public TipoServico TipoServico { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Column("Dt_Garantia"), Display(Name = "Data da Garantia"), DataType(DataType.Date)]
        public DateTime DataGarantia { get; set; }

        [Column("Dt_Fabricacao"), Display(Name = "Data da Fabricação"), DataType(DataType.Date)]
        public DateTime DataFabricacao { get; set; }


    }
}