using System;
using catsProject;
using Contentful.Core.Models;

namespace catsProject.Models
{
    public class Bed
    {
        public string NameBed { get; set; }

        public int Price { get; set; }

        public Asset ImageBed { get; set; }


        public string Description { get; set; }

        public bool BigCat {get; set;}

    }
}