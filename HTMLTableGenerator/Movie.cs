﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTableGenerator
{
    //  Model !
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
    }
}
