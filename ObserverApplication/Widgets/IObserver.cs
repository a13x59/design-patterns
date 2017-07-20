using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApplication.Widgets
{
    public interface IObserver
    {
        void Update(string twitter, string lenta, string tv);//todo: GetState(NewsEventArgs args) from ISubject and delete params

        void RemoveFormSubject();
    }
}
