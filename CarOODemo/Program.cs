﻿using System;
using System.Collections.Generic;

namespace CarOODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create different cars and "drive" them
            ICar explorer = new GasCar("Ford", "Explorer", 20, 15);
            ICar leaf = new ElectricCar("Nissan", "Leaf", 60, 3);
            ICar pinto = new GasCar("Ford", "Pinto", 10, 20);

            List<ICar> cars = new List<ICar>()
            {
                explorer,
                leaf,
                pinto
            };

            //sort list by MPG
            cars.Sort(new MilesPerGallonComparer());
            cars.Reverse();

            foreach(ICar car in cars)
            {
                car.Start();
                Console.WriteLine("MPG " + car.GetMilesPerGallon());
                car.Drive(75);
                car.Drive(50);
            }

        }
    }
}
