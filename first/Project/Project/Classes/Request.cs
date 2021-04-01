using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    class Request
    {
        public int magId;
        public int articule;
        public int count;
        public int reqId;

        public Request(int mI, int ar, int co,int rI)
        {
            magId = mI;
            articule = ar;
            count = co;
            reqId = rI;
        }
        public Request()
        {
            magId = -1;
            articule = -1;
            count = -1;
            reqId = -1;
        }
        public Request(string mI, string ar, string co, string rI)
        {
            magId = Convert.ToInt32(mI);
            articule = Convert.ToInt32(ar);
            count = Convert.ToInt32(co);
            reqId = Convert.ToInt32(rI);
        }

        public string MakeString()
        {
            string result;
            result = magId.ToString() + ";" + articule.ToString() +";"+ count.ToString() + ";"+ reqId.ToString();
            return result;
        }
    }
}
