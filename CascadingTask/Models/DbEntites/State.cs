﻿namespace CascadingTask.Models.DbEntites
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }

    }
}
