using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        //fields
        private string title;
        private string category;

        //properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        //methods
        public Movie()
        {

        }

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        public static List<string> GetMovieCategory(List<Movie> movies)
        {
            List<string> categoryTypes = new List<string>();
            foreach (Movie movie in movies)
            {
                if (!categoryTypes.Contains(movie.Category))
                {
                    categoryTypes.Add(movie.Category);
                }
            }

            return categoryTypes;
        }

        //public static void PrintMovieCategory(List<Movie> movies)
        //{
        //    List<string> movieCategory = Movie.GetMovieCategory(movies);
        //    for (int i = 0; i < movieCategory.Count; i++)
        //    {
        //        Console.Write($"{movieCategory[i]} ");
        //    } 
        //}
    }
}
