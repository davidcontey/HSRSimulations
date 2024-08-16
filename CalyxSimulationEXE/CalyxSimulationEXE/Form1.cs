using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalyxSimulationEXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int greenGoal;
        int blueGoal;
        int purpleGoal;

        public int changeBluesFromGreens(ref int greens, int diff)
        {
            int newBlues = 0;
            while (diff > 3)
            {
                diff -= 3;
                greens -= 3;
                newBlues++;
            }
            return newBlues;
        }

        public int changePurplesFromBlues(ref int blues, int diff)
        {
            int newPurples = 0;
            while (diff > 3)
            {
                diff -= 3;
                blues -= 3;
                newPurples++;
            }
            return newPurples;
        }

        bool greenCheck(int green)
        {
            return green <= greenGoal;
        }
        bool blueCheck(int blue)
        {
            return blue <= blueGoal;
        }
        bool purpleCheck(int purple)
        {
            return purple <= purpleGoal;
        }

        double CalculateAverage(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.Error.WriteLine("Error: The list is empty.");
                outputLabel.Text = "Broke";
                return 0.0;
            }

            int sum = numbers.Sum();
            return (double)sum / numbers.Count;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool allChecks = false;

            greenGoal = int.Parse(greenBox.Text);
            blueGoal = int.Parse(blueBox.Text);
            purpleGoal = int.Parse(purpleBox.Text);

           

            int currentGreen = 0;
            int currentBlue = 0;
            int currentPurple = 0;

            List<int> allPower =  new List<int>();
            int trailblazePower = 0;

            Random random = new Random();
            for(int i = 1; i < 100; i++)
            {
                allChecks = false;
                currentGreen = 0;
                currentBlue = 0; 
                currentPurple = 0;
                trailblazePower = 0;
                while (!allChecks)
                {
                    int roll = 1+ (random.Next(100));
                    currentGreen++;
                    if (roll < 21)
                    {
                        currentGreen++;
                    }
                    currentBlue++;
                    roll = 1 + (random.Next(100));
                    if (roll < 15)
                    {
                        currentPurple++;
                    }
                    trailblazePower += 10;
                    if (currentGreen > greenGoal)
                    {
                        int diff = currentGreen - greenGoal;
                        if (diff > 3)
                        {
                            currentBlue += changeBluesFromGreens(ref currentGreen, diff);
                        }
                    }

                    if (currentBlue > blueGoal)
                    {
                        int diff = currentBlue - blueGoal;
                        if (diff > 3)
                        {
                            currentPurple += changePurplesFromBlues(ref currentBlue, diff);
                        }
                    }

                    if(!greenCheck(currentGreen) && !blueCheck(currentBlue) && !purpleCheck(currentPurple))
                    {
                        allChecks = true;
                    }
                }
                allPower.Add(trailblazePower);
            }
            double avg=Math.Round(CalculateAverage(allPower));

            outputLabel.Text = "Average power used: " + avg.ToString() + 
                ", takes " + Math.Round(avg/240,2) + " days, 100 simulations.";

            greenBox.Text = "0";
            blueBox.Text = "0";
            purpleBox.Text = "0";
        }
    }
}
