#include <iostream>
using namespace std;

struct Smartphone {
    string name;
    int storageSpace;
    string color;
    float price;
};

struct Person {
    string name;
    int age;
    Smartphone smartphone;
};

void printSmartPhoneInfo(Smartphone smartphone) {
    cout << "Name: " << smartphone.name << endl;
    cout << "StorageSpace: " << smartphone.storageSpace << " GB" << endl;
    cout << "color: " << smartphone.color << endl;
    cout << "price: " << smartphone.price << endl;
}

void printPersonInfo(Person person) {
    cout << "name: " << person.name << endl;
    cout << "age: " << person.age << endl;
    printSmartPhoneInfo(person.smartphone);
}

int main()
{
    Smartphone smartphone;
    smartphone.name= "Iphone 12";
    smartphone.storageSpace = 32;
    smartphone.color = "Black";
    smartphone.price = 999.99;

    Smartphone smartphone2;
    smartphone2.name = "Samsung galaxy s12";
    smartphone2.storageSpace = 64;
    smartphone2.color = "Grey";
    smartphone2.price = 888.88;

    /*printSmartPhoneInfo(smartphone);
    printSmartPhoneInfo(smartphone2);*/

    Person p;
    p.name = "Saldina";
    p.age = 26;
    p.smartphone = smartphone;
    printPersonInfo(p);

    system("pause>0");
}