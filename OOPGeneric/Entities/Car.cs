using OOPGeneric.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric.Entities
{
    public sealed class Car<T>:FourWheeler<T>
    {
        int numberOfSeat;
        int numberOfDoors;

        public Car(int numberOfSeat, int numberOfDoors, string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.numberOfSeat = numberOfSeat;
            this.numberOfDoors = numberOfDoors;
        }

        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public override void GetDetails()
        {
            Console.WriteLine($"Car Information\n\nVehicle Model: {ModelNo}\nManufacturing Year:{YearMake}\nNumber of Gear: {NumberOfGear}\nNumber of Seat {numberOfSeat}\nNumber Of Door {numberOfDoors}\nEngine Capacity: {EngineCapacity}\nVehicle Type: {Type}");
        }
        public override void ShowVehicleType()
        {
            Console.WriteLine("Child of four wheeler");
        }
    }
}
