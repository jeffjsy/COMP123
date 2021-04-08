using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_assignment3.Models;

namespace COMP123_assignment3.Models
{
    class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Day day, double price, Time time)
        {
            this.Movie = movie;
            this.Day = day;
            this.Price = price;
            this.Time = time;
        }

        public override string ToString()
        {
            return $"Price: {this.Price:c}\n" +
                   $"Day: {this.Day}\n" +
                   $"Movie: {this.Movie}\n" +
                   $"Time: {this.Time}\n";
        }

    }
}
