using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        /*
         Задание 3
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется:
            Создать класс Vehicle.
            В теле класса создайте поля: координаты и параметры средств передвижения
            (цена, скорость, год выпуска).
            Создайте 3 производных класса Plane, Саг и Ship.
            Для класса Plane должна быть определена высота и количество пассажиров.
            Для класса Ship — количество пассажиров и порт приписки.
            Написать программу, которая выводит на экран информацию о
            каждом средстве передвижения.
        */
        static void Main(string[] args)
        {
            Ship ship = new Ship(20000, 120, 2000) { Passengers = 28, Port = "Севастополь" };

            Console.WriteLine("Цена корабля {0}, скорость {1}, год выпуска {2}, количество пасажиров {3}, порт приписки {4}", ship.Price, ship.Speed, ship.Year, ship.Passengers, ship.Port);

            // Delay.
            Console.ReadKey();
        }
    }
}
