namespace ReelScape
{
    public class Tmdb
    {
        public int id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public DateTime release_date { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }

        // Series
        public string original_name { get; set; }
    }

    public class TmdbResponse
    {
        public List<Tmdb> results { get; set; }
        public int total_pages { get; set; }
    }
}