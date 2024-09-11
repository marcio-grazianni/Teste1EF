namespace pratico.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        // Propriedade de navegação para o relacionamento com Estado
        public ICollection<Estado> Estados { get; set; } = new List<Estado>();
    }
}
