using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Employees
{
    // patial данные в частичном классе
    // abstract запрещает создание нового объекта Employee в программе
    abstract partial class Employee
    {
        //может быть (но не обязательно) переопределен в подклассе
        //Методы, помеченные ключевым словом virtual, называются виртуальными       
        public virtual void GiveBonus(float amount) => Pay += amount;

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Id : {0}", ID);
            Console.WriteLine("Pay : {0}", Pay);
            Console.WriteLine("SSN : {0}", empSSN);
        }

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            { Gold, Platinum, Silver}
            public double ComputerPayReduction()
            {
                return 125.00;
            }
        }

        ////Делегация — просто действие по добавлению во включающий класс открытых
        ////членов, которые работают с функциональностью содержащегося внутри объекта.
        //protected BenefitPackage empBenefits = new BenefitPackage();
        //// Открывает доступ к некоторому поведению, связанному со льготами
        //public double GetBenefitCost()
        //{
        //    return empBenefits.ComputerPayDeduction();
        //}
        //// Открывает доступ к объекту через специальное свойство
        //public BenefitPackage Benefits
        //{
        //    get { return empBenefits; }
        //    set { empBenefits = value; }
        //}      


    }
    }
