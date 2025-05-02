#include <iostream>
using namespace std;

struct student
{
    student():name(""), score(0), status(false){}
    string name;
    int score;
    bool status;
};



int main(){

    student s1;
    s1.name = "jirayu";
    s1.score = 80;
    s1.status = true;

    cout << s1.name << endl;
    cout << s1.score << endl;
    cout << s1.status << endl;

    student s2;
    s2.name = "pompam";
    s2.score = 99;
    s2.status = true;

    return 0;
}