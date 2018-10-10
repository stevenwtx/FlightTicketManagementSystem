using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Node<T>
    {
         T data;
         public Node<T> next;
        public Node(T val,Node<T> p)
        {
            data = val;
            next = p;
        }

        public Node(Node<T> p) {
            next = p;
        }

        public Node(T val)
        {
            data = val;
        }

        public Node()
        {
            data = default(T);
            next = null;
        }
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
}
