

using Entities.Models;

namespace FilmProjesi.Controllers.Data
{
    public static class ApplicationContext
    {
        public static List<Film> Films { get; set; }

        static ApplicationContext()
        {
            Films = new List<Film>()
            {
                new Film() { Id=1,Name="Recep İvedik",Type="Komedi",IMDB=5},
                new Film() { Id=2,Name="Recep İvedik 2",Type="Komedi",IMDB=6},
                new Film() { Id=3,Name="Recep İvedik 3",Type="Komedi",IMDB=7}
            };
        }
    }
}
