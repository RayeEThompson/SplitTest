﻿using System;
namespace SplitProjectApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public bool IsDev { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public Joke()
        {
        }
    }
}
