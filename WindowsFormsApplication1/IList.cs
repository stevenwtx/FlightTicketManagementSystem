using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IListDs<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Append(T items);
        void Insert(T items);
        T Delete(int i);
        T GetElem(int i);
        int Locate(T values);
    }
}
