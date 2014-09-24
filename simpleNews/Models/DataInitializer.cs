using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace simpleNews.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {
            var articles = new List<Article>
            {
                new Article { Title = "Will it be raining tomorrow?", Author = "alexroverandom", Body = "Yes, it is", Date = DateTime.Now, Type = "weather" },
                new Article { Title = "Why do you must see Nolan's film 'Inception'?", Author = "Kristopher Nolan", Body = "Because Nolan wants it", Date = DateTime.Now, Type = "hollywood" },
                new Article { Title = "Manchester City - Chelsea  1:1", Author = "alexroverandom", Body = "No winner. But Frank Lampard does not want to tell his story", Date = DateTime.Now, Type = "sports" },
                new Article { Title = "New update for Windows 8.1", Author = "Dart Weyder", Body = "It's the Dark side", Date = DateTime.Now, Type = "it" },
                new Article { Title = "JavaScript vs CoffeeScript", Author = "alexroverandom", Body = "TeaScripr will be winner. It's not interesting article", Date = DateTime.Now, Type = "it" }
            };
            articles.ForEach(s => context.Articles.Add(s));
            context.SaveChanges();
        }
    }
}