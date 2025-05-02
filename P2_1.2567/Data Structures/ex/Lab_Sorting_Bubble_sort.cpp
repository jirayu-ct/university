#include <iostream>
using namespace std;


void printArray(int arr[], int n){
    for(int i = 0; i < n; i++){
        cout << arr[i] << " ";
    }
    cout << endl;
}


void swap(int arr[], int n){
    if(arr[0] > arr[1]){
        int temp = arr[0];
        arr[0] = arr[1];
        arr[1] = temp;
    }
    printArray(arr, n);
}


void swap0(int arr[], int n){
    int j;
    
    printArray(arr, n);
    for(int i = 1; i < n; i++){
        j = i - 1;
        if(arr[j] > arr[i]){
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
        printArray(arr, n);
    }
}


void bubbleSort(int arr[], int n){
    int j;

    for(int i = 1; i < n; i++){
        cout << "Round: " << i << endl;

        printArray(arr, n);
        for(int r = 1; r < n-i+1; r++){
            j = r - 1;
            if(arr[j] > arr[r]){
                int temp = arr[j];
                arr[j] = arr[r];
                arr[r] = temp;
            }
            printArray(arr, n);
        }
    }
    
}


int main(){
    int n = 8;
    int data1[n] = {58, 20, 30, 40, 7, 60, 18, 35};

    cout << "Array Default: ";
    printArray(data1, n);
    cout << "--------------------------" << endl;

    cout << "Array Swap" << endl;
    swap(data1, n);
    cout << "--------------------------" << endl;

    int data2[n] = {58, 20, 30, 40, 7, 60, 18, 35};
    cout << "Array Swap0" << endl;
    swap0(data2, n);
    cout << "--------------------------" << endl;


    int data3[n] = {58, 20, 30, 40, 7, 60, 18, 35};
    cout << "Array Bubble Sort" << endl;
    bubbleSort(data3, n);
}