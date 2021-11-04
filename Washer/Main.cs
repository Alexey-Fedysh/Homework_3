using System;
using Appliances;

namespace Input
{
    class MainInput
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer(6, 16444.00, LoadType.Frontal);
            Washer[] storage = new Washer[5];
            for(int i =0; i < storage.Length; ++i)
            {
                storage[i] = washer;
            }
            storage[0].ShowInfoWasher();

            //Авторежим
            string messege = (storage[0].StartWash(Mode.QuickWash)) ? "Successfully" : "Error";
            Console.WriteLine(messege);

            //Ручной режим 
            storage[1].ShowInfoWasher();
            PropertiesProcess prop = new PropertiesProcess();
            prop.speed = 444;
            prop.time = 14.55;
            storage[1].SetPropertiesManually(ref prop);
            string new_messege = (storage[0].Work())? "Successfully" : "Error";
            Console.WriteLine(new_messege);
        }
    }
}
