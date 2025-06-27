using OOPGeneric.Enums;
using OOPGeneric.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric.Entities
{
    public class TwoWheeler<T> : Vehicle,IExteriorDesign<T> where T : Vehicle
    {
        public TwoWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
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
        public virtual void StartingMethod(string opr = "Kick & self")
        {
            Console.WriteLine(opr);
        }
        public void Cooling()
        {
            Console.WriteLine("Autometic");
        }

        public string[] GetExteriorDesign<T>(string data) where T : Vehicle
        {
            string[] designList = data.Split(',');
            return designList;
        }
    }
}
