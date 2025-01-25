using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    interface IMovable
    {
        void Move(int speed);

    }
    public class Car : IMovable
    {
        public void Move(int speed)
        {
            Console.WriteLine($" со скорост {speed} km/ч");
        }
    }
    public class Robot : IMovable
    {
        public void Move(int speed)
        {
            Console.WriteLine($" со скорост {speed} km/ч");
        }
    }

    //2
    public abstract class Appliance
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    public class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("WashingMachine включена.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("WashingMachineвыключена.");
        }
    }
    public class Refrigerator : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Refrigerator включен.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Refrigerator выключен.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable robot = new Robot();

            car.Move(220);
            robot.Move(50);
            //2
            Appliance washingMachine = new WashingMachine();
            Appliance refrigerator = new Refrigerator();

            washingMachine.TurnOn();
            washingMachine.TurnOff();

            refrigerator.TurnOn();
            refrigerator.TurnOff();
            Console.ReadKey();
        }
    }
}
