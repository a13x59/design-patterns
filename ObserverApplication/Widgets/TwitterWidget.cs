﻿using ObserverApplication.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplication.Widgets
{
    public class TwitterWidget : IObserver, IWidget
    {
        private string _twitter;
        private ISubject _subject;

        public TwitterWidget(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            _twitter = twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }

        public void RemoveFormSubject()
        {
            _subject.RemoveObserver(this);
        }
    }
}
