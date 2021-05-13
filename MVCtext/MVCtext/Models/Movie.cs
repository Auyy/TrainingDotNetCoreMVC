using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MVCtext.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }

        [DataType(DataType.Date)]
        public DateTime show { get; set; }
        public string type { get; set; }

        [DataType(DataType.Time)]
        public DateTime time { get; set; }
    }

}
