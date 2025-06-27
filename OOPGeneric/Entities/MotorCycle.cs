using OOPGeneric.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric.Entities
{
    public sealed class MotorCycle<T>:TwoWheeler<T> where T : Vehicle
    {
        int maximumPowerinBPH;
        int maximumTorqueInNM;
        int milageInKMPL;
        string frontBreak;
        string rearBreak;

        public MotorCycle(int maximumPowerinBPH, int maximumTorqueInNM, int milageInKMPL, string frontBreak, string rearBreak, string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.maximumPowerinBPH = maximumPowerinBPH;
            this.maximumTorqueInNM = maximumTorqueInNM;
            this.milageInKMPL = milageInKMPL;
            this.frontBreak = frontBreak;
            this.rearBreak = rearBreak;
        }

        public int MaximumPowerinBPH { get => maximumPowerinBPH; set => maximumPowerinBPH = value; }
        public int MaximumTorqueInNM { get => maximumTorqueInNM; set => maximumTorqueInNM = value; }
        public int MilageInKMPL { get => milageInKMPL; set => milageInKMPL = value; }
        public string FrontBreak { get => frontBreak; set => frontBreak = value; }
        public string RearBreak { get => rearBreak; set => rearBreak = value; }

        public override void ShowVehicleType()
        {
            Console.WriteLine("Child of two wheeler");
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Car Information\n\nVehicle Model: {ModelNo}\nManufacturing Year:{YearMake}\nNumber of Gear: {NumberOfGear}\nEngine Capacity: {EngineCapacity}\nVehicle Type: {Type}\nMaximum Power:{maximumPowerinBPH}\nMaximum Torque {maximumTorqueInNM}\nMilage {milageInKMPL}\nFront Break: {frontBreak}\nRear Break {rearBreak}");
        }
    }
}
