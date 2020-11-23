﻿using System;

namespace laba_6
{

    class Auto_show
    {
        private static int racing = 7;
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

        public static int Racing()
        {
            return racing;
        }

        public static void Racingset(int r)
        {
            racing = r;
        }
    }
    class Engine
    {
        private int cylinders;
        private int capacity;
        private int power;

        // с одним параметром
        public Engine(int power)
        {
            cylinders = 6;
            capacity = 3;
            this.power = power;
            System.Console.WriteLine("Конструктор с одним параметром");
        }
        //со всеми параметрами
        public Engine(int cylinders, int capacity, int power)
        {
            this.cylinders = cylinders;
            this.capacity = capacity;
            this.power = power;
            System.Console.WriteLine("Конструктор со всеми парметрами");
        }
        //конструктор без параметров
        public Engine()
        {
            cylinders = 6;
            capacity = 3;
            power = 5;
            System.Console.WriteLine("Конструктор без параметров");
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
            Engine a1 = new Engine();
            Console.WriteLine(a1.GetInfo());
            Engine a2 = new Engine(2014);
            Console.WriteLine(a2.GetInfo());
            Engine a3 = new Engine(4, 5, 7);
            Console.WriteLine(a3.GetInfo());

            Engine[] arr = new Engine[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Engine(2015);
                Console.WriteLine(arr[i].GetInfo());
            }
        }
    }
}
