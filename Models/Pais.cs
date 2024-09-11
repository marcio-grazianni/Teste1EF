using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pratico.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }

    }
}