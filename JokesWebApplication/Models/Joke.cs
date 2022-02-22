namespace JokesWebApplication.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string? jokeQuestion { get; set; }
        public string? JokeAnsver { get; set; }

        public Joke()
        {

        }
    }
}
