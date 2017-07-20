using ObserverApplicationWithDelegates.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplicationWithDelegates.Widgets
{
    public class TwitterWidget : IWidget
    {
        private string _twitter;

        public void Update(object sender, NewsEventArgs e)
        {
            _twitter = e.Twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }
    }
}
