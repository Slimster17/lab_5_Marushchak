using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_Marushchak
{
    internal abstract class AnimalCollection
    {
        private int size;
        public int Size 
        {
            get { return size; }
            set { size = value; }
        }

        public abstract void CreateCollection(int size);
        public abstract string Message(int index);

    }
}
