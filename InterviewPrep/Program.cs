using System;

namespace InterviewPrep
{
    class Program
    {
        static LinkedList list = new LinkedList();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Kavya!");
            list.BuildLinkedList();

            int count = Count(2);

            int value = GetNth(3);
        }

        //Write a Count() function that counts the number of times a given int occurs in a list. 
        public static int Count(int val){
            Node current = list.head;
            int count = 0;
            while(current != null){
                if(current.data == val){
                    count++;
                }
            }
            return count;
        }

        //Write a GetNth() function that takes a linked list and an integer index and returns the data value stored in the node at that index position. 
        public static int GetNth(int index){
            Node current = list.head;
            int position = 1;
            while(current != null && position < index){
                current = current.next;
                position++;
            }
            if(current!=null) return current.data;
            throw new IndexOutOfRangeException();
        }

        //Write a function DeleteList() that takes a list, deallocates all of its memory and sets its head pointer to NULL(the empty list).
        public static void DeleteList(){
            Node current = list.head;
            while(list.head != null){
                list.head = list.head.next;
                current = null; // free node
                current = list.head;
            }
        }

        //Write a Pop() function that is the inverse of Push(). Pop() takes a non-empty list, deletes the head node, and returns the head node's data.
        public static int POP(){
            Node current = list.head;
            if(current != null){
                list.head = list.head.next;
                return current.data;
            }
            //empty list
            return -1;
        }

        //write a function InsertNth() which can insert a new node at any index within a list
        public static void InsertNth(int index, int value){
            list.AddNodeAtIndex(value,index);
        }

        //Write a SortedInsert() function which given a list that is sorted in increasing order, and a 
        //single node, inserts the node into the correct sorted position in the list. 
        public static void SortedInsert(int value){
            
        }

    }
}
