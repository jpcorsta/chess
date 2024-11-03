#include <iostream>
#include <vector>
using namespace std;

bool ascendingCompare(int a, int b) {
    return a < b;
}
bool descendingCompare(int a, int b) {
    return a > b;
}

void customSort(vector<int>& numbersVector,bool(*compareFuncPtr)(int, int)) {
    for (int startIndex = 0; startIndex < numbersVector.size(); startIndex++)
    {
        int bestIndex = startIndex;

        for (int currentIndex = startIndex + 1; currentIndex < numbersVector.size(); currentIndex++)
        {
            // we are doing comparison here
            if (compareFuncPtr(numbersVector[currentIndex], numbersVector[bestIndex]))
                bestIndex = currentIndex;
        }
        swap(numbersVector[startIndex], numbersVector[bestIndex]);
    }
}

void printNumbers(vector<int>& numbersVector) {
    for (int i = 0; i < numbersVector.size(); ++i)
        cout << numbersVector[i] << ' ';
}

int main()
{
    vector<int>myNumbers = { 2,5,1,3,6,4 };
    bool(*funcPtr)(int, int) = descendingCompare;
    customSort(myNumbers, funcPtr);
    printNumbers(myNumbers);
    
    system("pause>nul");
}
