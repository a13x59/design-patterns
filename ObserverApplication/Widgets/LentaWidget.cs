using ObserverApplication.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplication.Widgets
{
    public class LentaWidget : IObserver, IWidget
    {
        private string _lenta;
        private ISubject _subject;

        public LentaWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _lenta = lenta;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Lenta: {0}", _lenta);
        }

        public void RemoveFormSubject()
        {
            _subject.RemoveObserver(this);
        }
    }
}
