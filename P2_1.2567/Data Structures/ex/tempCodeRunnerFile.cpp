#include <iostream>
using namespace std;

void printArray(int arr[], int n)
{

    int i;
    for (i=0; i < n; i++){
        cout << arr[i] << " ";
    }
    cout << endl;
}

/*
    1. เขียนโปรแกรม โดยมีรายละเอียดดังนี้

        1.1 เขียนฟังก์ชั่น Findmin หาค่า index ของค่าที่น้อยที่สุดในอาเรย์ data และแสดงผลดังนี้ Min value index is 4

        1.2 เขียน Source code (ไม่จำเป็นต้องสร้าง function) สลับตำแหน่งในอาเรย์ระหว่าง ค่าน้อยที่สุดกับค่าแรกในอาเรย์ 
        แล้วแสดงผลข้อมูลทั้งหมดในอาเรย์บนหน้าจอดังนี้ 7 20 30 40 58 60 18 35
*/

int Findmin(int arr[], int n){
    int minIndex = 0; //กำหนดให้ array แรก เป็นค่าที่น้อยที่สุดก่อน
    for(int j = 1; j < n; j++){
        if(arr[j] < arr[minIndex]){
            minIndex = j;
        }
    }
    return minIndex;
}

void Sortdata(int arr[], int n){
    cout << "\t";
    printArray(arr, n);

    for(int i = 0; i < n; i++){
        int minIndex = i; //กำหนดต่ำแหน่ง i ให้เป็นค่าน้อยที่สุด
        for(int j = i+1; j < n; j++){ //เปรียบเทียบหาค่าที่น้อยที่สุดตั้งแต่ index i + 1 ขึ้นไป 
            if(arr[j] < arr[minIndex]){
                minIndex = j;
            }
        }
    
        int temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;

        cout << "\t";
        printArray(arr, n);
    }
}

int main(){
    int n = 8;
    int data_ex1[n] = {58,20,30,40,7,60,18,35};

    cout << "Data default: ";
    printArray(data_ex1, n);

    //1.1 เขียนฟังก์ชั่น Findmin หาค่า index ของค่าที่น้อยที่่สุดในอาเรย์ data และแสดงผลดังนี้
    cout << "Exam 1.1: call Findmin" << endl;
    cout << "\t" ; //tab เว้นระยะห่างข้อความ

    int minIndex = Findmin(data_ex1, n); //หา Index ที่น้อยสุดจาก function: Findmin()
    cout << "Min value index is " << minIndex << endl;

    
    //1.2 เขียน Source code (ไม่จำเป็นต้องสร้าง function) สลับตำแหน่งในอาเรย์ระหว่าง ค่าน้อยที่สุดกับค่าแรกในอาเรย์ 
    //แล้วแสดงผลข้อมูลทั้งหมดในอาเรย์บนหน้าจอดังนี้
    cout << "Exam 1.2: Swap data here." << endl;
    cout << "\t" ;

    //สลับค่าที่ index[0] กับ Index ที่น้อยที่สุดใน data_ex1
    int temp = data_ex1[0];
    data_ex1[0] = data_ex1[minIndex];
    data_ex1[minIndex] = temp;

    printArray(data_ex1, n);


    //2. เขียนฟังก์ชั่น sortdata เรียงข้อมูลจาก "น้อยไปมาก" โดยพิมพ์การเปลี่ยนแปลงในอาเรย์ทุกครั้ง ตัวอย่างการแสดงผล
    int data_ex2[n] = {58,20,30,40,7,60,18,35};
    cout << "Exam 2: Call Sortdata" << endl;

    Sortdata(data_ex2, n);
}