using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.ActionAndFuncDelegates
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }
        private bool CarIsDead;
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public delegate void CarEngineHandler(string msgForCaller);        
        public CarEngineHandler listOfHandlers;
        
        public void Accelerate(int delta) 
        {
                if (listOfHandlers !=null)
                {
                    listOfHandlers("Sorry, this car is dead...");
                }                        
        }
    }
}
