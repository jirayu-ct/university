#include <iostream>
using namespace std;

int main() {
    // Number of elements we actually need
    int numElements;
    cout << "Enter the number of elements you need: ";
    cin >> numElements;

    /*
    // Regular variable array allocation (static allocation with maximum size)
    const int MAX_SIZE = 100; // Maximum possible size
    int staticArray[MAX_SIZE];

    // Only fill the necessary elements
    for (int i = 0; i < numElements; i++) {
        staticArray[i] = i + 1;
    }

    cout << "Static array elements: ";
    for (int i = 0; i < numElements; i++) {
        cout << staticArray[i] << " ";
    }
    cout << endl;*/

    // Pointer variable array allocation (dynamic allocation)
    int* dynamicArray = new int[numElements];

    // Fill the necessary elements
    for (int i = 0; i < numElements; i++) {
        dynamicArray[i] = i + 1;
    }

    cout << "Dynamic array elements: ";
    for (int i = 0; i < numElements; i++) {
        cout << dynamicArray[i] << " ";
    }
    cout << endl;

    // Memory used for the static array is fixed and potentially wastes memory
    // Memory used for the dynamic array is exactly what we need and is deallocated when no longer needed

    delete[] dynamicArray; // Deallocate memory

    return 0;
}

