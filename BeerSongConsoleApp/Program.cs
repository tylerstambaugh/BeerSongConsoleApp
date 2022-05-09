using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSongConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reciteOutput = Recite(8, 1);
            Console.WriteLine(reciteOutput);

            Console.ReadLine();
        }

        public static string Recite(int startBottles, int takeDown)
        {
            string lyricOne = "bottles of beer";
            string lyricOneSingular = "bottle of beer";
            string lyricTwo = "on the wall";
            string lyricThree = $"Take one down and pass it around, ";
            int currentBottle = startBottles;
            int nextBottle;

            string returnString = "";

            for (int i = startBottles; i > -1; i -= takeDown)
            {
                if (i > 2)
                {
                    nextBottle = currentBottle - 1;
                    returnString += currentBottle.ToString() + " " + lyricOne + " " + lyricTwo + ", " + currentBottle.ToString() + " " + lyricOne + ".\n" + " " 
                      + lyricThree + nextBottle.ToString() + " " + lyricOne + " " + lyricTwo + ". \n";

                    currentBottle--;
                }
                if (i == 2)
                {
                    nextBottle = currentBottle - 1;
                    returnString += currentBottle.ToString() + " " + lyricOne + " " + lyricTwo + ", " + currentBottle.ToString() + " " + lyricOne + ".\n" + " "
                      + lyricThree + nextBottle.ToString() + " " + lyricOneSingular + " " + lyricTwo + ".\n";

                    currentBottle--;
                }

                if (i == 1)
                {
                    returnString += currentBottle.ToString() + " " + lyricOneSingular + " " + lyricTwo + ", " + currentBottle.ToString() + " " + lyricOne + ".\n"
                     + "Take it down and pass it around, no more bottles of beer on the wall.";
                    currentBottle--;
                }

                if (i == 0)
                {
                    returnString += "No more bottles of beer on the wall, no more bottles of beer.\n" +
                        "Go to the store and buy some more, 99 bottles of beer on the wall.";
                }
            }
            return returnString;
        }
    }
}
