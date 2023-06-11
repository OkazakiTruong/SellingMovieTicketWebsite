using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webDatVeXemPhim
{
    public class Movie
    {
        private int id;
        private string movieName;
        private string img;
        private string movieTitle;
        private string movieDescription;
        private int movieTime;
        private int movieNewPrice;
        private int movieOldPrice;
        private string movieType;
        private int movieYear;
        private string movieNational;

        public Movie(int id, string movieName, string img, string movieTitle, string movieDescription, int movieTime, int movieNewPrice, int movieOldPrice, string movieType, int movieYear, string movieNational)
        {
            this.Id = id;
            this.MovieName = movieName;
            this.Img = img;
            this.MovieTitle = movieTitle;
            this.MovieDescription = movieDescription;
            this.MovieTime = movieTime;
            this.MovieNewPrice = movieNewPrice;
            this.MovieOldPrice = movieOldPrice;
            this.MovieType = movieType;
            this.MovieYear = movieYear;
            this.MovieNational = movieNational;
        }

        public int Id { get => id; set => id = value; }
        public string MovieName { get => movieName; set => movieName = value; }
        public string Img { get => img; set => img = value; }
        public string MovieTitle { get => movieTitle; set => movieTitle = value; }
        public string MovieDescription { get => movieDescription; set => movieDescription = value; }
        public int MovieTime { get => movieTime; set => movieTime = value; }
        public int MovieNewPrice { get => movieNewPrice; set => movieNewPrice = value; }
        public int MovieOldPrice { get => movieOldPrice; set => movieOldPrice = value; }
        public string MovieType { get => movieType; set => movieType = value; }
        public int MovieYear { get => movieYear; set => movieYear = value; }
        public string MovieNational { get => movieNational; set => movieNational = value; }
    }
}