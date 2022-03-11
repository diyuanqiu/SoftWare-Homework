using System;
using System.Collections.Generic;
namespace LinkedList{
    public class Node<T>{
        public Node<T> Next{ get; set; }
        public T Data{ get; set; }
        public Node(T t){
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>{
        private Node<T> head;
        private Node<T> tail;
        public GenericList(){
            tail = head = null;
        }
        public Node<T> Head{
            get => head;
        }
        public void Add(T t){
            Node<T> newNode = new Node<T>(t);
            if(tail==null){
                head = tail = newNode;
            }
            else{
                tail.Next = newNode;
                tail = newNode;
            }
        }
        public void Foreach(Action<T> action){
            Node<T> start = this.head;
            while(start!=null){
                action(start.Data);
                start = start.Next;
            }
        }
    }
    public class LinkedList{
        static void Main(String[] args){
            GenericList<int> linkedlist = new GenericList<int>();
            int sum = 0;
            int max = 0;
            int min = 100;
            for (int i = 0; i < 5; i++){
                linkedlist.Add(i);
            }
            linkedlist.Foreach(m => Console.WriteLine("The data of the linked list is {0}", m));
            linkedlist.Foreach(m => sum += m);
            linkedlist.Foreach(m => { if (m > max) max = m; });
            linkedlist.Foreach(m => { if (m < min) min = m; });
            Console.WriteLine("The sum of the linked list is {0}", sum);
            Console.WriteLine("The max of the linked list is {0}", max);
            Console.WriteLine("The min of the linked list is {0}", min);
            Console.ReadKey();
        }
    }
}