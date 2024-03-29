﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo.Models
{
    public class Book : BaseObject
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }

        public int AvailableCopies { get; set; } = 2;
    }
}
