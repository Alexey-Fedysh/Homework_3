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
                + "\tPrice: " + Price.ToString()
                + "\tLoad type: " + LType.GetType().Name);
        }
    }
}
