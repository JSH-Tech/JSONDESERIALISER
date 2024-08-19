using System.Text.Json;

namespace JSONDESERIALISER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = """
            [
                {
                    "titre": "Harry Potter, I : Harry Potter à l'école des sorciers",
                    "auteur": "J.K. Rowling",
                    "nbPages": 320,
                    "ISBN": "2070584623"
                },
                {
                    "titre": "Harry Potter, II : Harry Potter et la Chambre des Secrets",
                    "auteur": "J.K. Rowling",
                    "nbPages": 368,
                    "ISBN": "207058464X"
                },
                {
                    "titre": "Harry Potter, III : Harry Potter et le prisonnier d'Azkaban",
                    "auteur": "J.K. Rowling",
                    "nbPages": 448,
                    "ISBN": "2070584925"
                }
            ]
            """;

            List<Livre>? livres=JsonSerializer.Deserialize<List<Livre>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive=true});

            if (livres is not null )
            {
                foreach (var item in livres)
                {
                    Console.WriteLine($"Titre: {item.Titre} Auteur: {item.Auteur} ISBN: {item.ISBN} nombre de pages: {item.NbPages}");
                }
            }
        }
    }
}
