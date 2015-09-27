using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShrinkingGame;

class HeightGen
{
    public string totalHeight(int micrometers)
    {
        string finalHeight;
        int inches = micrometers/25400;
        int centimeters = micrometers/10000;
        int milimeters = micrometers/1000;
        if (inches >= 12)
        {
            int feet = inches / 12;
            int inchesLeft = inches % 12;
            if (feet == 0)
            {
                finalHeight = "'" + inchesLeft + " in' ";
            }
            else
            {
                if (inchesLeft == 0)
                {
                    finalHeight = "'" + feet + " ft' ";
                }
                else
                {
                    finalHeight = "'" + feet + " ft " + inchesLeft + " in' ";
                }
            }
        }
        else if (centimeters >= 1)
        {
            finalHeight = "'" + centimeters + "cm'";
            
        }
        else if (milimeters >= 1)
        {
            finalHeight = "'" + milimeters + "mm'";
            
        }
        else
        {
            finalHeight = "'" + micrometers + "um'";
            
        }
        return finalHeight;
    }
}
