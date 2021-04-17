using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Spisok<T>
    {
       public Spisok(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Spisok<T> Next { get; set; }
    }
}
