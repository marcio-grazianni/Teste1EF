using pratico.Data;
using pratico.Models;

namespace Teste1EF
{
    internal class Program
    {
        static string codigo = "105800";
        static string linha = "--------------------------------------------------------------------------------------";

        private static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Entity Framework Core");

            using var context = new DataContext();

            var novoPais = new Pais
            {
                Nome = "País de Marcio",
                Codigo = codigo
            };

            context.Paises.Add(novoPais);
            context.SaveChanges();

            var novoEstado = new Estado
            {
                Nome = "Estado de Marcio",
                Sigla = "EM",
                CodigoIbge = 1234567,
                PaisId = novoPais.Id
                // Pais = novoPais
            };

            context.Estados.Add(novoEstado);
            context.SaveChanges();

            Console.WriteLine(linha);
            Console.WriteLine($"País inserido -> Id: {novoPais.Id}, Nome: {novoPais.Nome}, Código: {novoPais.Codigo}");
            Console.WriteLine($"Estado inserido -> Id: {novoEstado.Id}, Nome: {novoEstado.Nome}, CódigoIbge: {novoEstado.CodigoIbge}, PaisId: {novoEstado.Pais!.Id}, PaisNome: {novoEstado.Pais!.Nome}");
            Console.WriteLine(linha);
        }

        static void InserirPais(DataContext context)
        {
            var novoPais = new Pais
            {
                Nome = "País de Marcio",
                Codigo = codigo
            };

            context.Paises.Add(novoPais);
            context.SaveChanges();
            Console.WriteLine($"País inserido: {novoPais.Id}, {novoPais.Nome}, Código: {novoPais.Codigo}");

            var novoEstado = new Estado
            {
                Nome = "Estado de Marcio",
                Sigla = "EM",
                CodigoIbge = 2304400,
                PaisId = novoPais.Id
            };

            context.Estados.Add(novoEstado);
            context.SaveChanges();

            // Console.WriteLine($"País inserido: {novoPais.Id}, {novoPais.Nome}, Código: {novoPais.Codigo}");
        }

    }
}