using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class FakeList<T> : IListDs<T>
    {
        private Node<T> head;
        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public FakeList()
        {
            head = null;
        }
        public int GetLength()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                p = p.next;
                len++;
            }
            return len;
        }

        public void Clear()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Append(T item)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = new Node<T>();
            if (head == null)
            {
                head = q;
                return;
            }
            p = head;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = q;
        }
        public int Insert(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                return 1;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.next = head;
                head = q;
                return 0;
            }
            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 1;
            while (p.next != null && j < i)
            {
                r = p;
                p = p.next;
                j++;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                Node<T> m = r.next;
                q.next = m;
            }
            return 0;
        }

        public T GetElem(int i)
        {
            if (IsEmpty())
            {
                return default(T);
            }
            Node<T> p = new Node<T>();
            p = head;
            int j = 1;
            while (p.next != null && j < i)
            {
                p = p.next;
                j++;
            }
            if (j == i)
            {
                return p.Data;
            }
            else
            {
                return default(T);
            }
        }

        public int Locate(T value)
        {
            if (IsEmpty())
            {
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 1;
            while ((p.next != null) && (!p.Data.Equals(value)))
            {
                p = p.next;
                i++;
            }
            if (p == null)
            {
                return -1;
            }
            else
            {
                return i;
            }
        }


        public T Delete(int i)
        {
            if (IsEmpty() || i < 1||i>GetLength())
            {
                return default(T);
            }
            Node<T> q = new Node<T>();
            if (i == 1)
            {
                q = head;
                head = head.next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 1;
            while (p.next != null && j < i)
            {
                q = p;
                p = p.next;
                j++;
            }
            if (j == i)
            {
                q.next = p.next;
                return p.Data;
            }
            else
            {
                return default(T);
            }
        }

        public void Insert(T items)
        {
            throw new NotImplementedException();
        }

       

      
    }
}
