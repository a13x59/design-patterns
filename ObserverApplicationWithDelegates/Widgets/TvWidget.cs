using ObserverApplicationWithDelegates.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplicationWithDelegates.Widgets
{
    public class TvWidget : IWidget
    {
        private string _tv;

        public void Update(object sender, NewsEventArgs e)
        {
            _tv = e.Tv;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("TV: {0}", _tv);
        }
    }
}
