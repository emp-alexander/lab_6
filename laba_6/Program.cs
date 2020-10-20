using System;

namespace laba_6
{

    class Auto_show
    {
        private String autoBrand;
        private String autoName;
        private int autoCost;
        private int autoMax_speed;
        private int autoYear;
        private Engine autoeng1 = new Engine();


        public void init(String brend, String name, int cost, int max_speed, int year, Engine eng1)
        {
            this.autoBrand = brend;
            this.autoName = name;
            this.autoCost = cost;
            this.autoMax_speed = max_speed;
            this.autoYear = year;
            this.autoeng1 = eng1;
        }


        public void display()
        {
            System.Console.WriteLine("Brand: " + autoBrand);
            System.Console.WriteLine("Name: " + autoName);
            System.Console.WriteLine("Cost: " + autoCost);
            System.Console.WriteLine("Max speed: " + autoMax_speed);
            System.Console.WriteLine("Year: " + autoYear);
            System.Console.WriteLine(autoeng1.GetInfo());
        }

        
        public void read()
        {

            System.Console.WriteLine("Enter brand: ");
            this.autoBrand = System.Console.ReadLine();
            System.Console.WriteLine("Enter name: ");
            this.autoName = System.Console.ReadLine();
            System.Console.Write("Cost: ");
            this.autoCost = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Max speed: ");
            this.autoMax_speed = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Year: ");
            this.autoYear = Convert.ToInt32(Console.ReadLine());
            autoeng1.Read();
        }
    }
    class Engine
    {
        private int cylinders;
        private int capacity;
        private int power;
        public Engine()
        {

        }
        public Engine(int cylinders, int capacity, int power)
        {
            this.cylinders = cylinders;
            this.capacity = capacity;
            this.power = power;
        }

        public String GetInfo()
        {
            return ("Engine: cylinders = " + cylinders + " capacity  = " + capacity + " power = " + power);
        }
       public void Read()
        {
            System.Console.Write("Enter the number of cylinders:");
            this.cylinders = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter capacity:");
            this.capacity = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter power:");
            this.power = Convert.ToInt32(Console.ReadLine());
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Первое auto");
            Auto_show first_auto = new Auto_show();
            Engine autoeng = new Engine(4, 2, 100);

            first_auto.init("Lada", "granta", 300, 150, 2017, autoeng);
            first_auto.display();

            System.Console.WriteLine("Second auto");
            Auto_show second_auto = new Auto_show();
            second_auto.read();
            second_auto.display();
        }
    }
}
