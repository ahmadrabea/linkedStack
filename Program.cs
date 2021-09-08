using System;
namespace linkedStack
{
    class stack<T> { // I made it generic Class in order to use this stack with multiple data type 
        public stack() { Top = null; } 
        class Node { // every node has the item value and the the next address of the item in the stack
           public T item;
           public  Node next;
        }
        Node Top , cur; // Top -> the top of the stack , cur -> temporary variable of (top) for display function
        public void push(T Element) { 
            Node NewNode = new Node(); // create new node
            NewNode.item = Element;    // pass the value into this node
            NewNode.next = Top;        // force the new node to point at the top (to connect it to the stack)
            Top = NewNode;             // finaly , updating the top by moving it to the new node 
        }
        bool isEmpty() {
            return Top == null;
        }
        public void pop() {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
            }
            else {
                Top = Top.next; // update the top to point at the older node (Top.next)
            }
        }
        public void getTop()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");           
            }
            else
            {
                Console.WriteLine(Top.item);
            }
        }
        public void Dislpay()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                cur = Top; // to avoid collapsing the stack , i used temporrary var
                while (cur != null) {
                    Console.WriteLine(cur.item);
                    cur = cur.next; // getting the stack element by element 
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stack<int> s = new stack<int>();
            s.push(100);
            s.push(200);
            s.push(300);
            s.push(400);
            s.Dislpay();
            s.pop();
            s.pop();
            s.push(100000);
            s.Dislpay();
            s.getTop();
        }
    }
}
