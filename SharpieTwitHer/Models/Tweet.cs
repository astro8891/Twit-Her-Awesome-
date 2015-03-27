using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SharpieTwitHer.Models
{
    public class Tweet
    {
        
        public int ID { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string TweetContent { get; set; }
        public DateTime CreatedAt { get; set; }

        public Tweet(string content)
        {
            TweetContent = content;
            CreatedAt = DateTime.Now;
        }

        public string TweetLimit(string tweetie)
        {
            var tweetlength = tweetie.Length;
            if (tweetlength>140)
            {
                throw new Exception("Your tweet is limited to 140 characters");
            }
            return tweetie;

        }
    }
}
//using System.Text;

//namespace SharpieTwitHer.Models
//{
//    public class Tweet
//    {
//        public int ID { get; set; }
//        public string Body { get; set; }
//    }
//}
