#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector <int> numbers;
    for (int i = 1; i <= 10; i++) {
        numbers.push_back(i);
    }

    numbers.insert(numbers.begin() + 5, 88);
    //numbers.erase(numbers.begin() + 5);
    //numbers.pop_back();

    for (auto n : numbers)
        cout << n << endl;
}
