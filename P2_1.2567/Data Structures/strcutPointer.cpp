#include <iostream>
using namespace std;


void decre(int *x){

   *x=*x-1;

}



int main(){

   int x=200;

   decre(&x);

   cout << x;

}