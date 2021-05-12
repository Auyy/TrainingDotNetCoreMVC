using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCtext.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }

        public string show { get; set; }
        public string type { get; set; }
        public string time { get; set; }
    }
}
