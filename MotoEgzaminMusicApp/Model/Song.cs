namespace MotoEgzaminMusicApp
{


    public class Song
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private string AlbumName { get; set; }
        private double Length { get; set; }

        public Song(string title, string author, string albumName, double length)
        {
            Title = title;
            Author = author;
            AlbumName = albumName;
            Length = length;
        }
    }
}