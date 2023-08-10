namespace Entities.DataTransferObject
{

    public record FilmDto
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public string Type { get; init; }

        public int IMDB { get; init; }
    }

}
