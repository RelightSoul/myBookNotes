using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.CarDelegateMethodGroupConversion
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

        // Определить тип делегата
        public delegate void CarEngineHandler(string msgForCaller);
        // Определить переменную-член этого типа делегата
        private CarEngineHandler listOfHandlers;
        //Добавить регистрационную функцию для вызывающего кода
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            // Добавление поддержки группового вызова.
            // Обратите внимание на использование операции +=,
            // а не обычной операции присваивания (=)
            // listOfHandlers += methodToCall;
            listOfHandlers += methodToCall;
        }
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            // Добавление поддержки группового вызова.
            // Обратите внимание на использование операции +=,
            // а не обычной операции присваивания (=)
            // listOfHandlers += methodToCall;
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta) 
        {
            if (CarIsDead)
            {
                if (listOfHandlers !=null)
                {
                    listOfHandlers("Sorry, this car is dead...");
                }
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed && listOfHandlers != null)
                {
                    CarIsDead = true;
                }
                else
                {
                    Console.WriteLine("Current Speed = {0}",CurrentSpeed );
                }
            }
        }
    }
}
