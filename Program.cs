using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace _330._6
{
    class MyClass
    {
        private int max;
        private int min;

        // Методы программы:
        public void set()
        {
            max = 100;
            min = 25;
        }

        public void set(int a)
        {
            if (a >= max) { max = a; }
            if (a <= min) { min = a; }
        }

        public void set(int a, int b)
        {
            if (a >= max) { max = a; }
            if (a <= min) { min = a; }
            if (b >= max) { max = b; }
            if (b <= min) { min = b; }
        }

        public void show()
        {
            Console.WriteLine("Значения max: " + max+" min: "+min);
        }

        // Конструктор с 2мя аргументами для присваивания значений полям:
        public MyClass(int a, int b)
        {
            if (a >= b) 
            { 
                if (a >= max) 
                { max = a; } 
            }
            else 
            { 
                if (b >= max) 
                { max = b; }
                if (a <= min)
                { min = a; }
            } 
        }
    }

    class MainClass
    {
        // Главный метод программы:
        static void Main()
        {
            MyClass B = new MyClass(121,5);
            B.show();

            B.set();
            B.show();

            B.set(101);
            B.show();

            B.set(2, 200);
            B.show();
        }
    }
}

