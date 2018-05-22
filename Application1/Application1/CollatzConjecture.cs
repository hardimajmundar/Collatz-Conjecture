using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    public class evenoddfunction
    {
        public int evenoddfun(int positiveno)
        {
            if (positiveno % 2 == 0)
            {
                positiveno = positiveno / 2;
            }
            else
            {
                positiveno = (3 * positiveno) + 1;
            }
            return positiveno;
        }
    }

    public class mainfuncation
    {
        int count = 0;
        public int positiveno;
        public int mainfun()
        {
            Console.WriteLine("Enter Positive Number:");
            positiveno = int.Parse(Console.ReadLine());
            if (positiveno < 0)
            {
                Console.WriteLine("Number is nagative.");
                return 0;
            }
            else
            {
                evenoddfunction evod = new evenoddfunction();
                while (positiveno != 1)
                {
                    positiveno = evod.evenoddfun(positiveno);
                    count++;
                }
                Console.WriteLine("Number of steps:" + count);
            }
            return count;
        }
    }

    class CollatzConjecture
    {
        static void Main(string[] args)
        {
            mainfuncation fun = new mainfuncation();
            fun.mainfun();
            Console.ReadKey();
        }
    }
}
