﻿using System;

namespace Appliances
{
    enum Mode
    {
        Cotton_Linen,
        Synthetics,
        Wool,
        QuickWash,
        BabyUnderwear
    }
    enum LoadType
    {
        Frontal,
        Vertical
    }
    class Washer
    {
        //Info
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public uint MaxLoad { get; private set; }
        public double Price { get; set; }
        private LoadType LType { get; set; }
        //Process
        private bool On { get; set; }
        private Mode mode{ get; set; }
        struct PropertiesProcess
        {
            public int speed;
            public double time;
        }
        private PropertiesProcess properties;

        public Washer()
        {
            Manufacturer = "Неизвестно";
            Model = "Неизвестно";
            MaxLoad = 0;
            Price = 0;
            On = false;
            LType = LoadType.Frontal;
            mode = Mode.Synthetics;
        }
        public Washer(string mr, string m, uint ml, double p, LoadType lt, Mode md): this()
        {
            Manufacturer = mr;
            Model = m;
            MaxLoad = ml;
            Price = p;
            LType = lt;
            mode = md;
        }
            
        public void ShowInfoWasher()
        {
            Console.Write("Manufacturer: " + Manufacturer
                + "\tModel: " + Model
                + "\nMaxload: " + MaxLoad.ToString()
                + "Price: " + Price.ToString()
                + "Load type: " + LType.GetType().Name);
        }
        public bool Work()
        {
            Console.WriteLine("Enter mode: " + mode.GetType().Name);
            for(int time = 0; time < properties.time; ++time) 
            {
                Console.WriteLine("Washer worked {0}\\{1} min. \t Speed: {2}", time, properties.time, properties.speed);
            }
            return true;
        }
        public bool StartWash(Mode md)
        {
            mode = md;

            if (!On)
            {
                On = true;
                switch (mode)
                {
                    case Mode.Cotton_Linen:
                        properties.speed = 400;
                        properties.time = 60.0;
                        break;
                    case Mode.Synthetics:
                        properties.speed = 600;
                        properties.time = 45.0;
                        break;
                    case Mode.Wool:
                        properties.speed = 400;
                        properties.time = 45.0;
                        break;
                    case Mode.QuickWash:
                        properties.speed = 700;
                        properties.time = 30.0;
                        break;
                    case Mode.BabyUnderwear:
                        properties.speed = 300;
                        properties.time = 60.0;
                        break;
                }
                if (Work())
                {
                    On = false;
                    return true;
                }
            }
            return false;
        }
    }
}
/*
1.1 Разработать один из классов, в соответствии с полученным вариантом.
1.2 Реализовать не менее пяти закрытых полей (различных типов), представляющих
основные характеристики рассматриваемого класса.
1.3 Создать не менее трех методов управления классом и методы доступа к его
закрытым полям.
1.4 Создать метод, в который передаются аргументы по ссылке.
1.5 Создать не менее двух статических полей (различных типов), представляющих
общие характеристики объектов данного класса.
1.6 Обязательным требованием является реализация нескольких перегруженных
конструкторов, аргументы которых определяются студентом, исходя из
специфики реализуемого класса, а так же реализация конструктора по
умолчанию.
1.7 Создать статический конструктор.
1.8 Создать массив (не менее 5 элементов) объектов созданного класса.
1.9 Создать дополнительный метод для данного класса в другом файле, используя
ключевое слово partial.
*/