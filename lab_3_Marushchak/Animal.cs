using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_Marushchak
{
    class Animal : IAnimal, IComparable<Animal>, ICloneable
    {
        int weight;
        int age;
        int paymentPerDay;

        public int Weight 
        {
            get { return weight; }
            set 
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect weight value");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set {

                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect age value");
                }
            }
        }

        public int PaymentPerDay
        {
            get { return paymentPerDay; }
            set {
                if (value > 0)
                {
                    paymentPerDay = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect paymentPerDay value");
                }
            }
        }

        public Animal(int weight, int age, int paymentPerDay) 
        {
            Weight = weight;
            Age = age;
            PaymentPerDay = paymentPerDay;
        }

        public Animal() 
        { }

        public virtual string Print() // Вивід інформації в textBox
        {
        return string.Format("\r\n Вага: {0} Вік: {1} Утримання в день: {2}\n", Weight, Age, PaymentPerDay);
        }

        public void Add(int weight, int age, int paymentPerDay) // Зчитування з textBox i DateTimePicker
        {
            Weight = weight;
            Age = age;
            PaymentPerDay = paymentPerDay;
        }

        public int CompareTo(Animal other)
        {

            return Weight.CompareTo(other.Weight);

        }

        public object Clone()
        {
            return new Animal(Weight, Age, PaymentPerDay);
        }
    }

}
