#include <iostream>
using namespace std;
#include <iomanip>
#include <stdlib.h>


struct Node
{
    int Id;
    string Name;
    float price;
    Node *next;
};

void insertFirst(Node **head, int newId, string newName, float newPrice){
    Node *newProduct = new Node;
    newProduct->Id = newId;
    newProduct->Name = newName;
    newProduct->price = newPrice;
    
	newProduct->next = *head;
	*head = newProduct;	
    //cout << "newProduct = " << newProduct << "\n*head = " << *head << endl;
}

void insertAfter(Node **head, int targetId, int newId, string newName, float newPrice){
    Node *newProduct = new Node;
    newProduct->Id = newId;
    newProduct->Name = newName;
    newProduct->price = newPrice;
    newProduct->next = NULL;

    Node *current = *head;
    while (current != NULL)
    {
        if(current->Id == targetId){
            newProduct->next = current->next;
            current->next = newProduct;
            return;
        }
        else{
            current = current->next;
        }
    }
    cout << "Product with ID " << targetId << " not found." << endl;
}


void insertLast(Node **head, int newId, string newName, float newPrice){
    Node *newProduct = new Node;
    newProduct->Id = newId;
    newProduct->Name = newName;
    newProduct->price = newPrice;
    newProduct->next = NULL;

    Node *current = *head;

    if(current == NULL){
        *head = newProduct;
    }
    else{
        while(current->next != NULL){
            current = current->next;
        }
        current->next = newProduct;
    }
}


void disPlay(Node *head){
    Node *product = head;

    while (product != NULL)
    {
        cout << product->Id << " " << product->Name << " "  << fixed << setprecision(2) << product->price << endl;
        product = product->next;
    }
    
}


int main(){

    
    Node *product1 = new Node{735010, "Iphon10", 13000};
    Node *product2 = new Node{735011, "Iphon11", 16000};
    Node *product3 = new Node{735012, "Iphon12", 20000};
    Node *product4 = new Node{735013, "Iphon13", 22000};

    Node *product = new Node;
    product = product1;
    product1->next = product2;
    product2->next = product3;
    product3->next = product4;

    insertFirst(&product, 73508, "Iphon8", 10000);
    insertLast(&product, 735015, "Iphon15", 25000);
    insertAfter(&product, 73508, 73509, "Iphon9", 12000);
    disPlay(product);
    Node *p = new Node;
    p = (Node *) malloc(sizeof(Node));
    p->Id = 10;
    p->next = NULL;

    cout << p->Id << endl;

    free(p);


    return 0;
}