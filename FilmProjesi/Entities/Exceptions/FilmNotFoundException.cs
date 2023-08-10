namespace Entities.Exceptions
{
    public sealed class FilmNotFoundException : NotFoundException
    {
        public FilmNotFoundException(int id) : base($"The Film with id:{id} could not found.")
        {

        }
        
    }
}
