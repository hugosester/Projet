using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Case
    {
       public enum CaseType { Desert, Plaine, Lac, Foret };
        
        public int X;
        public int Y;
        public CaseType Type;
        public string Description;
        public string Hero;


        public Case(int x, int y, CaseType t, string D)
        {
            X = x;
            Y = y;
            Type = t;
            Description = D;
            Hero = null;
            /*Random r = new Random(DateTime.Now.Millisecond);
            if (r.Next() % 100 > 50)
            {
                Item = new Potion("Soin", "Potion de soin", 1, 2, Potion.Potion.Heal);
            }
            else
                Item = null;*/
        }

        public void StartFight()
        {

        }
    }
}