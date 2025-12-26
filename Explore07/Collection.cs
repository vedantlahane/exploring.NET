using System.Collections;
using System.Collections.Generic;
class Collection
{
    public void List01()
    {
        List<int> lt = new List<int>();
        lt.Add(3);
        lt.Add(5);
        lt.Add(6);
        for(int i = 0; i < lt.Count; i++){
            Console.WriteLine(lt[i]);
        }
    }

    public void ArrayList01()
    {
        ArrayList al = new ArrayList();
        al.Add(3);
        al.Add(5);
        al.Add(6);
        for(int i = 0; i < al.Count; i++){
            Console.WriteLine(al[i]);
        }
    
    }

    public void HashTable01()
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, "One");
        ht.Add(2, "Two");
        ht.Add(3, "Three");
        foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    public void Stack01()
    {
        Stack st = new Stack();//Non-generic
        st.Push(1);
        st.Push(2);
        st.Push(3);
        while (st.Count > 0)
        {
            Console.WriteLine(st.Pop());
        }


        Stack<int> st1 = new Stack<int>();//Generic
        st1.Push(1);
        st1.Push(2);
        st1.Push(3);
        while (st1.Count > 0)
        {
            Console.WriteLine(st1.Pop());
        }
    }

    public void Queue01()
    {
        Queue q = new Queue();//Non-generic, there is no type safety
        q.Enqueue(1);
        q.Enqueue("gvuhjgvyhj");
        q.Enqueue(3);
        while (q.Count > 0)
        {
            Console.WriteLine(q.Dequeue());
        }

        Queue<int> q1 = new Queue<int>();//Generic
        q1.Enqueue(1);
        q1.Enqueue(2);
        q1.Enqueue(3);
        while (q1.Count > 0)
        {
            Console.WriteLine(q1.Dequeue());
        }
    }
    
}