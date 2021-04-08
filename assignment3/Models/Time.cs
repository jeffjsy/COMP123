using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_assignment3.Models;

namespace COMP123_assignment3.Models
{
    struct Time
    {
        public int hours { get; private set; }
        public int minutes { get ; private set; }        

        public Time(int hours, int minutes = 0, int v = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
        }        

        public override string ToString()
        {
            return $"{hours}:{minutes:00}";
        }
        
        public static bool operator ==(Time lhs, Time rhs)
        {
            int lhsTotal = (lhs.hours * 60) + lhs.minutes;
            int rhsTotal = (rhs.hours * 60) + rhs.minutes;
            int timeTotal = Math.Abs(lhsTotal - rhsTotal);   
            if (timeTotal < 15)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }






    }

}
