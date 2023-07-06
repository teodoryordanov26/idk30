using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk30
{
    class Program
    {
        static void Main(string[] args)
        {
            printmenu();
            chooseMenuNumber();
            
        }
        static void printmenu()
        {
            
            Console.WriteLine("1.Добавяне на книга в библиотеката.");
            Console.WriteLine("2.Заемане на книга от читателя.");
            Console.WriteLine("3.Връщане на книга от читателя.");
            Console.WriteLine("4.Справка за налични книги в библиотеката.");
            Console.WriteLine("5. Kрай.");
        }
        static void chooseMenuNumber()
        {
            Console.WriteLine("Изберете действие 1-4!");
            string option = Console.ReadLine();
            switch (option)
            {
                case"1":
                    method1();
                    break;
            }
        }
        static void method1()
        {

        }
    }
}
