﻿namespace Bulky.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ISBN { get; set; } = null!;

        public string Author { get; set; } = null!;

        public double ListPrice { get; set; }

        public double Price { get; set; }

        public double Price50 { get; set; }

        public double Price100 { get; set; }
    }
}
