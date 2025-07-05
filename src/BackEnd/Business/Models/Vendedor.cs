namespace Business.Models
{
    public class Vendedor : Entity
    {
        public Guid UserId { get; set; }

        public List<Produto>? Produtos;

        public bool? Ativo {  get; set; }
    }
}