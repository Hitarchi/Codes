#include <iostream>

class Stack {
private:
    int* array;
    int top;
    int capacity;

public:
    Stack(int capacity) {
        this->capacity = capacity;
        array = new int[capacity];
        top = -1;
    }

    ~Stack() {
        delete[] array;
    }

    void push(int element) {
        if (isFull()) {
            std::cout << "Stack is full. Cannot push element." << std::endl;
        } else {
            top++;
            array[top] = element;
            std::cout << "Pushed element: " << element << std::endl;
        }
    }

    int pop() {
        if (isEmpty()) {
            std::cout << "Stack is empty. Cannot pop element." << std::endl;
            return -1; // You can throw an exception here if you prefer.
        } else {
            int poppedElement = array[top];
            top--;
            std::cout << "Popped element: " << poppedElement << std::endl;
            return poppedElement;
        }
    }

    int peek() {
        if (isEmpty()) {
            std::cout << "Stack is empty. No element to peek." << std::endl;
            return -1; // You can throw an exception here if you prefer.
        } else {
            std::cout << "Peeked element: " << array[top] << std::endl;
            return array[top];
        }
    }

    bool isEmpty() {
        return (top == -1);
    }

    bool isFull() {
        return (top == capacity - 1);
    }
};

int main() {
    Stack stack(5);

    stack.push(10);
    stack.push(20);
    stack.push(30);

    stack.pop();

    stack.push(40);
    stack.push(50);

    stack.pop();
    stack.pop();
    stack.pop();
    stack.pop();

    return 0;
}
