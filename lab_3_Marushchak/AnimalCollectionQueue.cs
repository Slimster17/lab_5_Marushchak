using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_3_Marushchak
{
    internal class AnimalCollectionQueue : AnimalCollection
    {
        Queue<Animal> animals;

        public AnimalCollectionQueue() 
        {
            animals = new Queue<Animal>();
        }
        public override void CreateCollection(int size)
        {
            this.Size = size;

            for (int i = 0; i < size; i++) 
            {
                animals.Enqueue(new Animal(10,100,40));
            }
        }

        public override string Message(int index)
        {
            return string.Format("\r\n Вага: {0} Вік: {1} Утримання в день: {2}\n", 
                animals.ElementAt(index).Weight, 
                animals.ElementAt(index).Age, 
                animals.ElementAt(index).PaymentPerDay);
        }
    }
}
