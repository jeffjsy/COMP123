using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_assignment3.Models;

namespace COMP123_assignment3.Models
{
    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
       
        public List<string> Cast = new List<string>();

        public Movie(string name, int year, int length)
        {            
            this.Title = name;
            this.Year = year;
            this.Length = length;
            List<string> Cast = new List<string>();
        }

        public void AddActor(string actor)
        {            
            Cast.Add(actor);
        }

        public void SetGenre(Genre genre)
        {
            this.Genre = genre;
        }

        public override string ToString()
        {
            int runTimeMinutes = (Length % 60);
            int runTimeHours = (Length / 60);
            return $"{Title}\n" +
                   $"Year of release: {Year}\n" +
                   $"Runtime: {runTimeHours}h{runTimeMinutes}m \n" +
                   $"Cast: " + string.Join(", ", Cast);
        }
    }

    
}
