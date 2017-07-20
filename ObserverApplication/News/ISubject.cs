using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverApplication.Widgets;

namespace ObserverApplication.News
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }
}
