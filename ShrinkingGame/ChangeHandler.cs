using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShrinkingGame;

namespace ShrinkingGame
{
    public class ChangeHandler
    {
        public void Changing()
        {
            CryptoRandom rng = new CryptoRandom();
            DescrptHandler display = new DescrptHandler();

            double mainSize = VarStorage.Globals.mainSize;
            double otherSize = VarStorage.Globals.otherSize;
            double mainFinalSize = VarStorage.Globals.mainSize;
            double otherFinalSize = VarStorage.Globals.otherSize;
            string deltaSizeRounded = "";
            VarStorage.Globals.percentDelta = "";


            int changeType = rng.Next(5) + 1;
            if (VarStorage.Globals.rollType == 1)
            {
                if (changeType <= 5)
                {
                    double rAmount = rng.Next(110) + 11;
                    double deltaSize = (rAmount / 100) * mainSize;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    mainFinalSize = mainSize + Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 1;
                    VarStorage.Globals.percentDelta = Convert.ToString(rAmount);
                }
                else
                {
                    double rAmount = rng.Next(Convert.ToInt32(mainSize));
                    double deltaSize = rAmount / 12;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    mainFinalSize = mainSize + Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 2;
                }
            }
            else if (VarStorage.Globals.rollType == 2)
            {                
                if (changeType <= 5)
                {
                    double rAmount = rng.Next(60) + 11;
                    double deltaSize = (rAmount / 100) * mainSize;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    mainFinalSize = mainSize - Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 1;
                    VarStorage.Globals.percentDelta = Convert.ToString(rAmount);
                }
                else
                {
                    double rAmount = rng.Next(Convert.ToInt32(mainSize));
                    double deltaSize = rAmount / 12;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    mainFinalSize = mainSize - Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 2;
                    VarStorage.Globals.percentDelta = "";
                }
            }
            else if (VarStorage.Globals.rollType == 3)
            {
                if (changeType <= 5)
                {
                    double rAmount = rng.Next(40) + 11;
                    double deltaSize = (rAmount / 100) * otherSize;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    mainFinalSize = mainSize + Convert.ToDouble(deltaSizeRounded);
                    otherFinalSize = otherSize - Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 1;
                    VarStorage.Globals.percentDelta = Convert.ToString(rAmount);
                }
                else
                {
                    double rAmount = rng.Next((Convert.ToInt32(otherSize)) - 1);
                    double deltaSize = rAmount / 12;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    mainFinalSize = mainSize + Convert.ToDouble(deltaSizeRounded);
                    otherFinalSize = otherSize - Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 2;
                    VarStorage.Globals.percentDelta = "";
                }
            }
            else if (VarStorage.Globals.rollType == 4)
            {
                if (changeType <= 5)
                {
                    double rAmount = rng.Next(60) + 11;
                    double deltaSize = (rAmount / 100) * otherSize;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    otherFinalSize = otherSize - Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 1;
                    VarStorage.Globals.percentDelta = Convert.ToString(rAmount);
                }
                else
                {
                    double rAmount = rng.Next(Convert.ToInt32(mainSize));
                    double deltaSize = rAmount / 12;
                    deltaSizeRounded = deltaSize.ToString("0.00");
                    mainFinalSize = mainSize - Convert.ToDouble(deltaSizeRounded);
                    VarStorage.Globals.changeType = 2;
                    VarStorage.Globals.percentDelta = "";
                }
            }

            VarStorage.Globals.mainSize = mainSize;
            VarStorage.Globals.mainFinalSize = mainFinalSize;
            VarStorage.Globals.otherFinalSize = otherFinalSize;
            VarStorage.Globals.otherSize = otherSize;
            VarStorage.Globals.changeDelta = Convert.ToDouble(deltaSizeRounded);
            VarStorage.Globals.mainCompSize = ((mainFinalSize) * 1828800) / (otherFinalSize);
            VarStorage.Globals.otherCompSize = ((otherFinalSize) * 1828800) / (mainFinalSize);
            display.DescPath();
        }
    }
}
