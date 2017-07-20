using ObserverApplicationWithDelegates.News;
using ObserverApplicationWithDelegates.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplicationWithDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggregator = new NewsAggregator();

            var twitterWidget = new TwitterWidget();
            var lentaWidget = new LentaWidget();
            var tvWidget = new TvWidget();

            //handlers can be matched inside ctor of widget class
            //newsAggregator.NewsChanged += (s, a) => Console.WriteLine("{0} say: {1}, {2}, {3}", s, a.Lenta, a.Tv, a.Twitter);
            newsAggregator.NewsChanged += twitterWidget.Update;
            newsAggregator.NewsChanged += lentaWidget.Update;
            newsAggregator.NewsChanged += tvWidget.Update;

            newsAggregator.NewNewsAvailable();
            Console.WriteLine();
            newsAggregator.NewsChanged -= twitterWidget.Update;
            newsAggregator.NewNewsAvailable();

            Console.ReadLine();
        }
    }
}
