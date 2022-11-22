public class LinkedList
{
    Node head; // head of linked list 

    /* Linked list node */
    public class Node
    {
       public int data;
       public Node next;
       public Node(int d)
        {
            data = d;
            next = null;
        }
    }
   
    /* Function to print middle of linked list */
    //Complete this function
    public void printMiddle()
    {
        //Write your code here
        //Implement using Fast and slow pointers
        if (head != null)
        {
            Node fast = head;
            Node slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine($"Mid point:{slow.data}");
        }
    }

    public void push(int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        head = new_node;
    }

    /*Finding the length of the list.*/
   


    public void printList()
    {
        Node tnode = head;
        while (tnode != null)
        {
            Console.WriteLine(tnode.data + "->");
            tnode = tnode.next;
        }
        Console.WriteLine("NULL");
    }

    public static void Main(String[] args)
    {
        LinkedList llist = new LinkedList();
        for (int i = 15; i > 0; --i)
        {
            llist.push(i);
            llist.printList();
            llist.printMiddle();
        }
        Console.ReadLine();
    }
}