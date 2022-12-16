using System;
using catsProject;
using Contentful.Core.Models;

namespace catsProject.Models
{
    public class Food 
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Gram { get; set; }

        public bool Kitten {get; set;}

        public Asset ImageFood { get; set; }

        public Asset RatingImage { get; set; }
    }

    
}
