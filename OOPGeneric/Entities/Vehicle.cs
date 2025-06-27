using OOPGeneric.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric.Entities
{
    public abstract class Vehicle
    {
        string modelNo;
        int yearMake;
        int numberOfGear;
        int engineCapacity;
        VehicleType type;

        protected Vehicle(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type)
        {
            this.modelNo = modelNo;
            this.yearMake = yearMake;
            this.numberOfGear = numberOfGear;
            this.engineCapacity = engineCapacity;
            this.type = type;
        }

        protected abstract string ModelNo { get; set; }
        protected abstract int YearMake { get; set; }
        protected abstract int NumberOfGear { get; set; }
        protected abstract int EngineCapacity { get; set; }
        protected abstract VehicleType Type { get; set; }

        public abstract void GetDetails();
        public virtual void ShowVehicleType()
        {
            Console.WriteLine("Supper");
        }
    }
}
