using System;
using System.ComponentModel.DataAnnotations;

namespace TrainingDotNetCoreMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Nmae { get; set; }

        [DataType(DataType.ImageUrl)]
        public string img { get; set; }
        public string show { get; set; }
        public string type { get; set; }
        public string time { get; set; }
    }
}
