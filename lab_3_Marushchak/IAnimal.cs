using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_Marushchak
{
    internal interface IAnimal
    {
        string Print();
        void Add(int weight, int age, int paymentPerDay);
    }
}
