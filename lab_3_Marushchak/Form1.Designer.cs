namespace lab_3_Marushchak
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_animals = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_animal_weight = new System.Windows.Forms.TextBox();
            this.textBox_animal_age = new System.Windows.Forms.TextBox();
            this.textBox_animal_paymentPerDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_wolf_paymentPerDay = new System.Windows.Forms.TextBox();
            this.textBox_wolf_age = new System.Windows.Forms.TextBox();
            this.textBox_wolf_weight = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_wolfs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_wolf_breed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_wolf_livingArea = new System.Windows.Forms.TextBox();
            this.numericUpDown_animalsCount = new System.Windows.Forms.NumericUpDown();
            this.textBox_animalArray = new System.Windows.Forms.TextBox();
            this.button_fillArray = new System.Windows.Forms.Button();
            this.textBox_animalsSorted = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_createQueue = new System.Windows.Forms.Button();
            this.textBox_animalsQueue = new System.Windows.Forms.TextBox();
            this.numericUpDown_queueSize = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_animalIndex = new System.Windows.Forms.NumericUpDown();
            this.button_animalIndex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_animalsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_queueSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_animalIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клас тварина:";
            // 
            // textBox_animals
            // 
            this.textBox_animals.Location = new System.Drawing.Point(33, 38);
            this.textBox_animals.Multiline = true;
            this.textBox_animals.Name = "textBox_animals";
            this.textBox_animals.ReadOnly = true;
            this.textBox_animals.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_animals.Size = new System.Drawing.Size(242, 89);
            this.textBox_animals.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_animal_weight
            // 
            this.textBox_animal_weight.Location = new System.Drawing.Point(104, 133);
            this.textBox_animal_weight.Name = "textBox_animal_weight";
            this.textBox_animal_weight.Size = new System.Drawing.Size(67, 20);
            this.textBox_animal_weight.TabIndex = 5;
            // 
            // textBox_animal_age
            // 
            this.textBox_animal_age.Location = new System.Drawing.Point(104, 160);
            this.textBox_animal_age.Name = "textBox_animal_age";
            this.textBox_animal_age.Size = new System.Drawing.Size(67, 20);
            this.textBox_animal_age.TabIndex = 6;
            // 
            // textBox_animal_paymentPerDay
            // 
            this.textBox_animal_paymentPerDay.Location = new System.Drawing.Point(104, 192);
            this.textBox_animal_paymentPerDay.Name = "textBox_animal_paymentPerDay";
            this.textBox_animal_paymentPerDay.Size = new System.Drawing.Size(67, 20);
            this.textBox_animal_paymentPerDay.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вага:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вік:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Утримання \r\nв день:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Утримання \r\nв день:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Вік:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Вага:";
            // 
            // textBox_wolf_paymentPerDay
            // 
            this.textBox_wolf_paymentPerDay.Location = new System.Drawing.Point(352, 192);
            this.textBox_wolf_paymentPerDay.Name = "textBox_wolf_paymentPerDay";
            this.textBox_wolf_paymentPerDay.Size = new System.Drawing.Size(67, 20);
            this.textBox_wolf_paymentPerDay.TabIndex = 14;
            // 
            // textBox_wolf_age
            // 
            this.textBox_wolf_age.Location = new System.Drawing.Point(352, 160);
            this.textBox_wolf_age.Name = "textBox_wolf_age";
            this.textBox_wolf_age.Size = new System.Drawing.Size(67, 20);
            this.textBox_wolf_age.TabIndex = 13;
            // 
            // textBox_wolf_weight
            // 
            this.textBox_wolf_weight.Location = new System.Drawing.Point(352, 133);
            this.textBox_wolf_weight.Name = "textBox_wolf_weight";
            this.textBox_wolf_weight.Size = new System.Drawing.Size(67, 20);
            this.textBox_wolf_weight.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Додати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_wolfs
            // 
            this.textBox_wolfs.Location = new System.Drawing.Point(281, 38);
            this.textBox_wolfs.Multiline = true;
            this.textBox_wolfs.Name = "textBox_wolfs";
            this.textBox_wolfs.ReadOnly = true;
            this.textBox_wolfs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_wolfs.Size = new System.Drawing.Size(242, 89);
            this.textBox_wolfs.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Клас вовк:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Порода";
            // 
            // textBox_wolf_breed
            // 
            this.textBox_wolf_breed.Location = new System.Drawing.Point(352, 227);
            this.textBox_wolf_breed.Name = "textBox_wolf_breed";
            this.textBox_wolf_breed.Size = new System.Drawing.Size(67, 20);
            this.textBox_wolf_breed.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 39);
            this.label10.TabIndex = 21;
            this.label10.Text = "Місце \r\nприродної \r\nлокації:";
            // 
            // textBox_wolf_livingArea
            // 
            this.textBox_wolf_livingArea.Location = new System.Drawing.Point(352, 265);
            this.textBox_wolf_livingArea.Name = "textBox_wolf_livingArea";
            this.textBox_wolf_livingArea.Size = new System.Drawing.Size(67, 20);
            this.textBox_wolf_livingArea.TabIndex = 20;
            // 
            // numericUpDown_animalsCount
            // 
            this.numericUpDown_animalsCount.Location = new System.Drawing.Point(33, 362);
            this.numericUpDown_animalsCount.Name = "numericUpDown_animalsCount";
            this.numericUpDown_animalsCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_animalsCount.TabIndex = 22;
            this.numericUpDown_animalsCount.ValueChanged += new System.EventHandler(this.numericUpDown_animalsCount_ValueChanged);
            // 
            // textBox_animalArray
            // 
            this.textBox_animalArray.Location = new System.Drawing.Point(33, 388);
            this.textBox_animalArray.Multiline = true;
            this.textBox_animalArray.Name = "textBox_animalArray";
            this.textBox_animalArray.ReadOnly = true;
            this.textBox_animalArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_animalArray.Size = new System.Drawing.Size(242, 89);
            this.textBox_animalArray.TabIndex = 23;
            // 
            // button_fillArray
            // 
            this.button_fillArray.Enabled = false;
            this.button_fillArray.Location = new System.Drawing.Point(287, 388);
            this.button_fillArray.Name = "button_fillArray";
            this.button_fillArray.Size = new System.Drawing.Size(75, 89);
            this.button_fillArray.TabIndex = 24;
            this.button_fillArray.Text = "Заповнити масив";
            this.button_fillArray.UseVisualStyleBackColor = true;
            this.button_fillArray.Click += new System.EventHandler(this.button_fillArray_Click);
            // 
            // textBox_animalsSorted
            // 
            this.textBox_animalsSorted.Location = new System.Drawing.Point(33, 501);
            this.textBox_animalsSorted.Multiline = true;
            this.textBox_animalsSorted.Name = "textBox_animalsSorted";
            this.textBox_animalsSorted.ReadOnly = true;
            this.textBox_animalsSorted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_animalsSorted.Size = new System.Drawing.Size(242, 89);
            this.textBox_animalsSorted.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Кількість тварин:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cортування:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(365, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Кількість тварин в черзі:";
            // 
            // button_createQueue
            // 
            this.button_createQueue.Enabled = false;
            this.button_createQueue.Location = new System.Drawing.Point(622, 388);
            this.button_createQueue.Name = "button_createQueue";
            this.button_createQueue.Size = new System.Drawing.Size(75, 49);
            this.button_createQueue.TabIndex = 30;
            this.button_createQueue.Text = "Створити чергу";
            this.button_createQueue.UseVisualStyleBackColor = true;
            this.button_createQueue.Click += new System.EventHandler(this.button_createQueue_Click);
            // 
            // textBox_animalsQueue
            // 
            this.textBox_animalsQueue.Location = new System.Drawing.Point(368, 388);
            this.textBox_animalsQueue.Multiline = true;
            this.textBox_animalsQueue.Name = "textBox_animalsQueue";
            this.textBox_animalsQueue.ReadOnly = true;
            this.textBox_animalsQueue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_animalsQueue.Size = new System.Drawing.Size(242, 128);
            this.textBox_animalsQueue.TabIndex = 29;
            // 
            // numericUpDown_queueSize
            // 
            this.numericUpDown_queueSize.Location = new System.Drawing.Point(368, 362);
            this.numericUpDown_queueSize.Name = "numericUpDown_queueSize";
            this.numericUpDown_queueSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_queueSize.TabIndex = 28;
            this.numericUpDown_queueSize.ValueChanged += new System.EventHandler(this.numericUpDown_queueSize_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(508, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Індекс тварини";
            // 
            // numericUpDown_animalIndex
            // 
            this.numericUpDown_animalIndex.Enabled = false;
            this.numericUpDown_animalIndex.Location = new System.Drawing.Point(511, 362);
            this.numericUpDown_animalIndex.Name = "numericUpDown_animalIndex";
            this.numericUpDown_animalIndex.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_animalIndex.TabIndex = 32;
            this.numericUpDown_animalIndex.ValueChanged += new System.EventHandler(this.numericUpDown_animalIndex_ValueChanged);
            // 
            // button_animalIndex
            // 
            this.button_animalIndex.Enabled = false;
            this.button_animalIndex.Location = new System.Drawing.Point(622, 443);
            this.button_animalIndex.Name = "button_animalIndex";
            this.button_animalIndex.Size = new System.Drawing.Size(75, 49);
            this.button_animalIndex.TabIndex = 34;
            this.button_animalIndex.Text = "Знайти по індексу";
            this.button_animalIndex.UseVisualStyleBackColor = true;
            this.button_animalIndex.Click += new System.EventHandler(this.button_animalIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 600);
            this.Controls.Add(this.button_animalIndex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDown_animalIndex);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_createQueue);
            this.Controls.Add(this.textBox_animalsQueue);
            this.Controls.Add(this.numericUpDown_queueSize);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_animalsSorted);
            this.Controls.Add(this.button_fillArray);
            this.Controls.Add(this.textBox_animalArray);
            this.Controls.Add(this.numericUpDown_animalsCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_wolf_livingArea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_wolf_breed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_wolf_paymentPerDay);
            this.Controls.Add(this.textBox_wolf_age);
            this.Controls.Add(this.textBox_wolf_weight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_wolfs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_animal_paymentPerDay);
            this.Controls.Add(this.textBox_animal_age);
            this.Controls.Add(this.textBox_animal_weight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_animals);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_animalsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_queueSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_animalIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_animals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_animal_weight;
        private System.Windows.Forms.TextBox textBox_animal_age;
        private System.Windows.Forms.TextBox textBox_animal_paymentPerDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_wolf_paymentPerDay;
        private System.Windows.Forms.TextBox textBox_wolf_age;
        private System.Windows.Forms.TextBox textBox_wolf_weight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_wolfs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_wolf_breed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_wolf_livingArea;
        private System.Windows.Forms.NumericUpDown numericUpDown_animalsCount;
        private System.Windows.Forms.TextBox textBox_animalArray;
        private System.Windows.Forms.Button button_fillArray;
        private System.Windows.Forms.TextBox textBox_animalsSorted;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_createQueue;
        private System.Windows.Forms.TextBox textBox_animalsQueue;
        private System.Windows.Forms.NumericUpDown numericUpDown_queueSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_animalIndex;
        private System.Windows.Forms.Button button_animalIndex;
    }
}

