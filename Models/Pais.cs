namespace pratico.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Codigo { get; set; }

        public List<Estado>? Estados { get; set; }
    }
}