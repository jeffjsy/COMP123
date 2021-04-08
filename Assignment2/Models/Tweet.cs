using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment2.Models
{
    public class Tweet
    {
        private static int CURRENT_ID;
        public string From { get; }
        public string To { get; }     
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        
        public Tweet(string from, string to, string body, string tag)
        { //Assignment nevers asks us to make use of this constructor
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            Id = Convert.ToString(CURRENT_ID);
            CURRENT_ID++;
        }
        public Tweet(string from, string to, string body, string tag, string Id)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = Id;
        }

        public override string ToString()
        {            
            string message = this.Body;
            int messageLength = message.Length;
            if (messageLength > 40)
            {
                messageLength = 40;
            }
            string message2 = message.Substring(0, messageLength); 
            return $"    From: {this.From}\n" +
                   $"      To: {this.To}\n" +
                   $"   Tweet: {message2}\n" +
                   $"  Tag(s): {this.Tag}\n" +
                   $"Tweet ID: {this.Id}\n" +
                   $"=======================";
        }

        public static Tweet Parse(string line)
        {            
            string[] values = line.Split(new char[] { '\t' });            
            string tag = values[0];
            string to = values[1];                
            string from = values[2];            
            string body = values[3];                
            string Id = values[4];

            Tweet newTweet = new Tweet(from, to, body, tag, Id);
            return newTweet;            
        }
    }
}
