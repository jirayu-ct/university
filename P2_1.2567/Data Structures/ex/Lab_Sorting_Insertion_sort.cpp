#include <iostream>
using namespace std;


void printArray(int arr[], int n){
    for(int i = 0; i < n; i++){
        cout << arr[i] << " ";
    }
    cout << endl;
}


void swap(int arr[], int n){
    for(int i = 0; i < n; i++){
        if(arr[i] == 60 && arr[i + 1] == 18){
            int temp = arr[i];
            arr[i] = arr[i+1];
            arr[i+1] = temp;
            break;
        }
    }
    printArray(arr, n);
}


void swap18(int arr[], int n){
    int j;

    for(int i = 1; i < n; i++){
        j = i - 1;
        
        if(arr[i] == 18 && arr[j] > 18){
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;

            printArray(arr, n);
            break;
        }
    }
}


void insertionSort(int arr[], int n){
    int key, j;

    for(int i = 1; i < n; i++){
        key = arr[i];
        j = i - 1;

        while(j >= 0 && arr[j] > key){
            arr[j+1] = arr[j];
            j -= 1;
        }
        arr[j+1] = key;
        printArray(arr, n);
    }
}


int main(){
    int n = 8;
    int data1[n] = {58, 20, 30, 40, 7, 60, 18, 35};
    cout << "Array Default: ";
    printArray(data1, n);
    cout << "--------------------------" << endl;
    

    int data2[n] = {58, 20, 30, 40, 7, 60, 18, 35};
    cout << "Array Swap" << endl;
    swap(data2, n);
    cout << "--------------------------" << endl;


    int data3[n] = {58, 20, 30, 40, 7, 60, 18, 35};
    cout << "Array Swap18" << endl;
    printArray(data3, n);
    swap18(data3, n);
    cout << "--------------------------" << endl;


    int data4[n] = {58, 20, 30, 40, 7, 60, 18, 35};
    cout << "Array InsertionSort" << endl;
    insertionSort(data4, n);
    
}