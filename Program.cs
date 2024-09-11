using pratico.Data;
using pratico.Models;

namespace Teste1EF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Entity Framework Core");

            using (var db = new DataContext())
            {
                var pais = new Pais()
                {
                    Nome = "País de Marcio",
                    Codigo = 1058
                };
                db.Paises.Add(pais);
                db.SaveChanges();
            }
        }
    }
}