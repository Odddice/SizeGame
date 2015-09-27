using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ShrinkingGame
{
    class DescrptHandler
    {

        public void DescPath()
        {
            if (VarStorage.Globals.rollType == 1)
            {
                string filePath = @"C:\Users\Odddice\Dropbox\Programming\ShrinkingGame\Grow.csv";
                Reader(filePath);
            }
            else if (VarStorage.Globals.rollType == 2)
            {
                string filePath = @"C:\Users\Odddice\Dropbox\Programming\ShrinkingGame\Shrink.csv";
                Reader(filePath);
            }
            else if (VarStorage.Globals.rollType == 3)
            {
                string filePath = @"C:\Users\Odddice\Dropbox\Programming\ShrinkingGame\Steal.csv";
                Reader(filePath);
            }
            else if (VarStorage.Globals.rollType == 4)
            {
                string filePath = @"C:\Users\Odddice\Dropbox\Programming\ShrinkingGame\Shrinker.csv";
                Reader(filePath);
            }
        }


        public void Reader(string filePath)
        {
            var lineCount = 0;
            CryptoRandom rng = new CryptoRandom();
            HeightGen format = new HeightGen();


            using (var reader = File.OpenText(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            int phrase = rng.Next(lineCount);
            string[] values = File.ReadAllText(filePath).Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string outputString = values[phrase];
            if (VarStorage.Globals.percentDelta != "")
            {
                outputString = outputString.Replace("mainName", VarStorage.Globals.mainName).Replace("otherName", VarStorage.Globals.otherName).Replace("mainSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.mainSize))).Replace("otherSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.otherSize))).Replace("mainFinalSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.mainFinalSize))).Replace("otherFinalSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.otherFinalSize))).Replace("changeDelta", format.totalHeight(Convert.ToInt32(VarStorage.Globals.changeDelta))).Replace("percentDelta", Convert.ToString(VarStorage.Globals.percentDelta) + "%").Replace("mainCompSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.mainCompSize))).Replace("otherCompSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.otherCompSize)));
            }
            else
            {
                outputString = outputString.Replace("mainName", VarStorage.Globals.mainName).Replace("otherName", VarStorage.Globals.otherName).Replace("mainSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.mainSize))).Replace("otherSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.otherSize))).Replace("mainFinalSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.mainFinalSize))).Replace("otherFinalSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.otherFinalSize))).Replace("(changeDelta)", format.totalHeight(Convert.ToInt32(VarStorage.Globals.changeDelta))).Replace("percentDelta", "").Replace("mainCompSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.mainCompSize))).Replace("otherCompSize", format.totalHeight(Convert.ToInt32(VarStorage.Globals.otherCompSize)));
            }
            VarStorage.Globals.textLine1 = outputString;
        }
    }
}
