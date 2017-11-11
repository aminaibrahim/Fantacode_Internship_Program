using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Myqueue<T>
    {
        int size;
        T[] Arrayqueue;
        int front;
        int rear;
        public Myqueue(int Max)
        {
            size = Max;
            Arrayqueue = new T[size];
            int front = rear = -1;
        }
        public int Insert(T Element)
        {
            if (rear == -1)
            {
                front = 0;
                rear = 0;
                Arrayqueue[rear] = Element;
                return 1;
            }
            else if (rear + 1 >= size)
            {
                return -1;
            }
            else if (rear + 1 < size)
                Arrayqueue[++rear] = Element;
            return 1;
        }

        public T Delete()
        {
            T RemovedElement;
            T temp = default(T);
            if (rear < 0)
            {
                return temp;
            }
            else
            {
                RemovedElement = Arrayqueue[front];
                if (front == rear)
                {

                    front = -1;
                    rear = -1;
                }
                else
                    front++;
                return RemovedElement;
            }
        }
        public T Search(int position)
        {
            T temp = default(T);
       if (position<size && position >= 0)
       {
            return Arrayqueue[position];
        }
       return temp;
       }

      public T[] GetAllQueueElements()
      {
            if (rear < 0)
                Console.WriteLine("queue empty");
    T[] Elements = new T[rear + 1];
    Array.Copy(Arrayqueue,front, Elements,0, rear + 1);
    return Elements;
      }


    }






        public class Program
        {
            public static void Main(string[] args)
            {
                int size;
                Console.WriteLine("enter the size of the queue");
                size = int.Parse(Console.ReadLine());
                Myqueue<object> que = new Myqueue<object>(size);
                while (true)
                {
                    Console.WriteLine("1.insert");
                    Console.WriteLine("2.delete");
                    Console.WriteLine("3.search");
                    Console.WriteLine("4.display");
                    Console.WriteLine("5.exit");

                    Console.WriteLine("Enter your choice:");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter object to insert:");
                                object temp = Console.ReadLine();
                                int result = que.Insert(temp);

                                if (result != -1)
                                {
                                    Console.WriteLine("object inserted!");
                                }
                                else
                                {
                                    Console.WriteLine("queue is full");
                                }
                                break;

                            }
                        case 2:
                            {
                                object Result = que.Delete();
                                if (Result != null)
                                {
                                    Console.WriteLine("Deleted object:" + Result);
                                }
                                else
                                {
                                    Console.WriteLine("queue empty");
                                }
                                break;
                            }

                          case 3:
                            {
                                Console.WriteLine("Enter position to search:");
                                int Position = int.Parse(Console.ReadLine());
                                object Result =que.Search(Position);
                                if (Result != null)
                                {
                                    Console.WriteLine("Element at Position" + Position + " is " + Result);
                                }
                                else
                                {
                                    Console.WriteLine("Entered Element is Out of range ");
                                }
                                break;
                            }

                          case 4:
                        {
                            object[] Elements = que.GetAllQueueElements();
                            Console.WriteLine("queue elements");
                            foreach (string str in Elements)
                            {
                                Console.WriteLine(str);
                            }
                            break;
                        }
                        case 5:
                            {
                                System.Diagnostics.Process.GetCurrentProcess().Kill();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("You have Entered Wrong Choice ");
                                break;
                            }


                    }
                }
            }
        }
    }


