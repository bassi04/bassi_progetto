using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_fineanno_bassi
{
    public class TreeNode
    {
        public string Value { get;  set; }
        public TreeNode Left { get;  set; }
        public TreeNode Right { get;  set; }

        public TreeNode(string value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public void Inserisci(string value)
        {
            if (value.Length < Value.Length)
            {
                if (Left == null)
                    Left = new TreeNode(value);
                else
                    Left.Inserisci(value);
            }
            else
            {
                if (Right == null)
                    Right = new TreeNode(value);
                else
                    Right.Inserisci(value);
            }
        }

        public string ordina()
        {
            string result = "";

            if (Left != null)
                result += Left.ordina();

            result += Value + " ";

            if (Right != null)
                result += Right.ordina();

            return result;
        }
        /* public void ordina()
          {
              if (Left != null)
                  Left.ordina();


              //label1.Text == (Value);

              if (Right != null)
                  Right.ordina();
          }
         public string ordina()
         {
             string a = "";

             if (Left != null)
                 a += Left.ordina();

             a += Value + " ";

             if (Right != null)
                 a += Right.ordina();

             return a;
         }
         public override string ToString()
         {
             return ordina();
         }*/

    }

    public class BinaryTree
    {
        private TreeNode root;

        public void Inserisci(string value)
        {
            if (root == null)
                root = new TreeNode(value);
            else
                root.Inserisci(value);
        }

        public string ordina()
        {
            if (root != null)
                return root.ordina();

            return "";
        }

        public override string ToString()
        {
            return ordina();
        }

        /*public void ordina()
        {
            if (root != null)
                root.ordina();
        }*/
    }
}





































/*public void Modifica()
{
    if (Left != null)
        Left.Modifica();

    Value = Value.ToUpper(); // Esempio di modifica: converti il valore in maiuscolo

    if (Right != null)
        Right.Modifica();
}*/