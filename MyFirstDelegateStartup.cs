using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MyFirstDelegateStartup
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }


        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            Console.WriteLine("The AddNum returns " + nc1(10).ToString());

            NumberChanger nc2 = new NumberChanger(MultNum);
            Console.WriteLine("The MultNum returns " + nc2(10).ToString());
        }
    }
}
