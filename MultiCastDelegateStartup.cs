using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MultiCastDelegateStartup
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

            NumberChanger nc2 = new NumberChanger(MultNum);

            NumberChanger nc3 = nc1;
            nc3 += nc2;

            Console.WriteLine("The MultNum returns " + nc3(10).ToString());
            
        }
    }
}
