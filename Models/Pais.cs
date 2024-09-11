namespace pratico.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Codigo { get; set; }

        // Propriedade de navegação para o relacionamento com Estado
        // Desnecessário, pois o relacionamento ja foi
        // criado no mapeamento da tabela estado
        // public List<Estado> Estados { get; set; } = new List<Estado>();
    }
}
