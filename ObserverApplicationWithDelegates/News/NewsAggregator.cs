using ObserverApplicationWithDelegates.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplicationWithDelegates.News
{
    public class NewsEventArgs
    {
        public NewsEventArgs(string twitter, string lenta, string tv)
        {
            Twitter = twitter;
            Lenta = lenta;
            Tv = tv;
        }

        public string Twitter { get; private set; }
        public string Lenta { get; private set; }
        public string Tv { get; private set; }
    }

    public delegate void NewsChangeEventHandler(object sender, NewsEventArgs e);

    public class NewsAggregator
    {
        private static Random _random;

        public event NewsChangeEventHandler NewsChanged;

        public NewsAggregator()
        {
            _random = new Random();
        }

        public string GetTwitterNews()
        {
            var news = new List<string>
                {
                    "News from Twitter #1",
                    "News from Twitter #2",
                    "News from Twitter #3"
                };

            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>
                {
                    "News from Lenta #1",
                    "News from Lenta #2",
                    "News from Lenta #3"
                };

            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string>
                {
                    "News from TV #1",
                    "News from TV #2",
                    "News from TV #3"
                };

            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            if (NewsChanged == null)//if no handlers defined return
                return;

            string twitter = GetTwitterNews();
            string lenata = GetLentaNews();
            string tv = GetTvNews();

            NewsChanged(this, new NewsEventArgs(twitter, lenata, tv));
        }
    }
}
