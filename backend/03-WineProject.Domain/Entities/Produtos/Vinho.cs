using _03_WineProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WineProject.Domain.Entities.Produtos
{
    public class Vinho : Produto
    {
        public Guid Id { get; set; } 
        public TipoVinho TipoVinho { get; set; }  
    }
}
