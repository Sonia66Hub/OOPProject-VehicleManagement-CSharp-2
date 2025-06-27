using OOPGeneric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric.Interfaces
{
    public interface IExteriorDesign<T> where T : Vehicle
    {
        string[] GetExteriorDesign<T>(string data) where T:Vehicle;
    }
}
