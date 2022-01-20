using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkLIstProgramAssgn
{
     class LinkLIstAssign:IComparable
    {
        internal Node head;

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next= node;
            }
            Console.WriteLine("{0} is added to linklist",node.data);
        }

        internal void Display()
        {
            Console.Write("List =");
            Node temp = this.head;
            int count = 0;
            if (temp == null) 
            {
                Console.WriteLine("liinked list is empty");
            }
            else
            {
                while(temp != null)
                {
                    
                    Console.Write(temp.data+" ");
                    count=count+1;
                    temp=temp.next;
                }
                Console.Write(" size: " + count++);

            }

        }
        internal Node insertAtPerticularPosition(int position,int data)
        {
            if(position<1)
            {
                Console.WriteLine("invalid position");
            }
            if(position==1)
            {
                var newnode=new Node(data);
                newnode.next= this.head;
                head=newnode;
            }
            else
            {
                Node temp=this.head;
                while(position-- !=0)
                {
                    if(position == 1)
                    {
                        Node node=new Node(data);   
                        node.next= this.head.next;
                        head.next= node;

                        break;
                    }
                    temp=temp.next;
                }
                if(position!=1)
                {
                    Console.WriteLine("position is out of range");
                }

            }
            return head;        
        }
        internal Node removeFirstnode()
        {
            if(head == null)
                return null;

            this.head=this.head.next;
            return this.head;
        }
        internal Node removeLastnode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newnode = head;
            while(newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            return head;
        }
        internal Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                    //break;
                }
                this.head = this.head.next;

            }
            return null;
        }
        internal Node Searchnew()
        {
                var v= Search(30);
                if (v != null)
                { 
                    insertAtPerticularPosition(2,40);
                }
            return null;
        }
        internal void Organizedlist()
        {
            //if(this.head==null)
            //Console.WriteLine("list is empty");
            //  return null;
            //if (this.head.next == null)
            //  return null;
            Node Current = head;
            int temp1;
            Node newnode = null;

            if (this.head == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            else
            {
                while (Current != null)
                {
                    newnode = Current.next;
                    while (newnode != null)
                    {
                        if (Current.data.CompareTo(newnode.data) > 0)
                        {
                            temp1 = Current.data;
                            Current.data = newnode.data;
                            newnode.data = temp1;
                        }
                        newnode = newnode.next;
                    }
                    Current = Current.next;
                }
            }
        } 
}    }   
                   // temp = this.head;
                   // if (temp.data.CompareTo(newnode.data) >= 0)
                   // {
                   // this.head.data = newnode.data;
                   // newnode.data =temp.data;
                   //// temp.next = this.head.next;
                   // //newnode = temp.next;
                   // Console.WriteLine(" head " + this.head.data);
                   // Console.WriteLine(" temp" + temp.data);
                   // //Console.WriteLine(" new node " + newnode.data);
                   // }
                   // else //56-30 false then 56 becomes head.data and 30 becomes this.head.next
                   // {
                   // this.head.data = temp.data;
                   // temp.next = this.head.next;
                   // newnode = temp.next;
                   // Console.WriteLine(" head " + this.head.data);
                   // Console.WriteLine("temp  " + temp.data);

                    //Console.WriteLine(" newnode" + newnode.data);
            
                //    temp=this.head.next;
                //    newnode=temp.next;
                //    Console.WriteLine(" "+temp.data);
                //}

               // this.head = this.head.next;
           // }
         //   return null;
       // }
   // }
//}
