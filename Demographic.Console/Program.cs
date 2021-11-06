using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic;

namespace Demographic.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EngineConfig engineConfig = new EngineConfig
            {
                FilePathDeathRule = @"C:\Users\Alexandr\source\repos\Demographic\DeathRules - DeathRules.csv",
                FilePathInitialAge = @"C:\Users\Alexandr\source\repos\Demographic\InitialAge - InitialAge.csv",
                LeftLimitYear = 1970,
                RightLimitYear = 2021,
                StartCountPeoples = 13000000
            };

            Engine engine = new Engine(engineConfig);

            while (engine.TickYear())
            {
                System.Console.WriteLine($"Year = {engine.CurrentYear}. \t Живых людей = {engine.Persons.Where(p => p.LifeStatus == Enums.LifeStatus.Alive).Count().ToString("N1", CultureInfo.InvariantCulture)} \t Умерших людей = {engine.Persons.Where(p => p.LifeStatus == Enums.LifeStatus.Dead).Count().ToString("N1", CultureInfo.InvariantCulture)}");
            }

            System.Console.WriteLine(engine.Persons.Count);
            System.Console.ReadKey();
        }
    }
}
