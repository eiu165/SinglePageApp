using System;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models {

    public class Product
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 1000000)]
        public decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string ProductDescription { get; set; }
    }
}
