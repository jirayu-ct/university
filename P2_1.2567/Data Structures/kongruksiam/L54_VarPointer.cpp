#include <iostream>
using namespace std;

int main(){

    int number = 10;
    int *p1 = &number;
    *p1 = 500;

    //cout << "value = " << number << endl;
    //cout << "address = " << &number << endl;
    cout << "pointer address = " << p1 << endl;
    cout << "value in pointer address = " << *p1 << endl;

    return 0;
}