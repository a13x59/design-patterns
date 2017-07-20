using ObserverApplication.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplication.Widgets
{
    public class TvWidget : IObserver, IWidget
    {
        private string _tv;
        private ISubject _subject;

        public TvWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _tv = tv;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("TV: {0}", _tv);
        }

        public void RemoveFormSubject()
        {
            _subject.RemoveObserver(this);
        }
    }
}
