#include <iostream>
#include <time.h>
#include <vector>
#include <numeric>
using namespace std;

int GREEN = 21;
int PURPLE = 15;

int changeBluesFromGreens(int &greens, int diff) {
    // keep reducing until diff is less than 3?

    int newBlues = 0;
    while (diff > 3) {
        diff -= 3;
        greens -= 3;
        newBlues++;
    }

    return newBlues;
}

int changePurplesFromBlues(int& blues, int diff) {
    int newPurples = 0;
    while (diff > 3) {
        diff -= 3;
        blues -= 3;
        newPurples++;
    }

    return newPurples;
}

bool greenCheck(int green) {
    return green <= 16;
}

bool blueCheck(int blue) {
    return blue <= 128;
}

bool purpleCheck(int purple) {
    return purple <= 396;
}

#include <iostream>
#include <vector>
#include <numeric> // For std::accumulate

// Function to calculate the average of a vector of integers
double calculateAverage(const vector<int>& numbers) {
    if (numbers.empty()) {
        cerr << "Error: The vector is empty." << endl;
        return 0.0;
    }
    
    int sum = accumulate(numbers.begin(), numbers.end(), 0);
    return static_cast<double>(sum) / numbers.size();
}


int main()
{
    bool allChecks = false;

    int currentGreen = 0;
    int currentBlue = 0;
    int currentPurple = 0;

    int greenGoal = 16;
    int blueGoal = 128;
    int purpleGoal = 396;
    vector<int> allPower;
    int trailblazePower = 0;

    srand(time(NULL));
    for (int i = 1; i < 100; i++) {
        allChecks = false;
        currentGreen = 0;
        currentBlue = 0;
        currentPurple = 0;
        trailblazePower = 0;
        while (!allChecks) {
            int roll = 1 + (rand() % 100);
            currentGreen++;
            if (roll < GREEN) {
                currentGreen++;
            }
            currentBlue++;
            roll = 1 + (rand() % 100);
            if (roll < PURPLE) {
                currentPurple++;
            }


            trailblazePower += 10;

            if (currentGreen > greenGoal) {
                int diff = currentGreen - greenGoal;
                if (diff > 3) {
                    currentBlue += changeBluesFromGreens(currentGreen, diff);
                }
            }

            if (currentBlue > blueGoal) {
                int diff = currentBlue - blueGoal;
                if (diff > 3) {
                    currentPurple += changePurplesFromBlues(currentBlue, diff);
                }
            }


            //    cout << "Greens: " << currentGreen << ", Blues:" << currentBlue << ", Purples:" << currentPurple << endl;
            if (!greenCheck(currentGreen) && !blueCheck(currentBlue) && !purpleCheck(currentPurple)) {
                allChecks = true;
            }
        }
        allPower.push_back(trailblazePower);
        //MATH !
    }
    
    double avg = calculateAverage(allPower);
   
    cout << "Average Power used: " << avg <<", takes "<< avg/240 <<" days, 100 simulations." << endl;

}