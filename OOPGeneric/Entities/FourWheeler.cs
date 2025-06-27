using OOPGeneric.Enums;
using OOPGeneric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric.Entities
{
    public class FourWheeler<T> : Vehicle,IInteriorDesign<T>
    {
        public FourWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.ModelNo = modelNo;
            this.YearMake = yearMake;
            this.NumberOfGear = numberOfGear;
            this.EngineCapacity = engineCapacity;
            this.Type = type;
        }

        protected override string ModelNo { get; set; }
        protected override int YearMake { get; set; }
        protected override int NumberOfGear { get; set; }
        protected override int EngineCapacity { get; set; }
        protected override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Details implemented from Base calss");
        }

        public string[] GetInteriorDesign<T>(string designs)
        {
           string[] designList=designs.Split(',');
            return designList;
        }

        public override void ShowVehicleType()
        {
            Console.WriteLine("Four Wheeler");
        }
    }
}
