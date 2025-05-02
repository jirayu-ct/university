#include <iostream>
using namespace std;
#include <iomanip>

struct Product{
    int id;
    string name;
    float price;
    Product *next;
};


void insertAfter(Product *head, int targetId, int newId, string newName, float newPrice){
    //set new Node
    Product * newProduct = new Product;
	newProduct->id = newId;
	newProduct->name = newName;
    newProduct->price = newPrice;
    //set lest NULL
    newProduct->next = NULL;

    //copy head to current สำรองข้อมูล
    Product *current = head;
    
    //loop current NULL ลูปจนกว่าจะสิ้นสุด linked list
    while (current != NULL)
    {   
        //check หาค่าที่จะต่อท้าย
        if(current->id == targetId){
            // cout << current->id << endl;
            // cout << current << endl;
            // cout << current->next << endl;
            
            //เอาสินค้าใหม่เชื่อม linked list กับข้อมูลข้างหลังตำแหน่ง target
            newProduct->next = current->next;
            //เอาสินค้าตำแหน่ง target เชื่อมสินค้าใหม่
            current->next = newProduct;
            return;
        }
        else{
            //next address
            current = current->next;
        }
    }
    //Error Tap
    cout << "Product with ID " << targetId << " not found." << endl;
}


//แสดงข้อมูลสินค้าทั้งหมด
void display(Product *head){
    Product *current = head;

    //cout << " id   " << "  Name" << "     Price" << endl;
    while (current != NULL)
    {                                                       //กำหนดทศนิยมราคา 2 ตำแหน่ง
        cout << current->id << " " << current->name << " " << fixed << setprecision(2) << current->price << " BAHT"  << endl;
        current = current->next;
    }

    // cout << "Show addass current" << endl;

    // while (current != NULL)
    // {
    //     cout << &current->id << " " << &current->name << " "  << &current->price << endl;
    //     current = current->next;
    // }
}


int main(){
    //new Node
    Product *product = new Product;
    //set Product
    Product *product1 = new Product{735011, "Iphone11", 25000.25};
    Product *product2 = new Product{735013, "Iphone13", 30000.50};
    Product *product3 = new Product{735015, "Iphone15", 35000.75};
    //linked list
    product = product1;
    product1->next = product2;
    product2->next = product3;

    //insert After 735011
    insertAfter(product, 735011, 735012, "Iphone12", 27000.50);

    //show product
    display(product);

    return 0;
}




