using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_Events_City
{
    public enum Situation { Fire=1, Earthquake, Terrorism}
    
    public delegate void Reaction(Situation s);

    public class Police
    {
        public int cnt { set; get; }
        public string weapon { set; get; }

        public void react(Situation s)
        {
            if (s == Situation.Earthquake)
            {
                cnt = 50;
                Console.WriteLine("Прибыла полиция численностью {0}, для предотвращения мародерств в разрушенных зданиях!", cnt);
            }
            else if (s == Situation.Fire)
            {
                cnt = 2;
                Console.WriteLine("Дежурные численностью {0} полицейских, информируют пожарных о ситуации!", cnt);
            }
            else if (s == Situation.Terrorism)
            {
                cnt = 200;
                Console.WriteLine("Прибыла полиция численностью {0}, уничтожения террористов в городе", cnt);
            }
        }
    }
    public class Ambulance
    {
        public int cnt { set; get; }

        public void react(Situation s)
        {
            if (s == Situation.Earthquake)
            {
                cnt = 150;
                Console.WriteLine("Прибыла скорая помощь численностью {0} человек, для оказания медпомощи пострадавшим от землетрясения!", cnt);
            }
            else if (s == Situation.Fire)
            {
                cnt = 10;
                Console.WriteLine("Прибыла скорая помощь численностью {0} человек, для оказания медпомощи пострадавшим в огне!", cnt);
            }
            else if (s == Situation.Terrorism)
            {
                cnt = 50;
                Console.WriteLine("Прибыла скорая помощь численностью {0} человек, для оказания медпомощи пострадавшим в теракте!", cnt);
            }
        }
    }
    public class FireFighters
    {
        public int cnt { set; get; }
        public void react(Situation s)
        {
            if (s == Situation.Earthquake)
            {
                cnt = 20;
                Console.WriteLine("Прибыли пожарные численностью {0} человек, для предотвращения пожара при землетрясении!", cnt);
            }
            else if (s == Situation.Fire)
            {
                cnt = 90;
                Console.WriteLine("Прибыли пожарные численностью {0} человек, для тушения пожара!", cnt);
            }
            else if (s == Situation.Terrorism)
            {
                cnt = 25;
                Console.WriteLine("Прибыли пожарные численностью {0} человек, для тушения огня от взрывов!", cnt);
            }
        }
    }
}
