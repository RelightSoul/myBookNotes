using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.CarEvents
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

        //public delegate void CarEngineHandler(object sender, CarEventArgs e);        
        //public CarEngineHandler listOfHandlers;
        //public event CarEngineHandler Exploded;
        //public event CarEngineHandler AboutToBlow;

        //упрощение за счёт применения обобщенного типа
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;
        
        public void Accelerate(int delta) 
        {
            if (CarIsDead)
            {
                Exploded?.Invoke(this,new CarEventArgs("Sorry, this car is dead..."));                
            }
            else
            {
                CurrentSpeed +=delta;
                if (10==MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke(this,new CarEventArgs("Careful buddy!"));
                }
                if (CurrentSpeed>=MaxSpeed)
                {
                    CarIsDead = true;
                }
                else
                {
                    Console.WriteLine("Speed: {0}", CurrentSpeed);
                }
            }
        }
    }
}
