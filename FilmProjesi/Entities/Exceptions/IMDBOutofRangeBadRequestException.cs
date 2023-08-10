namespace Entities.Exceptions
{
    public class IMDBOutofRangeBadRequestException : BadRequestException
    {
        public IMDBOutofRangeBadRequestException() : base("Maximum IMDB should be less than 10 and greater than 0.")
        {

        }
    }
}
