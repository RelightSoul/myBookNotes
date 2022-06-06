using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.ProcessMultipleExceptions
{
    partial class Car
    {
        public const int MaxSpeed = 100;
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool carIsDead;

        private Radio mRadio = new Radio();
        public Car(string name, int speed)
        {
            CurrSpeed = speed;
            PetName = name;
        }
        public Car() { }
        public void CrankTunes(bool state) => mRadio.TurnOn(state);
    }
}
