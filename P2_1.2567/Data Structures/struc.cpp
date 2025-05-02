#include <iostream>
using namespace std;


struct Node
{
    int id;
    string name;
};


int main(){

    Node *student = new Node;
    student->id = 19;
    student->name = "Jirayu";

    

    Node *data[5];
    data[0] = student;

    student = new Node;

    student->id = 20;
    student->name = "brjow";
    data[1] = student;

    for(int i; i < 5; i++){
        cout << data[i]->id << ": " << data[i]->name << endl;
    }

    return 0;
}