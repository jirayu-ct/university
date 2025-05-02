#include <iostream>
using namespace std;

int main(){
    int count;
    float sum, avg;
    float data[4][3] = {11, 14, 20, 
                        16, 12, 15, 
                        21, 17, 13, 
                        22, 23, 18};

    for(int i = 0; i < 4; i++){
        for(int j = 0; j < 3; j++){
            sum += data[i][j];
            count++;
        }
    }

    avg = sum / count;
    cout << "Average: " << avg;

    return 0;
}