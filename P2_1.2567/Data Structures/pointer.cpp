#include <iostream>
using namespace std;

int main(){
    /*
    string food = "Pizza";
    string *ptr = &food; //โยนค่า food ลงตัวแปร pointer

    cout << &food << endl;
    cout << ptr << endl;
    cout << *ptr << endl;

    food = "Coca cola"; //มันคือตัวเดียวกันกับ *ptr
    cout << *ptr << endl;

    cout << &ptr << endl; //?ี่อยู่

    *ptr = "coffee";
    cout << food << endl;*/


    //pointer to pointer

    int x = 5;
    cout << "Addredd of &x: "<< &x << endl;

    int *p = &x;
    cout << "p Addredd of x: " << p << endl;
    cout << "*p Value of x: " << *p << endl;

    int **q = &p;
    cout << "q Addredd of p: " << q << endl;
    cout << "*q address of x: " << *q << endl;
    cout << "**q Value of x: " << **q << endl;

    cout << "----------" << endl;

    int ***r = &q;
    cout << "r Address of q: " << r << endl;
    cout << "*r Address of p: " << *r << endl;
    cout << "**r Address of x: " << **r << endl;
    cout << "***r Value of x:" << ***r << endl;

    return 0;
}