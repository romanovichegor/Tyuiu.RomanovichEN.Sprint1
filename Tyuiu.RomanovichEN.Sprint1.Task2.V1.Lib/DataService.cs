﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovichEN.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        public double ConvertKmToM(int value)
        {
            return Math.Round(value/(float)1.609,3);
        }
    }
}
