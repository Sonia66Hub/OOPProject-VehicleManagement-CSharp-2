using OOPGeneric.Entities;
using OOPGeneric.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
			finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            Console.WriteLine("How many operation would you you like to perform");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine("Enter operation type\nHint Twowheeler -1 , Fourwheeler -2");
                int operationtype = Convert.ToInt32(Console.ReadLine());
                if (operationtype == 1)
                {
                    GetMotorCycleInfo();
                }
                else
                {
                    GetCarInfo();
                }
            }
        }

        private static void GetCarInfo()
        {
            Car<Vehicle> myCar = new Car<Vehicle>(4, 4, "BMW-X", 2022, 5, 2500, VehicleType.Personal);
            myCar.GetDetails();
            Console.WriteLine();
            string[] designs = myCar.GetInteriorDesign<Vehicle>("Showpiece,Pillow");
            for (int i = 0; i < designs.Length; i++) {
                Console.WriteLine((i + 1).ToString() + "." + designs[i]);
            }
        }

        private static void GetMotorCycleInfo()
        {
            MotorCycle<Vehicle> cycle = new MotorCycle<Vehicle>(120,12,120,"disk","Drum","Suzuki",2022,5,250,VehicleType.Rented);
            cycle.GetDetails();
            Console.WriteLine();
            string[] designs = cycle.GetExteriorDesign<Vehicle>("Bike Cover,Sticker");
            for (int i = 0; i < designs.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + "." + designs[i]);
            }
        }
    }
}
