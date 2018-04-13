using System;
using System.Collections.Generic;

namespace PracticalTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public List<string> Characteristics { get; set; }
        public string Image { get; set; }
    }
}
