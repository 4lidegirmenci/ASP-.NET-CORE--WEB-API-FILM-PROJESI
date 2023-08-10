namespace Entities.RequestFeatures
{
    public class FilmParameters : RequestParameters
	{
        public uint MinImdb { get; set; } 

		public uint MaxImdb { get; set; } = 10;

        public bool ValidImdbRange => MaxImdb > MinImdb;

        public string? SearchTerm { get; set; }
    }
}
