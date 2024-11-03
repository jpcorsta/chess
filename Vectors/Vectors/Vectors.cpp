#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector<int> numbers;
    //numbers.push_back(0);

    for (int i = 1; i <= 10; i++) {
        numbers.push_back(i);
    }

    cout << "Size: " << numbers.size() << endl;
    cout << "Max Size: " << numbers.max_size() << endl;
    cout << "Capacity: " << numbers.capacity() << endl;
    numbers.resize(5);
    cout << "Size: " << numbers.size() << endl;
    if (numbers.empty())
        cout << "Vector is empty\n";
    else
        cout << "Vector is not empty\n";
    cout << "Element [0] is: " << numbers[0] << endl;
    cout << "Element (0) is: " << numbers.at(0) << endl;
    cout << "Front: " << numbers.front() << endl;
    cout << "Back: " << numbers.back() << endl;
    numbers.clear();
    cout << "Size: " << numbers.size() << endl;

    auto it = numbers.begin();
    cout << *(it + 5);

    for (auto it = numbers.begin(); it != numbers.end(); it++) {
          cout << *it << endl;
    }
    
   
}
