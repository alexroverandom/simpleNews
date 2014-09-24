using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace simpleNews.Models
{
    public class NewsContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}