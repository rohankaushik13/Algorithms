using System;

namespace Crack{
    public class LinkedList : Node{
        Node head;

        public LinkedList(){

            Node head = new Node();
            Create(1);
            Traverse(head);
            Create(2);
            Create(3);
            Create(4);


        }

        public void Create(int value){

        }

        public void Delete(){

        }

        public void Insert(){

        }

        public void Update(){

        }

        public Node Traverse(){
            return this;
        }
    }

    public class Node{
        private Node next;
        private int data;
    }
}