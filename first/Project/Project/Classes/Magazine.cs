using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    class Magazine : InterfaceMakeString
    {
        public string magName;
        public int magId;

        public Magazine(string mn, int mi)
        {
            magName = mn;
            magId = mi;
        }
        public string MakeString()
        {
            string str = magName + ";" + magId.ToString();
            return str;
        }

    }
}
