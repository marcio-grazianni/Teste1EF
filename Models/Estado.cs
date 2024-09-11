namespace pratico.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        public int CodigoIbge { get; set; }
        public required Pais Pais { get; set; }
        // public required DateTime DataCadastro { get; set; }
        // public required DateTime HoraCadastro { get; set; }
    }
}
