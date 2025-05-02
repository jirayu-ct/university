#include <iostream>
using namespace std;


void increment(int x){
    x += 1;
    cout << "Increment1: " << x << endl;
}


void increment2(int *x){
    *x += 1;
}


int main(){
    
    int x = 10;
    cout << x << endl;

    increment(x);
    cout << "Increment1: " << x << endl;

    increment2(&x);
    cout << "Increment2: " << x << endl;

    return 0;
}