using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3_Marushchak
{
    public partial class Form1 : Form
    {
        AnimalCollectionQueue animalsQueue = new AnimalCollectionQueue();
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_animal_weight.Text) || String.IsNullOrEmpty(textBox_animal_age.Text) || String.IsNullOrEmpty(textBox_animal_paymentPerDay.Text))
            {
                MessageBox.Show("Введiть усi дані!");
            }
            else
            {
                
                int weight;
                if (!int.TryParse(textBox_animal_weight.Text, out weight))
                {
                    MessageBox.Show("weight must be a digit");
                    return;
                }

                int age;
                if (!int.TryParse(textBox_animal_age.Text, out age))
                {
                    MessageBox.Show("age must be a digit");
                    return;
                }

                int paymentPerDay;
                if (!int.TryParse(textBox_animal_paymentPerDay.Text, out paymentPerDay))
                {
                    MessageBox.Show("paymentPerDay must be a digit");
                    return;
                }

                try
                {
                    Animal animal = new Animal();
                    animal.Add(weight, age, paymentPerDay);
                    textBox_animals.Text += animal.Print();

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_wolf_weight.Text) || String.IsNullOrEmpty(textBox_wolf_age.Text) || String.IsNullOrEmpty(textBox_wolf_paymentPerDay.Text)
                || String.IsNullOrEmpty(textBox_wolf_breed.Text) || String.IsNullOrEmpty(textBox_wolf_livingArea.Text))
            {
                MessageBox.Show("Введiть усi дані!");
            }
            else
            {
                int weight;
                if (!int.TryParse(textBox_wolf_weight.Text, out weight))
                {
                    MessageBox.Show("weight must be a digit");
                    return;
                }

                Int32 age;
                if (!Int32.TryParse(textBox_wolf_age.Text, out age))
                {
                    MessageBox.Show("age must be a digit");
                    return;
                }

                int paymentPerDay;
                if (!int.TryParse(textBox_wolf_paymentPerDay.Text, out paymentPerDay))
                {
                    MessageBox.Show("paymentPerDay must be a digit");
                    return;
                }

                string breed = textBox_wolf_breed.Text;
                string livingArea = textBox_wolf_livingArea.Text;


                
                try
                {
                    Wolf wolf = new Wolf();
                    wolf.Add(weight, age, paymentPerDay, breed, livingArea);
                    textBox_wolfs.Text += wolf.Print();

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void button_fillArray_Click(object sender, EventArgs e)
        {
            textBox_animalArray.Clear();

            Animal[] animals = new Animal[(int)numericUpDown_animalsCount.Value];
         
            // заповнює першу половину масиву
            for (int i = 0; i < animals.Length/2; i++)
            {
                Animal animal = new Animal(50, 10, 100);
                animals[i] = (animal);

            }

            Animal turtle = new Animal(100, 100, 20);
            animals[0] = turtle;

            for (int i = 0; i < animals.Length / 2; i++)
            {
                textBox_animalArray.Text += animals[i].Print();
            }

            // клонує другу половину масиву
            int firstHalf = 0;
            for (int i = animals.Length/2; i < animals.Length; i++, firstHalf++)
            {
                animals[i] = (Animal)animals[firstHalf].Clone();
                textBox_animalArray.Text += animals[i].Print();
            }



            // Сортує масив
            Array.Sort(animals);


            textBox_animalsSorted.Clear();
            foreach (Animal animal in animals)
            {
                textBox_animalsSorted.Text += animal.Print();
            }

        }

        private void numericUpDown_animalsCount_ValueChanged(object sender, EventArgs e)
        {
            button_fillArray.Enabled = true;
        }

        private void button_createQueue_Click(object sender, EventArgs e)
        {
            

            animalsQueue.CreateCollection((int)numericUpDown_queueSize.Value);
           

            button_animalIndex.Enabled = true;
            
        }

        private void numericUpDown_queueSize_ValueChanged(object sender, EventArgs e)
        {
            button_createQueue.Enabled = true;
            numericUpDown_animalIndex.Enabled = true;
        }

        private void numericUpDown_animalIndex_ValueChanged(object sender, EventArgs e)
        {

            int value = (int)numericUpDown_animalIndex.Value;


            if (value > numericUpDown_queueSize.Value)
            {
                numericUpDown_animalIndex.Value = numericUpDown_queueSize.Value;
            }
        }

        private void button_animalIndex_Click(object sender, EventArgs e)
        {
            textBox_animalsQueue.Text += animalsQueue.Message((int)numericUpDown_animalIndex.Value -1);
        }
    }
}
