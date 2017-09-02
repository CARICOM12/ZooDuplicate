using System;

namespace UsageOfConstructors
{
    enum AnimalName { Elk, Elephant, Crocodile, Mouse, Deer, Lion, Giraffe }
    enum AnimalColor { White, Green, Grey, Black, Yellow }

    class Mammal
    {
        public AnimalName Name;
        public AnimalColor Color;
        public int Weight;
        public int Height;
        public bool Gender;

        //public Mammal(string Name, string Color, int Weight, int Height, bool Gender)
        //{
        //    this.Name = Name;
        //    this.Color = Color;
        //    this.Weight = Weight;
        //    this.Height = Height;
        //    this.Gender = Gender;
        //}

        //public Mammal(string Name)
        //{
        //    this.Name = Name;
        //    Color = "White";
        //    Weight = 25;
        //    Height = 1;
        //    Gender = true;
        //}

        public Mammal(Random R)
        {
            //Name = "Rhino";
            //Color = "Black";
            //Weight = 800;
            //Height = 2;
            //Gender = false;

            Name = (AnimalName)R.Next(6);
            Color = (AnimalColor)R.Next(4);
            Weight = R.Next(95) + 5;
            Height = R.Next(3) + 1;
            Gender = (R.Next(10) % 2 == 0);
        }

        //Метод, который выводит всю инфу в виде таблицы: <Поле> : <Значение>
        public void ShowAll()
        {
            Console.WriteLine("\nName : " + Name.ToString());
            Console.WriteLine("Color : " + Color.ToString());
            Console.WriteLine("Weight : " + Weight.ToString());
            Console.WriteLine("Height : " + Height.ToString());
            Console.WriteLine("Gender : " + Gender.ToString() + "\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Mammal t = new Mammal("Crocodile", "Green", 2000, 2, false);
            //t.ShowAll();
            //t = new Mammal("Elephant");
            //t.ShowAll();
            //t = new Mammal();
            //t.ShowAll();
            int X, Y;
            Console.Write("Enter X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y: ");
            Y = Convert.ToInt32(Console.ReadLine());

            Random R = new Random();
            Mammal[,] Zoo = new Mammal[X, Y];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    Zoo[i, j] = new Mammal(R);
                }
            }

            while (true)
            {
                int x, y;
                Console.Clear();
                Console.Write("Enter X of desired cell: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Y of desired cell: ");
                y = Convert.ToInt32(Console.ReadLine());

                if ((x > X - 1) || (y > Y - 1))
                {
                    continue;
                }

                Console.WriteLine("In cell ({0}:{1}) sits this animal:", X.ToString(), Y.ToString());
                Zoo[x, y].ShowAll();
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}