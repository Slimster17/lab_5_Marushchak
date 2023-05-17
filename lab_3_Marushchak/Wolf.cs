using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_Marushchak
{
    class Wolf : Animal, IComparable<Wolf>, ICloneable
    {
        string breed;
        string livingArea;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string LivingArea
        {
            get { return livingArea; }
            set { livingArea = value; }
        }

        public Wolf(int weight, int age, int paymentPerDay, string breed, string livingArea) 
        {
            Weight = weight;
            Age = age;
            PaymentPerDay = paymentPerDay;
            Breed = breed;
            LivingArea = livingArea;
        }

        public Wolf() 
        { }

        public override string Print() // Вивід інформації в textBox
        {
            return string.Format("\r\n Вага: {0} Вік: {1} Утримання в день: {2} Порода: {3} Місце природної локації: {4}\n", Weight, Age, PaymentPerDay, Breed, LivingArea);
        }

        public void Add(int weight, int age, int paymentPerDay, string breed, string livingArea) // Зчитування з textBox i DateTimePicker
        {
            Weight = weight;
            Age = age;
            PaymentPerDay = paymentPerDay;
            Breed = breed;
            LivingArea = livingArea;
        }

        public int CompareTo(Wolf other)
        {
            return Weight.CompareTo(other.Weight);
        }

        public new object Clone()
        {
            return new Wolf(Weight, Age, PaymentPerDay, Breed, LivingArea);
        }
    }
}
