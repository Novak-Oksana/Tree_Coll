using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Coll
{
    public interface ITree
    {
        void Init(int[] ini);
        void Add(int val);
        void Del(int val);
        int[] ToArray();
        int Size();
        int Height();
        int Width();
        int Nodes();
        int Leaves();
        void Reverse();
      //  bool Equal(BsTree tree);
    }
}
