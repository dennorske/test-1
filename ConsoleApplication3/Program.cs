using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            //new list that will hold Car objects
            List<Car> myCarList = new List<Car>();
            //because this list will exist as long as the program runs..so the car objects all keep existing within this list until i close the program

            //new array with the vehicle names i want
            string[] carNames = { "honda", "toyota", "opel", "volvo" };

            //loop trough the vehicle names list
            //yes so i'll type it out one by one
            //i need to loop trough all of the carnames so i know which cars to create

            foreach (string mytotallyrandomname in carNames)
            {
               //because i will create a new Car somerandomCar every loop 
                Car someRandomCar = new Car(mytotallyrandomname, "1999", 4); // so my class gets created with me passing the honda / toyota / open /volvo name 

                myCarList.Add(someRandomCar);
            }
            //as soon as this foreach loop is over the someRandomcar variable doesn't exist anymore but all the classes still exist within my myCarList




            //loop trough the list of car objects
            foreach (Car car in myCarList)
            {
                //call the PrintMyName() function for every car 
                //but now i can't access it anymore from outside the car class
                car.PrintMyName();

            }

            Console.ReadKey();

        }
    }

    public class Car
    {
        // the variable that will hold the carname
        private string carName = "";  

        //well it can hold more than 1 variable for example
        //so now i have different variables inside my car that i can assign
        private string carBuildyear = "";
        private int wheelCount = 0;
        private List<string> lstOfPassengers = new List<string>();

        //classes can actually do alot of things its not just to store information in

        public Car(string myCarobjectCarName, string buildYear, int wheels)   //yes there's no need to use this. if you make sure you use unique variable names
        {

            carName = myCarobjectCarName;
            carBuildyear = buildYear;
            wheelCount = wheels;

            //after my variables are saved i will call a function to add5 wheels to this car
            Add5Wheels(10);
        }

        //so now i wanna add a function within my car class that prints the name of the current carname within the object
        public void PrintMyName()
        {
            Console.WriteLine("name: " + carName + " buildyear: " + carBuildyear + " wheelcount: " + wheelCount);
        }

        public void Add5Wheels(int howMany)
        {
            wheelCount += howMany;
            if (wheelCount > 2)
            {
                Console.WriteLine("Adding {0} more wheels!", howMany);
            }
        }


    }
}
