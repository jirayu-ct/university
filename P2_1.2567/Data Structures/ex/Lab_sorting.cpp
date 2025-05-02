#include <iostream>
using namespace std;


void printArray(int arr[], int n){
    for(int i = 0; i < n; i++){
        cout << arr[i] << " " ;
    }
    cout << endl;
}

void InsertionSort(int arr[], int n){
    printArray(arr, n);
    
    for(int i = 1; i < n; i++){
        int key, j;
        key = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j -= 1;
        }

        arr[j + 1] = key;
        printArray(arr, n);
    }
}

void SelectionSort(int arr[], int n){
    printArray(arr, n);

    for(int i = 0; i < n; i++){
        int minIndex = i; //เก็บตำแหน่งล่าสุด
        for(int j = i + 1; j < n; j++){
            if(arr[j] < arr[minIndex]){
                minIndex = j;
            }
        }

        int temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
        
        printArray(arr, n);
    }
}


void bubbleSort(int arr[], int n){
    for(int i = 1; i < n; i++){
        cout << "Round" << i << endl;

        printArray(arr, n);
        for(int r = 1; r < n-i+1; r++){
            int j = r - 1;
            if(arr[r] <  arr[j]){
                int temp = arr[r];
                arr[r] = arr[j];
                arr[j] = temp;
            }
            printArray(arr, n);
        }
    }
}


int main(){
    int n = 8;
    int data[n] = {50, 85, 45, 10, 99, 42, 5, 33};

    SelectionSort(data,n);
}