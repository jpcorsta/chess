#include <iostream>
using namespace std;

//base class
class Instrument {
public:
    virtual void MakeSound() = 0;
};
//derived class
class Accordion:public Instrument {
public:
    void MakeSound() {
        cout << "Accordion playing...\n";
    }
};
class Piano :public Instrument {
public:
    void MakeSound() {
        cout << "Piano playing...\n";
    }
};

int main()
{
    Instrument* i1 = new Accordion();
    //i1->MakeSound();
    Instrument* i2 = new Piano();
    //i2->MakeSound();

    Instrument* instruments[2] = { i1,i2 };
    for (int i = 0; i < 2; i++)
        instruments[i]->MakeSound();


    system("pause>0");
}
