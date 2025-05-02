#include <iostream>
using namespace std;


int increment(int x){
    return x += 5;
}


int increment(int x, int y){
    return x + y;
}


int increment(int x, int y, int z){
    return z + increment(x) + increment(x, y);
}


int main(){
    
    int x = 5, y;
    cout << x << endl;

    y = increment(x);
    cout << "X Increment: " << y << endl;

    cout << increment(x, y) << endl;

    cout << increment(x, y, 15) << endl;

    return 0;
}