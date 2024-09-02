namespace _03_WineProject.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal Preco { get; set; }
        public float Peso { get; set; } 
        public string? Marca { get; set; }
        public string? Descricao { get; set; }
    }
}
