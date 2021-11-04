using System;

namespace Appliances
{
    partial class Washer
    {
        public void ShowInfoWasher()
        {
            Console.Write("Manufacturer: " + Manufacturer
                + "\tModel: " + Model
                + "\nMaxload: " + MaxLoad.ToString()
                + "Price: " + Price.ToString()
                + "Load type: " + LType.GetType().Name);
        }
    }
}
