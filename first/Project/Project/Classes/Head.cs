using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    class Head<T>
    {
        public Spisok<T> head;
        public Spisok<T> tail;
        int count;

        //Добавление элемента
        public void Add(T data)
        {
            Spisok<T> node = new Spisok<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            count++;
        }

        //Удаление элемента
        public bool Remove(T data)
        {
            Spisok<T> current = head;
            Spisok<T> previous = null;

            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;

                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }


        //Поиск в списке

        public Spisok<T> Contains(T data)
        {
            Spisok<T> current = head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                    return current;
                current = current.Next;
            }
            return null;
        }

    }
}
