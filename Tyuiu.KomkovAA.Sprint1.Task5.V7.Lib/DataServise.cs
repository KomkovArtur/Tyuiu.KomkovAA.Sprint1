﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KomkovAA.Sprint1.Task5.V7.Lib
{
    public class DataServise : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            return Convert.ToInt32(f / 30);
        }
    }
}
