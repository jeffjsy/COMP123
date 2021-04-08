using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_assignment3.Models;

namespace COMP123_assignment3.Models
{
    class Theatre
    {
        private List<Show> shows;
        public string Name { get; }

        public Theatre(string name)
        {
            this.Name = name;
            shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void PrintShows()
        {
            int showCounter = 1;
            foreach (Show x in shows)
            {
                Console.WriteLine($"Theatre: {Name}");
                Console.WriteLine($"All shows. #{showCounter}");
                Console.WriteLine(x);
                showCounter++;
            }
        }

        public void PrintShows(Genre genre)
        {
            int showCounter = 1;
            List<Show> showGenre = shows.FindAll(show => show.Movie.Genre.HasFlag(genre));
            foreach (Show x in showGenre)
            {
                Console.WriteLine($"Theatre: {Name}");
                Console.WriteLine($"Shows in the {genre} genre. #{showCounter}");
                Console.WriteLine(x);
                showCounter++;
            }
        }

        public void PrintShows(Day day)
        {
            int showCounter = 1;
            List<Show> showDay = shows.FindAll(show => show.Day == day);
            foreach (Show x in showDay)
            {
                Console.WriteLine($"Theatre: {Name}");
                Console.WriteLine($"Showings on {day}. #{showCounter}");
                Console.WriteLine(x);
                showCounter++;
            }
        }

        public void PrintShows(Time time)
        {
            int showCounter = 1;
            List<Show> showTime = shows.FindAll(show => show.Time == time);
            foreach (Show x in showTime)
            {
                Console.WriteLine($"Theatre: {Name}");
                Console.WriteLine($"Showings within 15 minutes of {time}. #{showCounter}");
                Console.WriteLine(x);
                showCounter++;
            }
        }

        public void PrintShows(string actor)
        {
            int showCounter = 1;
            List<Show> showActor = shows.FindAll(show => show.Movie.Cast.Contains(actor));
            foreach (Show x in showActor)
            {
                Console.WriteLine($"Theatre: {Name}");
                Console.WriteLine($"Showings featuring {actor}. #{showCounter}");
                Console.WriteLine(x);
                showCounter++;
            }            
        }

        public void PrintShows(Day day, Time time)
        {
            int showCounter = 1;
            List<Show> showDay = shows.FindAll(show => show.Day == day);
            List<Show> showDayTime = showDay.FindAll(show => show.Time == time); 
            foreach (Show x in showDayTime)
            {
                Console.WriteLine($"Theatre: {Name}");
                Console.WriteLine($"Showings on {day} within 15 minutes of {time}. #{showCounter}");
                Console.WriteLine(x);
                showCounter++;
            }           
        }
    }
}
