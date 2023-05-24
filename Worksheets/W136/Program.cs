using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W136
{
    internal class Program
    {
        struct BinaryTree
        {
            private int leftPointer;
            private int rightPointer;
            private string value;
            public BinaryTree(int leftPointer, int rightPointer, string value)
            {
                this.leftPointer = leftPointer;
                this.rightPointer = rightPointer;
                this.value = value;
            }
        }
        static void Main(string[] args)
        {
            BinaryTree[] penguins =
                {
                new BinaryTree(2, 5, "Humboldt"),
                new BinaryTree(0, 3, "Adelie"), 
                };
        }
    }
}
