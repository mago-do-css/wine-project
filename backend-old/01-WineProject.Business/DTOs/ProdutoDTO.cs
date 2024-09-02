using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WineProject.Business.DTOs
{
    public class ProdutoDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal Preco { get; set; }
        public float Peso { get; set; }
        public string? Marca { get; set; }
        public string? Descricao { get; set; }
    }
}
