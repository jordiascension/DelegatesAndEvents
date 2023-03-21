using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MainEventClass
    {
        static void Main(string[] args)
        {
            EventTest e = new EventTest(5);
            e.ChangeNum += new NumManipulationHandler(EventExecuted);
            e.SetValue(7);
            e.SetValue(11);
            Console.ReadKey();
        }

        public static  void EventExecuted()
        {
            Console.WriteLine("Method executed via event");
        }
    }
}
