#include <iostream>
using namespace std;

int main(){
    
    int number[4] = {8, 9, 10, 11};

    for(int i = 0; i < 4; i++){
        if(number[i] == 10){
            cout << "Found at " << i;
            break;
        }
    }

    return 0;
}