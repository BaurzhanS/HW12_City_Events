using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW12_Events_City;

namespace HW12_Events_City
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateSituation(3);
        }

        static public event Reaction Caller;
        static Police p = new Police();
        static Ambulance a = new Ambulance();
        static FireFighters f = new FireFighters();

        public static void GenerateSituation(int num)
        {
            Caller += p.react;
            Caller += a.react;
            Caller += f.react;

            Random r = new Random();
            for (int i = 0; i < num; i++)
            {
                Situation s = (Situation)r.Next(1, 4);
                Console.WriteLine(s.ToString());
                Caller(s);
                Console.WriteLine();
            }
        }
        
        
    }
}
