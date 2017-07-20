using ObserverApplication.News;
using ObserverApplication.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggregator = new NewsAggregator();

            var twitterWidget = new TwitterWidget(newsAggregator);
            var lentaWidget = new LentaWidget(newsAggregator);
            var tvWidget = new TvWidget(newsAggregator);

            newsAggregator.NewNewsAvailable();
            Console.WriteLine();
            twitterWidget.RemoveFormSubject();
            newsAggregator.NewNewsAvailable();

            Console.ReadLine();
        }
    }
}
