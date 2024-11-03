#include <iostream>
#include <string>

int main()

{
    int score = 0;

    using std::cout;
    using std::endl;
    {
        
        cout << "What is the smallest country?\n" << endl;
        cout << "1. Usa" << endl;
        cout << "2. Indiana" << endl;
        cout << "3. Vatican city" << endl;
        cout << "Choose 1-3" << endl;

        std::string s;
        getline(std::cin, s);
        if (s == "3") {
            cout << "correct!\n " << endl;
            score++;
            cout<<("Score: ") << + score;
            cout << "\n";
        }
        else {
            cout << "wrong " << endl;
        }
    }
    {
        cout << "What is the biggest Animal?\n" << endl;
        cout << "1. Elephant" << endl;
        cout << "2. Blue Whale" << endl;
        cout << "3. Great white shark" << endl;
        cout << "Choose 1-3" << endl;

        std::string s;
        getline(std::cin, s);
        if (s == "2") {
            cout << "correct!\n " << endl;
            score++;
            cout << ("Score:") << + score;
            cout << "\n";
        }
        else {
            cout << "wrong\n " << endl;
        }
    }
    {
        cout << "How many elements are there in the periodic table?\n" << endl;
        cout << "1. 118" << endl;
        cout << "2. 119" << endl;
        cout << "3. 120" << endl;
        cout << "Choose 1-3" << endl;

        std::string s;
        getline(std::cin, s);
        if (s == "3") {
            cout << "correct!\n " << endl;
            score++;
            cout << ("Score: ") << + score;
            cout << "\n";
        }
        else {
            cout << "wrong " << endl;
        }
    }
}