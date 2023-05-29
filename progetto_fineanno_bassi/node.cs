using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_fineanno_bassi
{
    internal class node
    {
           public node(string element)
            {
                Element = element;
                Next = null;
            }

            public string Element { get; set; }
            public node Next { get; set; }

           public override string ToString()
            {
                return "{" + Element + "}";
            }
        
    }

    public class MyList
    {
        private node Head { get; set; }

        public MyList()
        {
            Head = null;
        }

        public void AddTail(string el)
        {
            node n = new node(el);

            // Se la lista è vuota
            if (Head == null)
            {
                Head = n;
                return;
            }

            // Se la lista non è vuota
            // Trova l'ultimo elemento
            node i = Head;
            while (i.Next != null)
            {
                i = i.Next;
            }
            // i punta all'ultimo elemento
            i.Next = n;
        }

        // Altri metodi della classe MyList

        public override string ToString()
        {
            string s = "[";

            node i = Head;
            while (i != null)
            {
                s = s + " " + i.ToString() + " ";
                i = i.Next;
            }

            s = s + "]";

            return s;
        }
    }
}
