﻿namespace AbstractExample.Models
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public abstract void Display();

        public abstract void ReadData();
    }
}
