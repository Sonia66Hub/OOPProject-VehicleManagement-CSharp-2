using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeneric.Interfaces
{
    public interface IInteriorDesign<T>
    {
        string[] GetInteriorDesign<T>(string design);
    }
}
