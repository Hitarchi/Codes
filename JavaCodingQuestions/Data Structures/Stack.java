public class Stack {
    private int[] array;
    private int top;
    private int capacity;

    public Stack(int capacity) {
        this.capacity = capacity;
        array = new int[capacity];
        top = -1;
    }

    public void push(int element) {
        if (isFull()) {
            System.out.println("Stack is full. Cannot push element.");
        } else {
            top++;
            array[top] = element;
            System.out.println("Pushed element: " + element);
        }
    }

    public int pop() {
        if (isEmpty()) {
            System.out.println("Stack is empty. Cannot pop element.");
            return -1; // You can throw an exception here if you prefer.
        } else {
            int poppedElement = array[top];
            top--;
            System.out.println("Popped element: " + poppedElement);
            return poppedElement;
        }
    }

    public int peek() {
        if (isEmpty()) {
            System.out.println("Stack is empty. No element to peek.");
            return -1; // You can throw an exception here if you prefer.
        } else {
            System.out.println("Peeked element: " + array[top]);
            return array[top];
        }
    }

    public boolean isEmpty() {
        return (top == -1);
    }

    public boolean isFull() {
        return (top == capacity - 1);
    }

    public static void main(String[] args) {
        Stack stack = new Stack(5);

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
    }
}
