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
        int gardenDays;
        Random random = new Random();

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

        void gardenOfPlenty(ref int greens, ref int blues, ref int purples)
        {
            // this is just the base without the consumption of trailblaze power
            // trigger if trailblaze power is divisible by 240 ?
            for(int i = 0; i < 12; i++)
            {
                if (bestCaseBox.Checked)
                {
                    guaranteeChance(ref greens, ref blues, ref purples);
                }
                else
                {
                    rollChance(ref greens, ref blues, ref purples);
                }
            }
            
        }

        private void rollChance(ref int currentGreen, ref int currentBlue, ref int currentPurple)
        {
            int roll = 1 + (random.Next(100));
            currentGreen++;
            if (roll < 21 && !worstCaseBox.Checked)
            {
                currentGreen++;
            }
            currentBlue++;
            roll = 1 + (random.Next(100));
            if (roll < 15 && !worstCaseBox.Checked)
            {
                currentPurple++;
            }
            
        }

        private void guaranteeChance(ref int currentGreen, ref int currentBlue, ref int currentPurple)
        { 
            currentGreen+=2;
            currentBlue++;
            currentPurple++;
        }

        //best
        private void worstCaseScenario()
        {
            bool allChecks = false;
            int day = 0;

            int currentGreen = 0;
            int currentBlue = 0;
            int currentPurple = 0;

            int trailblazePower = 0;
            
            allChecks = false;
            currentGreen = 0;
            currentBlue = 0;
            currentPurple = 0;
            trailblazePower = 0;
            while (!allChecks)
            {
                rollChance(ref currentGreen, ref currentBlue, ref currentPurple);
                trailblazePower += 10;
                if (trailblazePower <= gardenDays * 240 && trailblazePower % 240 == 0
                    && gardenOfPlentyBox.Checked)
                {
                    day++;
                    gardenOfPlenty(ref currentGreen, ref currentBlue, ref currentPurple);
                }

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

                if (!greenCheck(currentGreen) && !blueCheck(currentBlue) && !purpleCheck(currentPurple))
                {
                    allChecks = true;
                }
            }

            outputLabel.Text = "Worst case scenario power used: " + trailblazePower.ToString() +
                ", takes " + Math.Round((double)trailblazePower / 240, 2) + " days";
        }

        private void bestCaseScenario()
        {
            bool allChecks = false;
            int day = 0;

            int currentGreen = 0;
            int currentBlue = 0;
            int currentPurple = 0;

            int trailblazePower = 0;

            allChecks = false;
            currentGreen = 0;
            currentBlue = 0;
            currentPurple = 0;
            trailblazePower = 0;
            while (!allChecks)
            {
                guaranteeChance(ref currentGreen, ref currentBlue, ref currentPurple);
                trailblazePower += 10;
                if (trailblazePower <= gardenDays * 240 && trailblazePower % 240 == 0
                    && gardenOfPlentyBox.Checked)
                {
                    day++;
                    gardenOfPlenty(ref currentGreen, ref currentBlue, ref currentPurple);
                }

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

                if (!greenCheck(currentGreen) && !blueCheck(currentBlue) && !purpleCheck(currentPurple))
                {
                    allChecks = true;
                }
            }

            outputLabel.Text = "Best case scenario power used: " + trailblazePower.ToString() +
                ", takes " + Math.Round((double)trailblazePower / 240, 2) + " days";
        }

        private void simulationCase()
        {
            bool allChecks = false;
            int day = 0;

            int currentGreen = 0;
            int currentBlue = 0;
            int currentPurple = 0;

            List<int> allPower = new List<int>();
            int trailblazePower = 0;

            for (int i = 1; i < 100; i++)
            {
                allChecks = false;
                currentGreen = 0;
                currentBlue = 0;
                currentPurple = 0;
                trailblazePower = 0;
                while (!allChecks)
                {
                    rollChance(ref currentGreen, ref currentBlue, ref currentPurple);
                    trailblazePower += 10;
                    if (trailblazePower <= gardenDays*240 && trailblazePower % 240 == 0
                        && gardenOfPlentyBox.Checked)
                    {
                        day++;
                        gardenOfPlenty(ref currentGreen, ref currentBlue, ref currentPurple);
                    }

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

                    if (!greenCheck(currentGreen) && !blueCheck(currentBlue) && !purpleCheck(currentPurple))
                    {
                        allChecks = true;
                    }
                }
                allPower.Add(trailblazePower);
            }
            double avg = Math.Round(CalculateAverage(allPower));

            outputLabel.Text = "Average power used: " + avg.ToString() +
                ", takes " + Math.Round(avg / 240, 2) + " days";
        }


        //average
        private void confirmButton_Click(object sender, EventArgs e)
        {
            greenGoal = int.Parse(greenBox.Text);
            blueGoal = int.Parse(blueBox.Text);
            purpleGoal = int.Parse(purpleBox.Text);
            gardenDays = int.Parse(plentyDays.Text);  

            if (worstCaseBox.Checked && bestCaseBox.Checked)
            {
                outputLabel.Text = "Cannot check worst case and best case at the same time";
            }
            else if (worstCaseBox.Checked)
            {
                worstCaseScenario();
            }
            else if (bestCaseBox.Checked)
            {
                bestCaseScenario();
            }
            else
            {
                simulationCase();
            }
        }

        private void gardenOfPlentyBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gardenOfPlentyBox.Checked)
            {
                plentyDays.Enabled = true;
            }
            else
            {
                plentyDays.Enabled = false;
            }
        }
    }
}
