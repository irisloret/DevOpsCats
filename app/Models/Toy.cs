using System;
using catsProject;
using Contentful.Core.Models;

namespace catsProject.Models
{
    public class Toy
    {
        public string NameToy { get; set; }

        public int Price { get; set; }

        public string DescriptionToy { get; set; }

        public Asset ToyImage { get; set; }
    }
}
