using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShrinkingGame;

public class ChangeDesc
{
    public void GrowDisplay()
    {
        HeightGen printHeight = new HeightGen();
        if (VarStorage.Globals.changeType == 1)
        {            
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " grows by " + VarStorage.Globals.percentDelta + "% (" +  printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + ") to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";
        }
        else
        {
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " grows " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + " to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";
        }
        VarStorage.Globals.textLine2 = VarStorage.Globals.mainName + " now appears " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.mainCompSize)) + " to the " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.otherFinalSize)) + " tall " + VarStorage.Globals.otherName;
        VarStorage.Globals.textLine3 = VarStorage.Globals.otherName + " looks to be " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.otherCompSize)) + " tall to " + VarStorage.Globals.mainName + ".";

    }
    public void ShrinkDisplay()
    {
        HeightGen printHeight = new HeightGen();
        if (VarStorage.Globals.changeType == 1)
        {
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " shrinks by " + VarStorage.Globals.percentDelta + "% (" + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + ") to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";

        }
        else
        {
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " shrinks " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + " to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";
        }
        VarStorage.Globals.textLine2 = VarStorage.Globals.mainName + " now appears " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.mainCompSize)) + " to the " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.otherFinalSize)) + " tall " + VarStorage.Globals.otherName;
        VarStorage.Globals.textLine3 = VarStorage.Globals.otherName + " looks to be " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.otherCompSize)) + " tall to " + VarStorage.Globals.mainName + ".";
    }
    public void StealDisplay()
    {
        HeightGen printHeight = new HeightGen();
        if (VarStorage.Globals.changeType == 1)
        {
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " steals " + VarStorage.Globals.percentDelta + "% (" + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + ") from " + VarStorage.Globals.otherName + " causing them to swell up to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";
        }
        else
        {
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " steals " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + " from " + VarStorage.Globals.otherName + " causing them to swell up to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";
        }
        VarStorage.Globals.textLine2 = VarStorage.Globals.mainName + " now appears " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.mainCompSize)) + " to the " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.otherFinalSize)) + " tall " + VarStorage.Globals.otherName;
        VarStorage.Globals.textLine3 = VarStorage.Globals.otherName + " looks to be " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.otherCompSize)) + " tall to " + VarStorage.Globals.mainName + ".";
    }
    public void GiveDisplay()
    {
        HeightGen printHeight = new HeightGen();
        if (VarStorage.Globals.changeType == 1)
        {
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " gives " + VarStorage.Globals.percentDelta + "% (" + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + ") to " + VarStorage.Globals.otherName + " causing them to shrink to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";
        }
        else
        {
            VarStorage.Globals.textLine1 = VarStorage.Globals.mainName + " gives " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.changeDelta)) + " to " + VarStorage.Globals.otherName + " causing them to shrink to " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.mainFinalSize)) + ".";
        }
        VarStorage.Globals.textLine2 = VarStorage.Globals.mainName + " now appears " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.mainCompSize)) + " to the " + printHeight.totalHeight(Convert.ToInt32(12 * VarStorage.Globals.otherFinalSize)) + " tall " + VarStorage.Globals.otherName;
        VarStorage.Globals.textLine3 = VarStorage.Globals.otherName + " looks to be " + printHeight.totalHeight(Convert.ToInt32(VarStorage.Globals.otherCompSize)) + " tall to " + VarStorage.Globals.mainName + ".";
    }
}

//"ChangeType= " + VarStorage.Globals.changeType + " " +