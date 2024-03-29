﻿using System;
using System.Windows;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP123_Assignment2.Models
{
    public static class TweetManager 
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME = @"C:\_test\Assignment_02_TweetFile.txt";

        static TweetManager()
        {
            TWEETS = new List<Tweet>();
            TextReader reader = new StreamReader(FILENAME);
            string line = reader.ReadLine();            
            while (line != null) 
            {                
                TWEETS.Add(Tweet.Parse(line));
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public static void Initialize()
        {
            Console.WriteLine("Initializer: ");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($" TWEET {i}: \n" + TWEETS[i]);
            }            
        }

        public static void ShowAll()
        {
            Console.WriteLine("\nShowing every tweet: ");
            foreach (Tweet x in TWEETS)
            {
                Console.WriteLine(x);
            }
        }

        public static void ShowAll(string tag)
        {
            string tag2 = tag.ToLower();
            string tag3 = char.ToUpper(tag2[0]) + tag2.Substring(1);
            List<Tweet> foundTweets = TWEETS.FindAll(tweet => tweet.Tag == tag3);            
            foreach (Tweet x in foundTweets)
            {
                Console.WriteLine(x);
            }
        }
    }
}
