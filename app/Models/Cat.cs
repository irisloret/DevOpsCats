using System;
using catsProject;
using Contentful.Core.Models;

namespace catsProject.Models
{
    public class Cat 
    {
        public string Breed { get; set; }

        public string Description { get; set; }

        public Asset Image { get; set; }
    }

    
}
