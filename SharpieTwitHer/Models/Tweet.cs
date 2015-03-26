using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpieTwitHer.Models
{
    public class Tweet
    {
        
        public int ID { get; set; }
        public virtual string User { get; set; }
        public string  TweetContent { get; set; }
        public DateTime CreatedAt { get; set; }

        public Tweet(string content)
        {
            TweetContent = content;
            CreatedAt = DateTime.Now;
        }

        public Tweet()
        {
        
        }
    }
}



