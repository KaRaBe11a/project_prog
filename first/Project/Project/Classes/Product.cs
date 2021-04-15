using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    class Product : Prod
    {
        public string name;
        
        public Product(string n, int a, int w) : base(a, w)
        {
            name = n;
            articule = a;
            walue = w;
        }

        public new string MakeString()
        {
            string str = name + ";" + articule.ToString() + ";" + walue.ToString();
            return str;
        }

    }
}
