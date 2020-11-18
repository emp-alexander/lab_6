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

        public Auto_show()
        {

        }
        public Auto_show(string brend, string name, int cost, int max_speed, int year)
        {
            this.autoBrand = brend;
            this.autoName = name;
            this.autoCost = cost;
            this.autoMax_speed = max_speed;
            this.autoYear = year;
        }

        public void init(String brend, String name, int cost, int max_speed, int year, Engine eng1)
        {
            this.autoBrand = brend;
            this.autoName = name;
            this.autoCost = cost;
            this.autoMax_speed = max_speed;
            this.autoYear = year;
            this.autoeng1 = eng1;
        }

        public void init_not_eng(String brend, String name, int cost, int max_speed, int year)
        {
            this.autoBrand = brend;
            this.autoName = name;
            this.autoCost = cost;
            this.autoMax_speed = max_speed;
            this.autoYear = year;
        }
        public void display()
        {
            Console.WriteLine("Brand: " + autoBrand);
            Console.WriteLine("Name: " + autoName);
            Console.WriteLine("Cost: " + autoCost);
            Console.WriteLine("Max speed: " + autoMax_speed);
            Console.WriteLine("Year: " + autoYear);
            Console.WriteLine(autoeng1.GetInfo());
        }


        public void read()
        {

            Console.WriteLine("Enter brand: ");
            this.autoBrand = System.Console.ReadLine();
            Console.WriteLine("Enter name: ");
            this.autoName = System.Console.ReadLine();
            Console.Write("Cost: ");
            this.autoCost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max speed: ");
            this.autoMax_speed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            this.autoYear = Convert.ToInt32(Console.ReadLine());
            autoeng1.Read();
        }

        public void CostRef(ref int autoCost)
        {
            autoCost = this.autoCost;
        }

        public void CostOut(out int autoCost)
        {
            autoCost = this.autoCost;
        }
        public static Auto_show operator +(Auto_show a, Auto_show b)
        {

            return new Auto_show(a.autoBrand, a.autoName, a.autoCost + b.autoCost
                , a.autoMax_speed + b.autoMax_speed,
                a.autoYear + b.autoYear);
        }


        public static Auto_show operator ++(Auto_show a)
        {
            return new Auto_show(a.autoBrand, a.autoName, a.autoCost + a.autoCost,
                a.autoMax_speed + a.autoMax_speed,
                a.autoYear + a.autoYear);
        }
    }
    class Engine
    {
        private int cylinders;
        private int capacity;
        public int power;

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
            Console.Write("Enter the number of cylinders:");
            this.cylinders = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter capacity:");
            this.capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power:");
            this.power = Convert.ToInt32(Console.ReadLine());
        }


    }
    struct Engine_st
    {
        private int cylinders;
        private int capacity;
        public int power;
        public Engine_st(int cylinders, int capacity, int power)
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
            Console.Write("Enter the number of cylinders:");
            this.cylinders = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter capacity:");
            this.capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power:");
            this.power = Convert.ToInt32(Console.ReadLine());
        }


    }




    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первое auto");
            Auto_show first_auto = new Auto_show();
            Engine autoeng = new Engine(4, 2, 100);

            first_auto.init("Lada", "granta", 300, 150, 2017, autoeng);
            first_auto.display();

            Console.WriteLine("Second auto");
            Auto_show second_auto = new Auto_show();
            second_auto.read();
            second_auto.display();

            Auto_show[] array = new Auto_show[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = new Auto_show();
                array[i].init_not_eng("Lada", "preora", 300, 150, 2012); ;
            }
            System.Console.WriteLine("Array[0]::");
            array[0].display();

            int cost_1 = 0;
            array[1].CostRef(ref cost_1);
            System.Console.WriteLine("reference::Cost: {0}", cost_1);

            int cost_2;
            array[1].CostOut(out cost_2);
            System.Console.WriteLine("out::Cost: {0}", cost_2);

            System.Console.WriteLine("Sum array[2] and array[3]:");
            array[1] = array[2] + array[3];
            array[1].display();
            System.Console.WriteLine("Array[2].Auto++::");
            array[1] = array[2]++;
            array[1].display();



            //Класс & струтура
            Engine eng_class = new Engine(4, 2, 100);

            SuperPower(eng_class);
            System.Console.WriteLine("class:: power: {0}", eng_class.power);

            Engine_st eng_struct = new Engine_st(4, 2, 100);

            SuperPower(eng_struct);
            System.Console.WriteLine("struct:: power: {0}", eng_struct.power);
        }
        public static void SuperPower(Engine e)
        {
            e.power++;
        }

        public static void SuperPower(Engine_st e)
        {
            e.power++;
        }

    }
}
