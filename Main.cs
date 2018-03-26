//DYLAN GRANDJEAN
//Assignment 5 - Population Density
//Program designed to calculate the population density of a state
//February 25th, 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationDensity
{
    class Main
    {
        static void Main(string[] args)
        {
            //Variable declaration
            string state;
            int population,
                landArea,
                populationDensity;

            //Heading and instruction calling
            Heading();
            DisplayDirections();

            //Get user input and ssign to variable
            state = GetState();
            population = GetPopulation();
            landArea = GetLandArea();

            //Calculate population density through predefined method
            populationDensity = GetPopulationDensity(population, landArea);

            //Display result to the screen
            Console.WriteLine("**************************************************\n" + 
                              "The density of {0} is {1} people per square mile.", state, populationDensity);
            Console.Read();
        }

        //Display heading (assignment name, purpose, programmer name, date)
        private static void Heading()
        {
            Console.WriteLine("**************************************************\n" +
                              "\tPopulation Density\n" +
                              "\tCalculate Population Density\n" +
                              "\tDylan Grandjean\n\t" +
                              DateTime.Today.ToShortDateString() +
                              "\n**************************************************");
        }

        //Display direction on how to use the program
        private static void DisplayDirections()
        {
            Console.WriteLine("This program will determine population density.\n\n" +
                              "You will be asked to enter the state,\n" +
                              " population, and land area.\n\n" +
                              "**************************************************");
        }
        
        //Get and return state from user
        private static string GetState()
        {
            Console.Write("Enter state: ");
            string state = Console.ReadLine();

            return state;
        }

        //Get and return population from user
        private static int GetPopulation()
        {
            Console.Write("Enter population: ");
            int population = int.Parse(Console.ReadLine());

            return population;
        }

        //Get  and return land area from user
        private static int GetLandArea()
        {
            Console.Write("Enter land area (square miles): ");
            int landArea = int.Parse(Console.ReadLine());

            return landArea;
        }

        //Calculate population density and return result
        private static int GetPopulationDensity (int population, int landArea)
        {
            int populationDensity = population / landArea;
            
            return populationDensity;  
        }

    }
}
