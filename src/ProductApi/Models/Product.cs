﻿namespace ProductApi.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double NetPrice { get; set; }
        public double GrossPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}