using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    class Prod : InterfaceMakeString
    {
        public int articule;
        public int walue;

        public Prod(int a, int w)
        {
            articule = a;
            walue = w;
        }

        public string MakeString()
        {
            string str;
            str = articule.ToString() + ";" + walue.ToString();
            return str;
        }
    }
}
