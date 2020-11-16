using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PS.Cybertronics.Models
{
    public class ProdutoUsuarios
    {
        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

    }
}
