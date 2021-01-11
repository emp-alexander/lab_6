using System;

namespace laba_6
{

   
    abstract class Engine
    {
       
        private int capacity;
        private int power;

        // с одним параметром
        public Engine(int power)
        {
            capacity = 3;
            this.power = power;
            System.Console.WriteLine("Конструктор с одним параметром");
        }
        //со всеми параметрами
        public Engine(int capacity, int power)
        {
            this.capacity = capacity;
            this.power = power;
            System.Console.WriteLine("Конструктор со всеми парметрами");
        }
        //конструктор без параметров
        public Engine()
        {
           
            capacity = 3;
            power = 5;
            System.Console.WriteLine("Конструктор без параметров");
        }

        public virtual void sound()
        {
            System.Console.WriteLine("Звук двигателя : ТРррара");
        }


        public String GetInfo()
        {
            return ("Engine: capacity  = " + capacity + " power = " + power);
        }
        public void Read()
        {
            Console.Write("Enter capacity:");
            this.capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power:");
            this.power = Convert.ToInt32(Console.ReadLine());
        }


    }

    class Electro_Engine : Engine
    {
        private int battery;
        public Electro_Engine()
        {
            battery = 500;
        }

        public override void sound()
        {
            System.Console.WriteLine("Звук двигателя : не слышно");
        }

        public override string ToString()
        {
            return base.ToString() + ": " + battery.ToString();
        }
    }

    class Benz_Engine : Engine
    {
        private int cylinders;
        public Benz_Engine() : base()
        {
            cylinders = 8;
        }

        public Benz_Engine(int c) : base()
        {
            this.cylinders = c;
        }


        public override void sound()
        {
            System.Console.WriteLine("Звук двигателя : арарарар");
        }

        public override string ToString()
        {
            return base.ToString() + ": " + cylinders.ToString();
        }
    }

    interface ISomeInterface
    {
        int property { get; set; }
        void Print();
    }

    class Test : ISomeInterface
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("This is red");
        }
    }

    //Клонирование

    class Program
    {
        static void Main()
        {


            Engine electro_engine = new Electro_Engine();
            Engine benz = new Benz_Engine();
            Console.WriteLine(benz.ToString());
            Console.WriteLine(electro_engine.ToString());

            Test test_1 = new Test();
            test_1.property = 7;
            test_1.Print();
            Console.WriteLine(test_1.property);



            ////One demensional array

            //Console.Write("Enter one demensional array length: ");
            //int length = int.Parse(Console.ReadLine());
            //Auto_show[] odinarray = new Auto_show[length];
            //for (int i = 0; i < odinarray.Length; i++)
            //{
            //    odinarray[i] = new Auto_show();
            //   // odinarray[i].Engine = w1;
            //    odinarray[i].read();
            //}

            //foreach (Auto_show a in odinarray)
            //{
            //    Console.WriteLine("Object::warrior: ");
            //    a.display();
            //}

            //двумерный

            //Console.WriteLine("Two demensional array MxN:. Enter m,n: ");
            //int m, n;
            //m = int.Parse(Console.ReadLine());
            //n = int.Parse(Console.ReadLine());
            //Auto_show[,] two_array = new Auto_show[m, n];
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        two_array[i, j] = new Auto_show();
            //        two_array[i, j].read();
            //    }
            //}

            //foreach (Auto_show car in two_array)
            //{
            //    Console.WriteLine("Object::warrior. Array[][]");
            //    car.display();
            //}

            //}



        }
    }
}
