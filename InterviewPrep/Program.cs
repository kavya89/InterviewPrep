using System;

namespace InterviewPrep
{
    class Program
    {
        static LinkedList list = new LinkedList();
        static void Main(string[] args)
        {
           // list.BuildLinkedList();
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
        public static Node SortedInsert(int value , LinkedList list1){
            Node newNode = new Node(value);
            Node current = list1.head;
            Node previous = current;

            if(list1.head == null){
                list1.AddNodeAtBeginning(value);
                return list1.head;
            }
            if(list1.head.data < value){
                list1.AddNodeAtBeginning(value);
                return list.head;
            }

            while(current != null){
                if(current.data < value){
                    previous = current;
                    current = current.next;
                }
            }

            previous.next = newNode;
            newNode.next = current;

            return list1.head;
        }

        //Write an InsertSort() function which given a list, rearranges its nodes so they are sorted in increasing order.It should use SortedInsert().
        public static Node InsertSort(LinkedList ListToSort){
            LinkedList SortedList = new LinkedList();
            Node current = ListToSort.head;
            while(current != null){
                SortedList.head = SortedInsert(current.data, SortedList);
            }

            return SortedList.head;
        }

        //Write an Append() function that takes two lists, 'a' and 'b', appends 'b' onto the end of 'a', and then sets 'b' to NULL
        public static void Append(LinkedList listB){
            Node currrent = list.head;
            if(list.head == null){
                list.head = listB.head;
                listB.head = null;
                return;
            }
            while(currrent != null){
                currrent = currrent.next;
            }

            currrent.next = listB.head;
            listB.head = null;
        }

        //Given a list, split it into two sublists — one for the front half, and one for the back half. 
        public static Node FrontBackSplit(){
            if(list.head == null){
                throw new Exception("empty list");
            }

            int length = list.GetLength()/2;
            Node current = list.head;
            int count = 1;

            while(current != null && count < length+1){
                current = current.next;
                count++;
            }

            LinkedList secondHalf = new LinkedList();
            secondHalf.head = current.next;
            current.next = null;

            return secondHalf.head;

        }

        //Write a RemoveDuplicates() function which takes a list sorted in increasing order and deletes any duplicate nodes from the list.
        public static void RemoveDuplicates(){
            Node current = list.head;
            Node previous = null;

            while(current != null){
                previous = current;
                current = current.next;
                if(current != null){
                    if(previous.data == current.data){
                        previous.next = current.next;
                        current = current.next;
                    }
                }
            }
        }

        //MoveNode() takes two lists, removes the front node from the second list and pushes it onto the front of the first. 
        public static void MoveNode(LinkedList listB){
            Node current = listB.head;

            while(current != null){
                list.AddNodeAtBeginning(current.data);
                current = current.next;
            }
        }
    }
}
