using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneProject
{
    public interface ITankerAircraft
    {
        double GetFuelTankCapacity();
        double RequestFuel(double amount);
    }
}
