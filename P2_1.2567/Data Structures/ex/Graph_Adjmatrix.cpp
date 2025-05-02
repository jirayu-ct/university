#include <iostream>
using namespace std;

#define V 9 // Number of vertices

// Function to initialize the adjacency matrix
void initializeMatrix(int adjMatrix[V][V]) {
    for(int i = 0; i < V; i++) {
        for(int j = 0; j < V; j++) {
            adjMatrix[i][j] = 0; // Initialize all edges to 0 (no connection)
        }
    }
}

// Function to add an edge to the graph
void addEdge(int adjMatrix[V][V], int src, int dest, int weight) {
    adjMatrix[src][dest] = weight; // Directed edge from src to dest
    //adjMatrix[dest][src] = weight; // Uncomment this line for undirected graph
}

// Function to display the adjacency matrix
void displayMatrix(int adjMatrix[V][V]) {
    cout << "Adjacency Matrix:\n";
    
    for (int i = 0; i < V; i++) 
    {
        if (i == 0){
            cout << "   ";
        }
        cout << "B" << i+1 << " ";
    }

    cout << endl;
    for (int i = 0; i < V; i++) {
        cout << "B" << i+1 << "  ";
        for (int j = 0; j < V; j++) {
            if (adjMatrix[i][j+1] >= 10 && adjMatrix[i][j+1] <= 99){
                cout << adjMatrix[i][j] << " ";
                continue;
            }
            cout << adjMatrix[i][j] << "  ";
        }
        cout << endl;
    }
}

int main() {
    int adjMatrix[V][V];

    initializeMatrix(adjMatrix);

    // Adding edges between vertices (example)
    addEdge(adjMatrix, 0, 7, 7);
    addEdge(adjMatrix, 0, 8, 1);
    addEdge(adjMatrix, 1, 0, 1);
    addEdge(adjMatrix, 1, 7, 10);
    addEdge(adjMatrix, 2, 3, 3);
    addEdge(adjMatrix, 2, 8, 2);
    addEdge(adjMatrix, 3, 8, 1);
    addEdge(adjMatrix, 4, 1, 7);
    addEdge(adjMatrix, 5, 0, 6);
    addEdge(adjMatrix, 5, 1, 1);
    addEdge(adjMatrix, 5, 6, 1);
    addEdge(adjMatrix, 6, 3, 2);
    addEdge(adjMatrix, 7, 2, 5);
    addEdge(adjMatrix, 8, 5, 2);
    addEdge(adjMatrix, 8, 6, 7);

    displayMatrix(adjMatrix);

    return 0;
}