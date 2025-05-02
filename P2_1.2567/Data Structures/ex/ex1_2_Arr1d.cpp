#include <iostream>
using namespace std;

int main(){
    int count;
    float sum, avg;
    float number[5] = {45, 55, 39, 28, 32};

    for(auto i : number){
        sum += i;
        count++;
    }

    avg = sum / count;
    cout << "Average: " << avg << endl;
    return 0;
}