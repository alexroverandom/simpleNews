using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace simpleNews.Models
{
    public class Article
    {
        public int Id { get; set; }

        [StringLength(60)]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public string Author { get; set; }

        public DateTime Date { get; set; }
        public string Type { get; set; }
    }
}